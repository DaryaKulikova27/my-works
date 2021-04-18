using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Statistics
{
    class Program
    {
        //строка подключения
        private static string connectionString = @"Server=LAPTOP-N22I487A\SQLEXPRESS;Database=Shop;Trusted_Connection=True;";

        static void Main(string[] args)
        {
            List<Statistics> customerStatistics = ReadPosts();
            int Count = 0;
            Console.WriteLine("Statistics: ");
            foreach (Statistics statisticsData in customerStatistics)
            {
                Console.WriteLine();
                Console.Write("\t");
                Console.Write($"Name: {statisticsData.Name}");
                if (Count != 0)
                {
                    Console.Write("\t");
                };
                Console.Write($"\t NumberOfOrders: {statisticsData.NumberOfOrders}");
                Console.Write($"\t SumOfOrders: {statisticsData.SumOfOrders}");
                Count++;
            }
            Console.ReadKey();
        }

        private static List<Statistics> ReadPosts()
        {
            List<Statistics> customerStatistics = new List<Statistics>();
            //подключение базы данных
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //открытие подключения
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    //sql - выражение, объединение таблиц, подсчет заказов и суммы заказов, группировка по имени
                    command.CommandText = @"SELECT 
                            [Name], 
                            COUNT([Order].[CustomerId]) AS [NumberOfOrders],
                            SUM([Price]) AS [SumOfOrders]
                          FROM 
                            Customer
                          JOIN [Order]
                            ON [Order].[CustomerId] =  [Customer].[CustomerId]
                          GROUP BY [Name];";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows) //если есть данные
                        {
                            while (reader.Read()) //построчно считываем данные
                            {
                                var statisticsData = new Statistics  //создание объекта, который позже добавялется в список объектов List
                                {
                                    Name = Convert.ToString(reader[0]),
                                    NumberOfOrders = Convert.ToInt32(reader[1]),
                                    SumOfOrders = Convert.ToInt32(reader[2])
                                };
                                customerStatistics.Add(statisticsData);
                            }

                        }
                    }
                }
            }
            return customerStatistics;
        }
    }
}

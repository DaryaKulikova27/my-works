let inputNumber = document.getElementById('input-number');
let inputNumberSystem = document.getElementById('number-system');
let button = document.getElementById('btn');

inputNumber.addEventListener('input', function(){
  let nInput = inputNumber.value;
  window.n = parseInt(nInput);
});


inputNumberSystem.addEventListener('input', function(){
  let kInput = inputNumberSystem.value;
  window.k = parseInt(kInput);
});

function createConvertedNumber(n, k) {
  let blockResultNumber = document.querySelector('.result-number');
  let blockDifferenceNumber = document.querySelector('.difference-number');
  let resultNumber = document.createElement('h2');
  let resultDifference = document.createElement('h2');

  let digit = 1;
  let convertedNumber = 0;
  let sumOfDigits = 0;
  let multOfDigits = 1;
  while (n > 0) {
    convertedNumber = convertedNumber + (n % k) * digit;
    sumOfDigits = sumOfDigits + (n % k);
    multOfDigits = multOfDigits * (n % k);
    n = Math.floor(n / k);
    digit = digit * 10;
  } //проверка если пользователь просто нажал на кнопку и ничего до этого не ввел
  if ((sumOfDigits === 0) && (multOfDigits === 1)) {
    return;
  } else {
    resultNumber.textContent = convertedNumber;
    resultDifference.textContent = multOfDigits - sumOfDigits;

    blockResultNumber.append(resultNumber);
    blockDifferenceNumber.append(resultDifference);
  }

  return {
    resultNumber,
    resultDifference,
  }
}

button.addEventListener('click', function(){
  let n = window.n;
  let k = window.k;
  console.log(n);
  console.log(k);
  createConvertedNumber(n, k);
});





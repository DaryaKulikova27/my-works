var modal = document.getElementById('myModal');
var btn = document.getElementById("myBtn");
var span = document.getElementsByClassName("close")[0];
var hidden = document.getElementsByClassName("hidden")[0];
var btnf = document.getElementById('films_bitton');

btn.onclick = function() {
 modal.style.display = "block";
}
span.onclick = function() {
 modal.style.display = "none";
}
window.onclick = function(event) {
 if (event.target == modal) {
   modal.style.display = "none";
 }
}

btnf.onclick = function()
{
  hidden.classList.remove("hidden");
}

function checkForm(event)
{

  var name = document.getElementById('name');
  var email = document.getElementById('email');
  var message = document.getElementById('message');
  if (!name.value || !email.value || !message.value)
    event.preventDefault();
  if (!name.value)
    name.className = 'field_red';
  if (!email.value)
    email.className = 'field_red';
  if (!message.value)
  {
    message.className = 'field_message_red';
  }
    message.className = 'field_message_red'

  name.addEventListener('click', backStyle);
  email.addEventListener('click', backStyle);
  message.addEventListener('click', backStyleMes);
}

function backStyle(event)
{
  event.target.className = 'field';
}

function backStyleMes(event)
{
   event.target.className = 'field_message';
}

document.getElementById('send').addEventListener('click', checkForm);

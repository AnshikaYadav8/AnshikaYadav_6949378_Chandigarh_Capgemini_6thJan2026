// REGISTER

let registerForm = document.getElementById("registerForm");

if(registerForm){

registerForm.addEventListener("submit", function(e){

e.preventDefault();

let username = document.getElementById("username").value;
let email = document.getElementById("email").value;
let password = document.getElementById("password").value;
let confirmPassword = document.getElementById("confirmPassword").value;

let emailPattern = /^[^ ]+@[^ ]+\.[a-z]{2,3}$/;

if(!email.match(emailPattern)){
alert("Invalid email format");
return;
}

if(password.length < 6){
alert("Password must be at least 6 characters");
return;
}

if(password !== confirmPassword){
alert("Passwords do not match");
return;
}

let user = {
username: username,
email: email,
password: password
};

localStorage.setItem(email, JSON.stringify(user));

alert("Registered Successfully!");

window.location.href = "login.html";

});

}


// LOGIN

let loginForm = document.getElementById("loginForm");

if(loginForm){

loginForm.addEventListener("submit", function(e){

e.preventDefault();

let email = document.getElementById("loginEmail").value;
let password = document.getElementById("loginPassword").value;

let storedUser = localStorage.getItem(email);

if(!storedUser){
alert("User not found!");
return;
}

let userData = JSON.parse(storedUser);

if(userData.password === password){
alert("Login Successful! Welcome " + userData.username);
}
else{
alert("Incorrect Password");
}

});

}
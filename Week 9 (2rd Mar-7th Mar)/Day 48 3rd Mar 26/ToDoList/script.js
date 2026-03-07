let tasks = JSON.parse(localStorage.getItem("tasks")) || [];

function displayTasks(){

let taskList = document.getElementById("taskList");
taskList.innerHTML = "";

tasks.forEach((task,index)=>{

let li = document.createElement("li");

let checkbox = document.createElement("input");
checkbox.type = "checkbox";
checkbox.checked = task.completed;

checkbox.onchange = function(){
tasks[index].completed = !tasks[index].completed;
saveTasks();
displayTasks();
};

let span = document.createElement("span");
span.textContent = task.text;

if(task.completed){
span.classList.add("completed");
}

let deleteBtn = document.createElement("button");
deleteBtn.textContent = "Delete";
deleteBtn.classList.add("delete-btn");

deleteBtn.onclick = function(){
tasks.splice(index,1);
saveTasks();
displayTasks();
};

li.appendChild(checkbox);
li.appendChild(span);
li.appendChild(deleteBtn);

taskList.appendChild(li);

});

}

function addTask(){

let input = document.getElementById("taskInput");
let taskText = input.value.trim();

if(taskText === ""){
alert("Please enter a task");
return;
}

tasks.push({
text: taskText,
completed:false
});

input.value="";

saveTasks();
displayTasks();

}

function saveTasks(){
localStorage.setItem("tasks",JSON.stringify(tasks));
}

displayTasks();
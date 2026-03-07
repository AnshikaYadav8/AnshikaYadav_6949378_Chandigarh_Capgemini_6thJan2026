const questions = [
    {
        question: "Which language runs in the browser?",
        options: ["Python", "Java", "C++", "JavaScript"],
        answer: 3
    },
    {
        question: "Which is used for styling web pages?",
        options: ["HTML", "CSS", "SQL", "C#"],
        answer: 1
    },
    {
        question: "Which is a JavaScript framework?",
        options: ["React", "Django", "Laravel", "Flask"],
        answer: 0
    }
];

let currentQuestion = 0;
let score = 0;

const questionEl = document.getElementById("question");
const optionsEl = document.getElementById("options");
const nextBtn = document.getElementById("nextBtn");
const resultEl = document.getElementById("result");

function loadQuestion() {

    nextBtn.disabled = true;
    optionsEl.innerHTML = "";

    let q = questions[currentQuestion];
    questionEl.textContent = q.question;

    q.options.forEach((option, index) => {
        let btn = document.createElement("button");
        btn.textContent = option;
        btn.classList.add("option-btn");
        btn.onclick = () => selectAnswer(btn, index);
        optionsEl.appendChild(btn);
    });
}

function selectAnswer(button, index) {

    let correctIndex = questions[currentQuestion].answer;
    let buttons = document.querySelectorAll(".option-btn");

    buttons.forEach((btn, i) => {
        if (i === correctIndex) {
            btn.classList.add("correct");
        }
        btn.disabled = true;
    });

    if (index === correctIndex) {
        score++;
    } else {
        button.classList.add("wrong");
    }

    nextBtn.disabled = false;
}

nextBtn.addEventListener("click", () => {

    currentQuestion++;

    if (currentQuestion < questions.length) {
        loadQuestion();
    } else {
        showResult();
    }

});

function showResult() {

    questionEl.textContent = "Quiz Completed!";
    optionsEl.innerHTML = "";
    nextBtn.style.display = "none";

    let message = "";

    if (score === questions.length) {
        message = "Excellent Performance!";
    } else if (score >= questions.length / 2) {
        message = "Good Job!";
    } else {
        message = "Keep Practicing!";
    }

    resultEl.innerHTML = `
        <h3>Your Score: ${score}/${questions.length}</h3>
        <p>${message}</p>
        <button onclick="location.reload()">Restart Quiz</button>
    `;
}

loadQuestion();
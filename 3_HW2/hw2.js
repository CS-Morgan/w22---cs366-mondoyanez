var button = document.getElementsByTagName("button");
var answers = ["eich", "question2a2", "interpreted", "10Days", "question5a1"];
let userAnswers = [];

function addToAnswers(currentQuestion)
{
    for (let question of currentQuestion)
    {
        if (question.checked)
        {
            userAnswers.push(question.id);
        }
    }

};

function checkAnswers()
{
    var numCorrect = 0;

    for (let i = 0; i < 5; i++)
    {
        var id = userAnswers[i];
        var element = document.getElementById(id);
        element = element.parentElement;
        if (answers[i] === userAnswers[i])
        {
            element.classList.add("correct");
            numCorrect += 1;
        }
        else
        {
            element.classList.add("incorrect");
            id = answers[i];
            element = document.getElementById(id);
            element = element.parentElement;
            element.classList.add("correct");
        }
    }

    if (getScore(numCorrect) === 1)
    {
        $(".row").after("<div class = \"perfect\"><h4>PERFECT</h4></div>");
    }
    else if (getScore(numCorrect) >= 0.7)
    {
        $(".row").after("<div class = \"pass\"><h4>PASS</h4></div>");
    }
    else if (getScore(numCorrect) < 0.7)
    {
        $(".row").after("<div class = \"fail\"><h4>FAIL</h4></div>");
    }
    else
    {
        alert("Something went wrong");
    }
}

function getScore(score)
{
    const totalQuestions = 5;
    return score / totalQuestions;
}

function emptyUserAnswers()
{
    userAnswers = [];
}

$(button).click(function(){
    var currentQuestion = document.getElementsByName("q1");
    addToAnswers(currentQuestion);

    currentQuestion = document.getElementsByName("q2");
    addToAnswers(currentQuestion);

    currentQuestion = document.getElementsByName("q3");
    addToAnswers(currentQuestion);

    currentQuestion = document.getElementsByName("q4");
    addToAnswers(currentQuestion);

    currentQuestion = document.getElementsByName("q5");
    addToAnswers(currentQuestion);

    checkAnswers();
});
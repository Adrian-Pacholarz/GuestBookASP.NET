let sendButton = document.getElementsByName("sendButton")[0];
let allBoxes = document.querySelectorAll('[name="feedback"], [name="name"]');
let feedback = allBoxes[0];
let name = allBoxes[1];
let nameError = document.getElementById("nameError");
let feedbackError = document.getElementById("feedbackError");
let hiddenComment = document.getElementById("hiddenComment");
let hiddenName = document.getElementById("hiddenName");


let checkBoxes = function () {

    sendButton.removeAttribute("disabled")

    for (let i = 0; i < allBoxes.length; i++) {
        if (allBoxes[i].value.length == 0) {
            sendButton.disabled = true
        }
    }
};


let checkName = function () {

    let messages = "";
    if (name.value.trim().length == 0 || name.value.length > 15) {
        messages += "Name too short or too long (max 15 characters). "
    }

    if (!/^[a-z/\s/]+$/i.test(name.value)) {
        messages += "Name field can contain only letters and spaces. "
    }

    nameError.textContent = messages;
    nameError.style.color = "red";
}

let checkFeedback = function () {

    let messages = "";
    if (feedback.value.trim().length == 0) {
        messages += "Comment field can not be empty. "
    }

    feedbackError.textContent = messages;
    feedbackError.style.color = "red";
}

let validateForm = function () {

    if (feedbackError.textContent.length == 0 && nameError.textContent.length == 0) {

        alert("Thank you! Your comment has been added!");
    }
    else {
        return false
    }
}

document.addEventListener('keyup', checkBoxes);
sendButton.addEventListener('click', checkName);
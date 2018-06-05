import { user } from './user.js';
function showMessage() {
    alert('Congratulations to you! This application was created intern Fedorenko!');
}
export function confirmAge() {
    var messege = parseInt(prompt("What's your age?", "Enter your age"));
    if (messege >= 18) {
        showMessage();
    } else {
        window.location.href = 'https://www.youtube.com/watch?v=OK03o3BHafk';
    }
}

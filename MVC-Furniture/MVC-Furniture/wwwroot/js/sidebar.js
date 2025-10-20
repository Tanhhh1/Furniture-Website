let btn = document.querySelector("#btn");
let sidebar = document.querySelector(".sidebar");

btn.onclick = function () {
    sidebar.classList.toggle("active");
}

/*----------------------------------------------------------*/
const dateElement = document.getElementById("currentDate");
const now = new Date();

const options = { weekday: 'long', year: 'numeric', month: 'long', day: 'numeric' };
const formattedDate = now.toLocaleDateString('vi-VN', options);

dateElement.textContent = formattedDate.charAt(0).toUpperCase() + formattedDate.slice(1);

/*----------------------------------------------------------*/
const avatar = document.getElementById("avatar");
const avatarInput = document.getElementById("avatarInput");

avatar.addEventListener("click", () => {
    avatarInput.click();
});

avatarInput.addEventListener("change", (event) => {
    const file = event.target.files[0];
    if (file) {
        const reader = new FileReader();
        reader.onload = (e) => {
            avatar.src = e.target.result; // Hiển thị ảnh mới
        };
        reader.readAsDataURL(file);
    }
});

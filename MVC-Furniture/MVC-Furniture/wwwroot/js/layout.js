const menuBtn = document.getElementById("menu-btn");
const navLinks = document.getElementById("nav-links");
const menuBtnIcon = menuBtn.querySelector("i");

menuBtn.addEventListener("click", () => {
    navLinks.classList.toggle("open");

    const isOpen = navLinks.classList.contains("open");
    menuBtnIcon.setAttribute("class", isOpen ? "bx bx-x" : "bx bx-menu");
});

navLinks.addEventListener("click", () => {
    navLinks.classList.remove("open");
    menuBtnIcon.setAttribute("class", "bx bx-menu");
});

const scrollRevealOption = {
    distance: "50px",
    origin: "bottom",
    duration: 1000,
};

ScrollReveal().reveal(".section-title h1", {
    ...scrollRevealOption,
});

ScrollReveal().reveal(".section-title p", {
    ...scrollRevealOption,
    delay: 500,
});

ScrollReveal().reveal(".section-title form", {
    ...scrollRevealOption,
    delay: 1000,
});

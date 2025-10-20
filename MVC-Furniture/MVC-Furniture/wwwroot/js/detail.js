document.addEventListener("DOMContentLoaded", () => {
    const mainImage = document.getElementById("mainImage");
    const thumbnails = document.querySelectorAll(".thumbnail_container img");

    thumbnails.forEach((thumb) => {
        thumb.addEventListener("click", () => {
            mainImage.src = thumb.src;
            thumbnails.forEach((img) => img.classList.remove("active"));
            thumb.classList.add("active");
        });
    });
});
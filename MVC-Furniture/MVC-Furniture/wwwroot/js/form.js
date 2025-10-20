const previewBox = document.getElementById('imagePreview');
const inputFile = document.getElementById('bannerInput');
const previewImg = document.getElementById('previewImg');

previewBox.addEventListener('click', () => {
    inputFile.click();
});

inputFile.addEventListener('change', () => {
    const file = inputFile.files[0];
    if (file) {
        const reader = new FileReader();
        reader.onload = () => {
            previewImg.src = reader.result;
            previewImg.style.display = 'block';
            previewBox.querySelector('span').style.display = 'none';
        };
        reader.readAsDataURL(file);
    }
});
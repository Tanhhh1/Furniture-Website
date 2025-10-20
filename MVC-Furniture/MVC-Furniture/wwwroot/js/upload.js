const uploadBox = document.querySelector('.upload_box');
const imageInput = document.getElementById('image_upload');
const imagePreview = document.querySelector('.image_preview');

uploadBox.addEventListener('click', () => {
    imageInput.click();
});

imageInput.addEventListener('change', () => {
    const files = imageInput.files;
    if (!files.length) return;

    [...files].forEach(file => {
        const reader = new FileReader();
        reader.onload = function (e) {
            const imageItem = document.createElement('div');
            imageItem.classList.add('image_item');

            imageItem.innerHTML = `
        <div class="thumb" style="background-image: url('${e.target.result}')"></div>
        <div class="image_info">
          <span>${file.name}</span>
        </div>
        <i class='bx bx-x delete_image'></i>
      `;

            imageItem.querySelector('.delete_image').addEventListener('click', () => {
                imageItem.remove();
            });

            imagePreview.appendChild(imageItem);
        };

        reader.readAsDataURL(file);
    });

    imageInput.value = '';
});

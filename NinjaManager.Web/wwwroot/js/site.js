const modal = document.getElementById('modal');
const modelOpenBtn = document.getElementById('open-modal-btn');
const modelCloseBtn = document.getElementById('close-modal-btn');

modelOpenBtn?.addEventListener('click', () => {
    modal.style.display = 'block';
});

modelCloseBtn?.addEventListener('click', () => {
    modal.style.display = 'none';
});

window.addEventListener('click', (e) => {
    if (e.target === modal) {
        modal.style.display = 'none';
    }
});

function confirmDelete(ninjaCount) {
    return confirm(`Are you sure you want to delete the following item? It is currently owned by ${ninjaCount} ninja(s).`);
}

const inputs = document.querySelectorAll('input');
inputs.forEach(input => {
    input.addEventListener('input', () => {
        input.value = input.value.toUpperCase();
    });
});

const scrollContainer = document.querySelector('.scroll-container');

let isDown = false;
let startX;
let scrollLeft;

scrollContainer.addEventListener('mousedown', (e) => {
    isDown = true;
    startX = e.pageX - scrollContainer.offsetLeft;
    scrollLeft = scrollContainer.scrollLeft;
});

scrollContainer.addEventListener('mouseleave', () => {
    isDown = false;
});

scrollContainer.addEventListener('mouseup', () => {
    isDown = false;
});

scrollContainer.addEventListener('mousemove', (e) => {
    if (!isDown) return;
    e.preventDefault();
    const x = e.pageX - scrollContainer.offsetLeft;
    const walk = (x - startX) ; // Scroll speed
    scrollContainer.scrollLeft = scrollLeft - walk;
});

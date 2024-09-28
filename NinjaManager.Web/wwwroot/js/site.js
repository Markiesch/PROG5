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

const modal = document.getElementById('modal');
const modelOpenBtn = document.getElementById('open-modal-btn');
const modelCloseBtn = document.getElementById('close-modal-btn');

modelOpenBtn?.addEventListener('click', () => {
  modal.classList.add("modal-open")
});

modelCloseBtn?.addEventListener('click', () => {
  modal.classList.remove("modal-open")
});

window.addEventListener('click', (e) => {
  if (e.target === modal) {
    modal.classList.remove("modal-open")
  }
});

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
  const walk = (x - startX); // Scroll speed
  scrollContainer.scrollLeft = scrollLeft - walk;
});

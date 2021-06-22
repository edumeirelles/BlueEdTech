const barras = document.getElementsByClassName('barras')
for(const item of barras){
    const id = item.getAttribute("id")
    const observer = new IntersectionObserver(entries => {entries.forEach(entry => {
        const barra = entry.target.querySelector(`#${String(id)}`);
      
      if (entry.isIntersecting) {
        barra.classList.add(`${String(id)}-animacao`);
        return; 
      }
      barra.classList.remove(`${String(id)}-animacao`); 
    });
  }); 
  observer.observe(document.querySelector(`.barra-${String(id)}`));
}

var menu = document.getElementsByClassName("menu_item");

for (var i = 0; i < menu.length; i++) {
menu[i].addEventListener("click", function() {
  (document.querySelector('.selecionado')) ? document.querySelector('.selecionado').classList.remove('selecionado') : '';
  this.classList.add('selecionado');
});
}
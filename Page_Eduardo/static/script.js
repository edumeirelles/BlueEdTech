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
  menu[i].addEventListener("mousedown", function() {
    this.classList.remove('menu_item');
    this.classList.add('click');
    
  })
  menu[i].addEventListener("mouseup", function(){
    this.classList.add('menu_item');
    this.classList.remove("click");
  })
  menu[i].addEventListener("mouseleave", function(){
    this.classList.add('menu_item');
    this.classList.remove("click");
  })
}

const icones = document.getElementsByClassName("icone");

for (const icone of icones){
    icone.addEventListener("mousedown", function(){
      this.classList.add("click_icone");
      this.classList.remove("icone");
    })
    icone.addEventListener("mouseup", function(){
      this.classList.add("icone");
      this.classList.remove("click_icone");
    })
    icone.addEventListener("mouseleave", function(){
      this.classList.add("icone");
      this.classList.remove("click_icone");
    })
}






const divMainPerfil = document.getElementById("divMainPerfil");
const divMainPortifolio = document.getElementById("divMainPortifolio")
const portifolio = document.getElementById("portifolio");
const perfil = document.getElementById("perfil");

function selecionarItem(){
  if (portifolio.classList.contains('selecionado')){
    divMainPerfil.classList.add('div_main');
    divMainPortifolio.classList.remove('div_main')
  }
  if (perfil.classList.contains('selecionado')){
    divMainPerfil.classList.remove('div_main')
    divMainPortifolio.classList.add('div_main')
  }
}

portifolio.addEventListener("click", selecionarItem)
perfil.addEventListener("click", selecionarItem)
const observer_python = new IntersectionObserver(entries => {
  entries.forEach(entry => {
    const barra = entry.target.querySelector('#python');
    
    if (entry.isIntersecting) {
      barra.classList.add('python-animacao');
      return; 
    }
    barra.classList.remove('python-animacao'); 
  });
}); 
observer_python.observe(document.querySelector('.barra-python'));
//
const observer_html = new IntersectionObserver(entries => {
entries.forEach(entry => {
  const barra = entry.target.querySelector('#html');
  
  if (entry.isIntersecting) {
    barra.classList.add('html-animacao'); 
    return; 
  }
  barra.classList.remove('html-animacao');  
});
});
observer_html.observe(document.querySelector('.barra-html'));
//
const observer_java = new IntersectionObserver(entries => {
entries.forEach(entry => {
  const barra = entry.target.querySelector('#java');
  if (entry.isIntersecting) {
    barra.classList.add('java-animacao');
    return; 
  }
  barra.classList.remove('java-animacao');
});
});
observer_java.observe(document.querySelector('.barra-java'));
//
const observer_excel = new IntersectionObserver(entries => {
entries.forEach(entry => {
  const barra = entry.target.querySelector('#excel');
  if (entry.isIntersecting) {
    barra.classList.add('excel-animacao');
    return; 
  }
  barra.classList.remove('excel-animacao');
});
});
observer_excel.observe(document.querySelector('.barra-excel'));
//
const observer_word = new IntersectionObserver(entries => {
entries.forEach(entry => {
  const barra = entry.target.querySelector('#word');
  if (entry.isIntersecting) {
    barra.classList.add('word-animacao');
    return; 
  }
  barra.classList.remove('word-animacao');
});
});
observer_word.observe(document.querySelector('.barra-word'));
//
const observer_ppoint = new IntersectionObserver(entries => {
entries.forEach(entry => {
  const barra = entry.target.querySelector('#ppoint');
  if (entry.isIntersecting) {
    barra.classList.add('ppoint-animacao');
    return; 
  }
  barra.classList.remove('ppoint-animacao');
});
});
observer_ppoint.observe(document.querySelector('.barra-ppoint'));

var menu = document.getElementsByClassName("menu_item");

for (var i = 0; i < menu.length; i++) {
menu[i].addEventListener("click", function() {
  (document.querySelector('.selecionado')) ? document.querySelector('.selecionado').classList.remove('selecionado') : '';
  this.classList.add('selecionado');
});
}
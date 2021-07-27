from flask import Flask, render_template
import items
app = Flask(__name__)

@app.route('/')
def index():

    menu = items.menu
    perfil = items.perfil
    icones = items.icones
    experiencia = items.experiencia
    formacao = items.formacao
    cursos = items.cursos
    idiomas = items.idiomas
    internacional = items.internacional
    soft_skills = items.soft_skills
    hard_skills = items.hard_skills
    interesses = items.interesses
    projetos = items.projetos
    
    return render_template(
        'index.html', 
        menu=menu, 
        perfil=perfil, 
        icones=icones, 
        experiencia=experiencia, 
        formacao=formacao, 
        cursos=cursos, 
        idiomas = idiomas,
        internacional=internacional,
        soft_skills=soft_skills, 
        hard_skills=hard_skills, 
        interesses=interesses,
        projetos=projetos)

if (__name__ == '__main__'):
    app.run(debug = True)
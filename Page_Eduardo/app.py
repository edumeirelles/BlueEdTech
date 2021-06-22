from flask import Flask, render_template

app = Flask(__name__)

@app.route('/')
def index():
    soft_skills = ['Resiliência', 'Flexibilidade', 'Organização e Planejamento', 'Colaboração']
    hard_skills = [
        {
            'tag': 'python',
            'skill': 'Python',
            'level': 75
        },{
            'tag': 'html',
            'skill': 'HTML/CSS',
            'level': 65
        },{
            'tag': 'java',
            'skill': 'JavaScript',
            'level': 50
        },{
            'tag': 'sql',
            'skill': 'SQL',
            'level': 60
        },{
            'tag': 'excel',
            'skill': 'Excel',
            'level': 85
        },{
            'tag': 'word',
            'skill': 'Word',
            'level': 90
        },{
            'tag': 'ppoint',
            'skill': 'PowerPoint',
            'level': 75
        }
    ]
    interesses = ['Música', 'Instrumentos Musicais', 'Eletrônica', 'Tecnologia', 'Computação', 'Viagens', 'Livros']
    
    return render_template('index.html', soft_skills = soft_skills, hard_skills = hard_skills, interesses = interesses)

if (__name__ == '__main__'):
    app.run(debug = True)
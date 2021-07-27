from flask import Flask, request, render_template
from flask_sqlalchemy import SQLAlchemy

app = Flask(__name__)

user = 'nribskms'
password = '5vzaXTm4whpCpVMys8SDYWwzBJS_n3Fr'
host = 'tuffi.db.elephantsql.com'
database = 'nribskms'

app.config['SQLALCHEMY_DATABASE_URI'] = f'postgresql://{user}:{password}@{host}/{database}'
app.config['SQLALCHEMY_TRACK_MODIFICATIONS'] = False
app.secret_key = "a really secret password"

db = SQLAlchemy(app)

class projeto_calcme(db.Model):
    id = db.Column(db.Integer, primary_key=True)
    nome = db.Column(db.String(255), nullable=False)
    email = db.Column(db.String(255), nullable=False)
    telefone = db.Column(db.Integer, nullable=False)

    def __init__(self, nome, email, telefone):
        self.nome = nome
        self.email = email
        self.telefone = telefone

    @staticmethod
    def read_all():
        return projeto_calcme.query.order_by(projeto_calcme.id.asc()).all()
    
    @staticmethod
    def read_single(registro_id):
        return projeto_calcme.query.get(registro_id)
    
    def save(self): 
        db.session.add(self)
        db.session.commit()
    
    def update(self, novo_nome, novo_email, novo_telefone):
        self.nome = novo_nome
        self.email = novo_email
        self.telefone = novo_telefone
        self.save()
    
    def delete(self):
        
        db.session.delete(self)
        db.session.commit()
    
@app.route('/')
def index():
    return render_template('index.html')

@app.route('/read')
def read_all():
    
    registros = projeto_calcme.read_all()
    return render_template('read_all.html', registros=registros)

@app.route("/read/<registro_id>")
def read_id(registro_id):
    tabela = [{'email':'E-mail','telefone':'Telefone'}]
    registro = projeto_calcme.read_single(registro_id)
    return render_template('read_single.html', registro=registro, tabela=tabela)

@app.route('/create', methods=('GET','POST'))
def create():

    id_atribuido = None
    erro = "Preencha todos os campos"
    labels = [{'nome':'Nome:','email':'E-mail:','telefone':'Telefone:'}]
    
    if request.method == 'POST':
        form = request.form

        if not form['nome'] or not form['email'] or not form['telefone']:
            
            return render_template('erro.html', id_atribuido=id_atribuido, erro=erro, labels=labels)

        registro = projeto_calcme(form['nome'], form['email'], form['telefone'])
        
        registro.save()

        id_atribuido = registro.id
    return render_template('create.html', id_atribuido=id_atribuido, labels=labels)

@app.route('/update/<registro_id>', methods=('GET', 'POST'))
def update(registro_id):

    sucesso = False
    erro = "Preencha todos os campos"
    labels = [{'nome':'Nome:','email':'E-mail:','telefone':'Telefone:'}]
    registro = projeto_calcme.read_single(registro_id)

    if request.method == 'POST':
        form = request.form
        
        if not form['nome'] or not form['email'] or not form['telefone']:

            return render_template('erro.html', registro=registro, erro=erro, labels=labels)

        registro.update(form['nome'], form['email'], form['telefone'])

        sucesso = True
    
    return render_template('update.html', registro=registro, sucesso=sucesso, labels=labels)

@app.route('/delete/<registro_id>')
def delete(registro_id):

    registro = projeto_calcme.read_single(registro_id)
    return render_template("delete.html", registro=registro)

@app.route('/delete/<registro_id>/confirmed')
def delete_confirmed(registro_id):
    
    sucesso = False
    registro = projeto_calcme.read_single(registro_id)

    if registro:

        registro.delete()
        sucesso = True
    
    return render_template("delete.html", registro=registro, sucesso=sucesso)

if (__name__ == '__main__'):
    app.run(debug = True)

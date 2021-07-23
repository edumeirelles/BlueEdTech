from flask import Flask, render_template

app = Flask(__name__)

@app.route('/')
def index():
    menu = [
        {
            'tag':'perfil',
            'text': 'Perfil'
        },{
            'tag':'portifolio',
            'text':'Portifólio'
        },{
            'tag':'certificado',
            'text':'Certificados'
        }
    ]
    perfil = [
        {
            'nome':'Eduardo Meirelles Nogueira',
            'objetivo':'Desenvolvedor Python, HTML5, CSS3, C#, SQL',
            'email':'edumeirelles@yahoo.com.br',
            'telefone':'(16) 99260 - 1155'
        }
    ]
    icones = [
        {
            'icone':'Linkedin',
            'link':'http://www.linkedin.com/in/eduardo-meirelles-nogueira/',
            'src':'static/linkedin-white.png'
        },{
            'icone':'Facebook',
            'link':'http://www.facebook.com/edumeirelles',
            'src':'static/facebook-white.png'
        },{
            'icone':'GitHub',
            'link':'http://www.github.com/edumeirelles',
            'src':'static/github-white.png'
        },{
            'icone':'WhatsApp',
            'link':'https://api.whatsapp.com/send?phone=5516992601155',
            'src':'static/whatsapp-white.png'
        }
    ]
    experiencia = [
        {
            'cargo': 'Bluemer - Estudante de Programação',
            'empresa': 'BlueEdTech',
            'periodo': 'mai/2021 - Atualmente',
            'local' : 'Home Office',
            'descricao': 'Atualmente sou estudante de programação e desenvolvimento na Blue EdTech',
            'items' : ['Lógica de Programação', 'Desenvolvimento de Software', 'Analytics', 'Python, HTML5, CSS3, JavaScript, SQL, C#, .NET']

        },{
            'cargo': 'Day Trader',
            'empresa': 'Autônomo',
            'periodo': 'mai/2020 - fev/2021',
            'local' : 'Home Office',
            'descricao': 'Modalidade de negociação utilizada em mercados financeiros, que tem por objetivo a obtenção de lucro com a oscilação de preço, ao longo do dia, de ativos financeiros',
            'items' : ['Operei no mercado financeiro operando mini contratos futuros de Dólar e Índice Bovespa']
        },{
            'cargo': 'Relacionamento com o Cliente',
            'empresa': 'Break & Go',
            'periodo': 'mar/2018 - fev/2020',
            'local' : 'São Paulo/SP',
            'descricao': 'Serviço de cantina móvel em edifícios corporativos',
            'items' : ['Atendimento ao cliente','Planejamento estratégico de prospecção e expansão', 'Análise de despesas e custos','Otimização de suprimentos']
        },{
            'cargo': 'Analista Administrativo',
            'empresa': 'RIOVIVO - Saneamento e Sustentabilidade',
            'periodo': 'mar/2017 - jan/2018',
            'local' : 'Home Office',
            'descricao': 'Empresa prestadora de serviços de saneamento',
            'items' : ['Elaboração de relatórios gerenciais e indicadores de desempenho','Interface com o departamento municipal de água e esgoto de Uberlândia','Emissão de medição de serviços prestados para faturamento','Estimativa de faturamento de serviços futuros']
        },{
            'cargo': 'Analista Administrativo',
            'empresa': 'HMG Engenharia',
            'periodo': 'abr/2014 - mai/2016',
            'local' : 'Pouso Alegre/MG',
            'descricao': 'Imobiliária e Engenharia',
            'items' : ['Responsável por rotinas administrativas, controle de fluxo de caixa, aquisições, cálculo de tributos, atendimento ao cliente, preparação de contratos imobiliários','Criação e administração do website da empresa, elaboração e gerenciamento de publicidade em mídias sociais e mídia impressa','Responsável por operações no mercado financeiro – Dólar e Índice Bovespa Futuros']
        },{
            'cargo': 'Analista Administrativo - M.I.S.',
            'empresa': 'Sanchez & Sanchez Advogados Associados',
            'periodo': 'jan/2013 - fev/2014',
            'local' : 'Ribeirão Preto/SP',
            'descricao': 'Escritório de Avocacia e Recuperação de Crédito',
            'items' : ['Responsável pela elaboração de relatórios gerenciais e indicadores de desempenho','Atuação no setor de suporte cumprindo tratamento de informações e enriquecimento do banco de dados da empresa','Participação efetiva no projeto de implantação e migração de dados para o sistema integrado de cobrança']
        },{
            'cargo': 'Auxiliar de Logística',
            'empresa': 'Espaço Livre Eventos',
            'periodo': 'ago/2012 - out/2012',
            'local' : 'Ribeirão Preto/SP',
            'descricao': 'Planejamento e montagem de estruturas metálicas para eventos',
            'items' : ['Elaboração de cálculos para carregamento de materiais com o objetivo de maximizar a eficiência do transporte de materiais reduzindo custos da logística']
        },{
            'cargo': 'Técnico em Informática',
            'empresa': 'CODERP',
            'periodo': 'fev/2009 - jul/2012',
            'local' : 'Ribeirão Preto/SP',
            'descricao': 'Autarquia responsável pela infraestrutura de dados do município',
            'items' : ['Manutenção, instalação e configuração de microcomputadores, impressoras e redes', 'Implantação da rede de fibra óptica para transmissão de dados entre as unidades públicas municipais']
        },{
            'cargo': 'Auxiliar Administrativo',
            'empresa': 'Verocheque Refeições',
            'periodo': 'fev/2008 - set/2008',
            'local' : 'Ribeirão Preto/SP',
            'descricao': 'Empresa de benefícios Alimentação e Refeição',
            'items' : ['Cadastro de clientes', 'Suporte na área de T.I.','Auxiliar do setor financeiro']
        }
    ]
    formacao = [
        {
            'curso':'Gerenciamento de Projetos - Práticas do PMI',
            'instituicao':'Centro Universitário SENAC',
            'periodo':'mar/2012 - dez/2013',
            'local':'Ribeirão Preto/SP'
        },{
            'curso':'Administração',
            'instituicao':'Universidade Paulista - UNIP',
            'periodo':'fev/2008 - dez/2011',
            'local':'Ribeirão Preto/SP'
        }
    ]
    cursos = [
        {
            'curso':'Gestão do Risco de Mercado',
            'instituicao':'ANBIMA',
            'duracao':'18h',
            'ano':'2020'
        },{
            'curso':'Planejamento de Investimentos',
            'instituicao':'ANBIMA',
            'duracao':'13h',
            'ano':'2020'
        },{
            'curso':'Viver de Mercado 5.0 (Daytrade Dólar e Índice Bovespa)',
            'instituicao':'Infomoney',
            'duracao':'35h',
            'ano':'2020'
        },{
            'curso':'Aprenda a Investir na Bolsa de Valores 3.0',
            'instituicao':'Infomoney',
            'duracao':'40h',
            'ano':'2020'
        },{
            'curso':'Fundamentals of Audio and Music Engineering - Musical Sound & Electronics',
            'instituicao':'University of Rochester',
            'duracao':'14h',
            'ano':'2013'
        },{
            'curso':'Infraestrutura de Redes LAN & WAN',
            'instituicao':'Center Cursos',
            'duracao':'40h',
            'ano':'2012'
        }
    ]
    soft_skills = ['Resiliência', 'Flexibilidade', 'Organização e Planejamento', 'Colaboração']
    hard_skills = [
        {
            'tag': 'python',
            'skill': 'Python'
        },{
            'tag': 'html',
            'skill': 'HTML/CSS'
        },{
            'tag': 'java',
            'skill': 'JavaScript'
        },{
            'tag': 'csharp',
            'skill': 'C#'
        },{
            'tag': 'sql',
            'skill': 'SQL'
        },{
            'tag': 'excel',
            'skill': 'Excel'
        },{
            'tag': 'word',
            'skill': 'Word'
        },{
            'tag': 'ppoint',
            'skill': 'PowerPoint'
        }
    ]
    interesses = ['Música', 'Instrumentos Musicais', 'Eletrônica', 'Tecnologia', 'Computação', 'Viagens', 'Livros']
    
    return render_template('index.html', menu=menu, perfil=perfil, icones=icones, experiencia=experiencia, formacao=formacao, cursos=cursos, soft_skills=soft_skills, hard_skills=hard_skills, interesses=interesses)

if (__name__ == '__main__'):
    app.run(debug = True)
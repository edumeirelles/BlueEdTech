create table projeto_calcme (
	id serial primary key,
	nome varchar(255) not null,
	email varchar(255) not null,
	telefone bigint not null
	
)

insert into projeto_calcme (nome, email, telefone)
values ('Calcme', 'vempra@calcme.com.br', 47992406868)
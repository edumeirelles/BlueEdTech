use db_teste_asp
go

if exists(select name from sysobjects (nolock) where name='Tabela')
	drop table Tabela

if exists(select name from sysobjects (nolock) where name='Tabela_hist')
	drop table Tabela_hist

if exists(select name from sysobjects (nolock) where name='Tabela_esp')
	drop table Tabela_esp

CREATE TABLE [Tabela] (
	[codigo] [int] NOT NULL ,
	[descricao] [varchar] (50) NULL ,
	[obs] [varchar] (50) NULL ,
	CONSTRAINT [PK_Tabela] PRIMARY KEY  CLUSTERED 
	(
		[codigo]
	)  ON [PRIMARY] 
) ON [PRIMARY]
--GO
CREATE TABLE [Tabela_hist] (
	[data_historico] [datetime] NOT NULL ,
	[codigo] [int] NOT NULL ,
	[descricao] [varchar] (50) NULL,
	[obs] [varchar] (50) NULL
) ON [PRIMARY]
--GO
CREATE TABLE [Tabela_esp] (
	[codigo] [int] NOT NULL
) ON [PRIMARY]


declare @inicial smallint
declare @cont smallint

set @inicial=(select max(codigo) from Tabela (nolock))
set @inicial=isnull(@inicial,0)
set @cont=1
while @cont<=2000
begin
	insert into Tabela (codigo,descricao) values (@inicial+@cont,'descricao '+case when @inicial+@cont>1000 then convert(varchar(10),@inicial+@cont) else '' end)
	if @inicial+@cont>1900
		insert into Tabela_esp (codigo) values (@inicial+@cont)

	set @cont=@cont+1
end


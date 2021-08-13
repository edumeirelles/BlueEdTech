SELECT descricao, COUNT(*) FROM Tabela
GROUP BY descricao
HAVING COUNT(*) >1

SELECT * FROM Tabela
WHERE NOT EXISTS(SELECT * FROM Tabela_esp WHERE Tabela.codigo = Tabela_esp.codigo)

UPDATE Tabela 
SET obs = 'S'
WHERE EXISTS(SELECT * FROM Tabela_esp WHERE Tabela.codigo = Tabela_esp.codigo)


USE db_teste_asp
GO

CREATE PROC dbo.tst_sp_descricoes_duplicadas @descricao VARCHAR(MAX)
AS
SELECT * INTO #Registros_duplicados FROM Tabela WHERE descricao = @descricao
GO


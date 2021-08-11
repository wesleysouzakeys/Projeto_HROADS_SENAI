USE HROADS;
GO

SELECT * FROM TIPOHABILIDADE;
SELECT * FROM CLASSE;
SELECT * FROM HABILIDADE;
SELECT * FROM CLASSEHABILIDADE;
SELECT * FROM PERSONAGEM;

--Selecionar todos os personagens

SELECT nomePersonagem FROM PERSONAGEM;

-----------------//-----------------//-----------------

--Selecionar todas as classes / todos os nomes das classes

SELECT nomeClasse FROM CLASSE;

-----------------//-----------------//-----------------

--Selecionar todas as habilidades 

SELECT nomeHabilidade FROM HABILIDADE;

-----------------//-----------------//-----------------

--Realizar a contagem de quantas habilidades estão cadastradas

SELECT COUNT (nomeHabilidade) 'Quantidade de Habilidades' FROM HABILIDADE;

-----------------//-----------------//-----------------

--Selecionar somente os id’s das habilidades classificando-os por ordem crescente

SELECT idHabilidade FROM HABILIDADE ORDER BY idHabilidade ASC;

-----------------//-----------------//-----------------

--Selecionar todos os tipos de habilidades

SELECT tipoHabilidade FROM TIPOHABILIDADE;

-----------------//-----------------//-----------------

--Selecionar todas as habilidades e a quais tipos de habilidades elas fazem parte

SELECT nomeHabilidade, tipoHabilidade FROM HABILIDADE 
LEFT JOIN TIPOHABILIDADE 
ON HABILIDADE.idTipoHabilidade = TIPOHABILIDADE.idTipoHabilidade;

-----------------//-----------------//-----------------

--Selecionar todos os personagens e suas respectivas classes

SELECT nomePersonagem, nomeClasse FROM PERSONAGEM
LEFT JOIN CLASSE
ON PERSONAGEM.idClasseHabi = CLASSE.idClasse;

-----------------//-----------------//-----------------

--Selecionar todos os personagens e as classes (mesmo que elas não tenham correspondência em personagens)

SELECT nomePersonagem, nomeClasse FROM PERSONAGEM
FULL OUTER JOIN CLASSE
ON PERSONAGEM.idClasseHabi = CLASSE.idClasse;

-----------------//-----------------//-----------------

--Selecionar todas as classes e suas respectivas habilidades

/*
SELECT idClasseHabi FROM CLASSEHABILIDADE
FULL OUTER JOIN HABILIDADE
ON CLASSEHABILIDADE.idHabilidade = HABILIDADE.idHabilidade
FULL OUTER JOIN CLASSE
ON CLASSEHABILIDADE.idClasse = CLASSE.idClasse;
*/

SELECT nomeClasse, nomeHabilidade FROM CLASSE
FULL OUTER JOIN HABILIDADE
ON CLASSE.idClasse = HABILIDADE.idHabilidade;

-----------------//-----------------//-----------------

--Selecionar todas as habilidades e suas classes (somente as que possuem correspondência)

SELECT nomeClasse, nomeHabilidade FROM CLASSE
INNER JOIN HABILIDADE
ON CLASSE.idClasse = HABILIDADE.idHabilidade;

-----------------//-----------------//-----------------

--Selecionar todas as habilidades e suas classes (mesmo que elas não tenham correspondência)

SELECT nomeClasse, nomeHabilidade FROM CLASSE
FULL OUTER JOIN HABILIDADE
ON CLASSE.idClasse = HABILIDADE.idHabilidade;

-----------------//-----------------//-----------------
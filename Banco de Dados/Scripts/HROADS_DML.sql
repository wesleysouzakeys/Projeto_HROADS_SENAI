USE HROADS;
GO

/*
SELECT * FROM TIPOHABILIDADE;
SELECT * FROM CLASSE;
SELECT * FROM HABILIDADE;
SELECT * FROM CLASSEHABILIDADE;
SELECT * FROM PERSONAGEM;
SELECT * FROM USUARIO;
SELECT * FROM TIPOUSUARIO;
*/

--Para consulta dos INSERTs apenas.

INSERT INTO TIPOHABILIDADE (tipoHabilidade, valor)
VALUES ('Ataque', 40), ('Defesa', 30), ('Cura', 20), ('Magia', 35);
GO

INSERT INTO CLASSE (nomeClasse)
VALUES ('Bárbaro'), ('Monge'), ('Arcanista'), ('Cruzado'), ('Caçador de Demônios'), ('Necromante'), ('Feiticeira');
GO

INSERT INTO HABILIDADE (nomeHabilidade, idTipoHabilidade)
VALUES ('Lança Mortal', 1), ('Escudo Supremo', 2), ('Recuperar Vida', 3), ('Cetro King', 4);
GO

INSERT INTO CLASSEHABILIDADE (idClasse, idHabilidade)
VALUES (1, 1), (1, 2), (2, 2), (2, 3), (3, NULL), (4, 2), (5, 1), (6, NULL), (7, 3);
GO

INSERT INTO PERSONAGEM (idClasseHabi, nomePersonagem, qtdMaxVida, qtdMaxMana, dataAtualizacao, dataCriacao)
VALUES (1, 'DeuBug', 100, 80, GETDATE(), '18/01/2019'), (2, 'BitBug', 70, 100, GETDATE(), '17/03/2016'), (3, 'Fer8', 75, 60, GETDATE(), '18/03/2018');
GO

UPDATE CLASSE
SET nomeClasse = 'Necromancer'
WHERE nomeClasse = 'Necromante';
GO

UPDATE PERSONAGEM
SET nomePersonagem = 'Fer7'
WHERE nomePersonagem = 'Fer8';
GO

INSERT INTO USUARIO (idTipoUsuario, email, senha)
VALUES (1, 'adm@adm.com', 'adm123'), (2, 'user@user.com', 'user123');
GO

INSERT INTO TIPOUSUARIO (tipoUsuario)
VALUES ('administrador'), ('comum');
GO
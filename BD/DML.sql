USE ROMAN_G12
GO


INSERT INTO TipoUsuario(NomeTipoUsuario)
VALUES
	('Administrador'),
	('Professor');
GO

Select * From TipoUsuario;
GO

INSERT INTO Usuario(IdTipoUsuario, Email, Senha)
VALUES
	(1, 'Saulo@gmail.com', 'Saulo123'),
	(1, 'Lucas@gmail.com', 'lucas123');
	
GO

Select * From Usuario;
GO

INSERT INTO Professor(IdUsuario, NomeProfessor)
VALUES
	(1 , 'Saulo'),
	(2 , 'Lucas');
GO

Select * From Professor;
GO

INSERT INTO Tema(NomeTema)
VALUES
	('Gest�o'),
	('HQs');
GO

Select * From Tema;
GO


INSERT INTO Projeto(IdTema, IdProfessor, NomeProjeto, Descri��o)
VALUES
	(1 , 1 , 'Controle de Estoque' , 'Organiza��o de estoque' ),
	(2 , 2 , 'Listagem de Personagens' , 'Listar' );
GO

Select * From Projeto;
GO

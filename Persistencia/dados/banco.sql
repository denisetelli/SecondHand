use AnunciosDB

SET IDENTITY_INSERT [dbo].[CategoriaProdutos] ON
INSERT INTO [dbo].[CategoriaProdutos] ([CategoriaID], [NomeCategoria]) VALUES (1, N'Eletronicos')
INSERT INTO [dbo].[CategoriaProdutos] ([CategoriaID], [NomeCategoria]) VALUES (2, N'Veiculos')
INSERT INTO [dbo].[CategoriaProdutos] ([CategoriaID], [NomeCategoria]) VALUES (3, N'Comidas')

SET IDENTITY_INSERT [dbo].[CategoriaProdutos] OFF

SET IDENTITY_INSERT [dbo].[AnuncianteEletronico] ON
INSERT INTO [dbo].[AnuncianteEletronico] ([AnuncianteID], [Nome], [TipoPessoa]) VALUES (1, N'Joelma', N'Fisica')
INSERT INTO [dbo].[AnuncianteEletronico] ([AnuncianteID], [Nome], [TipoPessoa]) VALUES (2, N'Claudio Eletronicos', N'Juridica')
INSERT INTO [dbo].[AnuncianteEletronico] ([AnuncianteID], [Nome], [TipoPessoa]) VALUES (3, N'Neo Tecnologia', N'Juridica')
INSERT INTO [dbo].[AnuncianteEletronico] ([AnuncianteID], [Nome], [TipoPessoa]) VALUES (4, N'Atacado Eletronico BT10', N'Juridica')
INSERT INTO [dbo].[AnuncianteEletronico] ([AnuncianteID], [Nome], [TipoPessoa]) VALUES (5, N'Claudemir', N'Fisica')
INSERT INTO [dbo].[AnuncianteEletronico] ([AnuncianteID], [Nome], [TipoPessoa]) VALUES (6, N'Zap Jupiter', N'Juridica')
INSERT INTO [dbo].[AnuncianteEletronico] ([AnuncianteID], [Nome], [TipoPessoa]) VALUES (7, N'Fenix Aparelhos', N'Juridica')
INSERT INTO [dbo].[AnuncianteEletronico] ([AnuncianteID], [Nome], [TipoPessoa]) VALUES (8, N'Selma & Junior Eletronicos', N'Juridica')

SET IDENTITY_INSERT[dbo].[Anunciante] OFF

SET IDENTITY_INSERT [dbo].[DescricaoEletronicos] ON
INSERT INTO [dbo].[DescricaoEletronicos] ([DescricaoID], [TipoProduto], [Descricao]) VALUES (1, N'Notebook', N'Notebooks de uso comercial até o mais profissional (inclui a linha gamer)')
INSERT INTO [dbo].[DescricaoEletronicos] ([DescricaoID], [TipoProduto], [Descricao]) VALUES (2, N'Celular', N'Celulares novos e semi novos do modelo Samsung.')
INSERT INTO [dbo].[DescricaoEletronicos] ([DescricaoID], [TipoProduto], [Descricao]) VALUES (3, N'Perifericos', N'Melhore sua usabilidade com os melhores periféricos do mercado.')
INSERT INTO [dbo].[DescricaoEletronicos] ([DescricaoID], [TipoProduto], [Descricao]) VALUES (4, N'Computador', N'Os melhores desktops do mercado com o melhor preço (temos servidores).')
INSERT INTO [dbo].[DescricaoEletronicos] ([DescricaoID], [TipoProduto], [Descricao]) VALUES (5, N'Componentes Eletronicos', N'Todas as peças que você procura de eletronicos, nós fornecemos para você.')
INSERT INTO [dbo].[DescricaoEletronicos] ([DescricaoID], [TipoProduto], [Descricao]) VALUES (6, N'Carregadores', N'Os mais diversos carregadores para celulares, notebooks ou tablets você encontra aqui.')
SET IDENTITY_INSERT [dbo].[Descricao] OFF

SET IDENTITY_INSERT [dbo].[AnunciosEletronicos] ON
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (1,	N'Notebook', 3992,	N'Viamao', 1, 7.6 ,1, 3)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (2,	N'Celular', 128, N'Canoas', 1, 3.3 ,2, 4)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (3,	N'Celular', 1141, N'Viamao', 1, 6.5 ,2, 8)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (4,	N'Celular', 7111, N'Canoas', 1, 8.9 ,2, 7)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (5,	N'Perifericos', 3768, N'Porto Alegre', 1, 7.2 ,3, 7)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (6,	N'Perifericos', 15075,	N'Canoas', 1, 9.7 ,3, 6)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (7,	N'Computador',	16263, N'Cachoeirinha', 1, 9.1 ,4 , 1)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (8,	N'Perifericos', 6318, N'Viamao', 1, 8.4 ,3, 4)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (9,	N'Computador',	15213, N'Cachoeirinha',	1, 8.4 ,4, 3)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (10, N'Computador',	2071, N'Sao Leopoldo', 1, 6.5 ,4, 5)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (11, N'Notebook', 1913,	N'Sao Leopoldo', 1, 5.5 ,1, 1)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (12, N'Notebook', 5556,	N'Porto Alegre', 1, 3.4 ,1, 7)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (13, N'Computador',	3570, N'Cachoeirinha', 1, 7.4 ,4, 8)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (14, N'Computador',	6496, N'Sao Leopoldo',	1, 4.5 ,4, 4)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (15, N'Componentes Eletronicos', 5385, N'Canoas', 1, 5.7 ,5, 8)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (16, N'Carregador',	1143, N'Canoas', 1, 9.4 ,6, 6)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (17, N'Computador',	12556, N'Cachoeirinha', 1, 6.0 ,4, 1)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (18, N'Carregador',	10284, N'Gravatai', 1, 7.5 ,6, 3)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (19, N'Componentes Eletronicos', 3490, N'Viamao', 1, 6.4 ,5, 2)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (20, N'Componentes Eletronicos', 16954, N'Canoas', 1, 7.4 ,5, 4)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (21, N'Carregador',	11168, N'Viamao', 1, 5.5 ,6, 5)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (22, N'Perifericos', 11157,	N'Porto Alegre', 1, 3.4 ,3, 6)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (23, N'Computador',	3315, N'Viamao', 1, 6.9 ,4, 7)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (24, N'Celular', 3773, N'Gravatai', 1, 7.7 ,2, 6)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (25, N'Computador',	1296, N'Sao Leopoldo', 1, 8.0 ,4, 4)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (26, N'Carregador',	1492, N'Viamao', 1, 6.8 ,6, 5)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (27, N'Carregador',	19996, N'Porto Alegre', 1, 9.9 ,6, 4)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (28, N'Celular', 18654,	N'Porto Alegre', 1, 6.6 ,2, 7)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (29, N'Carregador',	12251, N'Viamao', 1, 1.6 ,6, 8)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (30, N'Carregador',	17658, N'Cachoeirinha', 1, 5.8 ,6, 6)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (31, N'Carregador',	3688, N'Canoas', 1, 7.6 ,6, 7)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (32, N'Notebook', 3243,	N'Cachoeirinha', 1, 3.4 ,1, 2)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (33, N'Perifericos', 17988,	N'Canoas', 1, 4.9 , 3, 3)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (34, N'Celular', 16440,	N'Canoas', 1, 3.8 ,2, 5)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (35, N'Componentes Eletronicos', 11957,	N'Sao Leopoldo', 1, 5.0 ,5, 4)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (36, N'Perifericos', 18303,	N'Gravatai', 1, 1.5 ,3, 7)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (37, N'Perifericos', 19718,	N'Viamao', 1, 4.9 ,3, 2)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (38, N'Computador',	14420, N'Porto Alegre', 1, 2.8 ,4, 2)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (39, N'Computador',	19852, N'Porto Alegre', 1, 1.8 ,4, 1)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (40, N'Computador',	13856, N'Viamao', 1, 7.6 ,4, 7)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (41, N'Computador',	9146, N'Canoas', 1, 1.5 ,4, 6)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (42, N'Celular', 13682,	N'Porto Alegre', 1, 6.7 ,2, 4)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (43, N'Componentes Eletronicos', 11840,	N'Viamao',	1, 4.9 ,5, 5)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (44, N'Celular', 19441, N'Viamao',	1, 6.7 ,2, 6)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (45, N'Perifericos', 11187,	N'Canoas',	1, 7.2 ,3, 4)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (46, N'Computador',	19786, N'Viamao',	1, 9.4 ,4, 3)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (47, N'Celular', 7889, N'Viamao',	1, 6.7 ,2, 7)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (48, N'Computador',	9637, N'Sao Leopoldo',	1, 8.6 ,4, 5)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (49, N'Componentes Eletronicos', 203, N'Gravatai',	1, 8.5 ,5, 4)
INSERT INTO [dbo].[AnunciosEletronicos] ([idAnuncio], [Produto], [Valor], [Localidade], [CategoriaID], [Avaliacao], [DescricaoID], [AnuncianteID]) VALUES (50, N'Notebook', 7609,	N'Canoas'	,1, 9.4 ,1, 6)
SET IDENTITY_INSERT [dbo].[AnunciosEletronicos] OFF
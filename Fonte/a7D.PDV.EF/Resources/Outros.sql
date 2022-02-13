BEGIN TRANSACTION T1

SET IDENTITY_INSERT [dbo].[tbEstado] ON 
INSERT [dbo].[tbEstado] ([IDEstado], [Nome], [Sigla]) VALUES (1, N'Acre', N'AC')
INSERT [dbo].[tbEstado] ([IDEstado], [Nome], [Sigla]) VALUES (2, N'Alagoas', N'AL')
INSERT [dbo].[tbEstado] ([IDEstado], [Nome], [Sigla]) VALUES (3, N'Amap�', N'AP')
INSERT [dbo].[tbEstado] ([IDEstado], [Nome], [Sigla]) VALUES (4, N'Amazonas', N'AM')
INSERT [dbo].[tbEstado] ([IDEstado], [Nome], [Sigla]) VALUES (5, N'Bahia', N'BA')
INSERT [dbo].[tbEstado] ([IDEstado], [Nome], [Sigla]) VALUES (6, N'Cear�', N'CE')
INSERT [dbo].[tbEstado] ([IDEstado], [Nome], [Sigla]) VALUES (7, N'Distrito Federal', N'DF')
INSERT [dbo].[tbEstado] ([IDEstado], [Nome], [Sigla]) VALUES (8, N'Esp�rito Santo', N'ES')
INSERT [dbo].[tbEstado] ([IDEstado], [Nome], [Sigla]) VALUES (9, N'Goi�s', N'GO')
INSERT [dbo].[tbEstado] ([IDEstado], [Nome], [Sigla]) VALUES (10, N'Maranh�o', N'MA')
INSERT [dbo].[tbEstado] ([IDEstado], [Nome], [Sigla]) VALUES (11, N'Mato Grosso', N'MT')
INSERT [dbo].[tbEstado] ([IDEstado], [Nome], [Sigla]) VALUES (12, N'Mato Grosso do Sul', N'MS')
INSERT [dbo].[tbEstado] ([IDEstado], [Nome], [Sigla]) VALUES (13, N'Minas Gerais', N'MG')
INSERT [dbo].[tbEstado] ([IDEstado], [Nome], [Sigla]) VALUES (14, N'Par�', N'PA')
INSERT [dbo].[tbEstado] ([IDEstado], [Nome], [Sigla]) VALUES (15, N'Para�ba', N'PB')
INSERT [dbo].[tbEstado] ([IDEstado], [Nome], [Sigla]) VALUES (16, N'Paran�', N'PR')
INSERT [dbo].[tbEstado] ([IDEstado], [Nome], [Sigla]) VALUES (17, N'Pernambuco', N'PE')
INSERT [dbo].[tbEstado] ([IDEstado], [Nome], [Sigla]) VALUES (18, N'Piau�', N'PI')
INSERT [dbo].[tbEstado] ([IDEstado], [Nome], [Sigla]) VALUES (19, N'Rio de Janeiro', N'RJ')
INSERT [dbo].[tbEstado] ([IDEstado], [Nome], [Sigla]) VALUES (20, N'Rio Grande do Norte', N'RN')
INSERT [dbo].[tbEstado] ([IDEstado], [Nome], [Sigla]) VALUES (21, N'Rio Grande do Sul', N'RS')
INSERT [dbo].[tbEstado] ([IDEstado], [Nome], [Sigla]) VALUES (22, N'Rond�nia', N'RO')
INSERT [dbo].[tbEstado] ([IDEstado], [Nome], [Sigla]) VALUES (23, N'Roraima', N'RR')
INSERT [dbo].[tbEstado] ([IDEstado], [Nome], [Sigla]) VALUES (24, N'Santa Catarina', N'SC')
INSERT [dbo].[tbEstado] ([IDEstado], [Nome], [Sigla]) VALUES (25, N'S�o Paulo', N'SP')
INSERT [dbo].[tbEstado] ([IDEstado], [Nome], [Sigla]) VALUES (26, N'Sergipe', N'SE')
INSERT [dbo].[tbEstado] ([IDEstado], [Nome], [Sigla]) VALUES (27, N'Tocantins', N'TO')
SET IDENTITY_INSERT [dbo].[tbEstado] OFF

SET IDENTITY_INSERT [dbo].[tbIdioma] ON 
INSERT [dbo].[tbIdioma] ([IDIdioma], [Nome], [Codigo]) VALUES (1, N'Portugu�s', N'pt_BR')
INSERT [dbo].[tbIdioma] ([IDIdioma], [Nome], [Codigo]) VALUES (2, N'English', N'en_US')
INSERT [dbo].[tbIdioma] ([IDIdioma], [Nome], [Codigo]) VALUES (3, N'Espa�ol', N'es_ES')
SET IDENTITY_INSERT [dbo].[tbIdioma] OFF

COMMIT TRANSACTION T1
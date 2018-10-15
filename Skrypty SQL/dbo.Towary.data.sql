SET IDENTITY_INSERT [dbo].[Towary] ON
INSERT INTO [dbo].[Towary] ([Id], [Kod], [Nazwa], [Masa], [JM], [Data_Utworzenia], [Data_Modyfikacji]) VALUES (1, N'200-001', N'Wieprzowina', CAST(100.000 AS Decimal(14, 3)), N'kg', N'2016-03-01 00:00:00', NULL)
INSERT INTO [dbo].[Towary] ([Id], [Kod], [Nazwa], [Masa], [JM], [Data_Utworzenia], [Data_Modyfikacji]) VALUES (2, N'200-002', N'Wolowina', CAST(250.000 AS Decimal(14, 3)), N'kg', N'2016-03-01 00:00:00', NULL)
INSERT INTO [dbo].[Towary] ([Id], [Kod], [Nazwa], [Masa], [JM], [Data_Utworzenia], [Data_Modyfikacji]) VALUES (3, N'200-003', N'Dziczyzna', CAST(370.000 AS Decimal(14, 3)), N'kg', N'2016-03-01 00:00:00', NULL)
SET IDENTITY_INSERT [dbo].[Towary] OFF

﻿CREATE TABLE [dbo].[Videos]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1), 
    [Name] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(200) NULL,
    [FileName] NVARCHAR(200) NOT NULL,
    [BasePath] NVARCHAR(200) NOT NULL
)

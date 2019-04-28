﻿CREATE TABLE [dbo].[Product]
(
	[Id] CHAR(32) NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(64) NOT NULL, 
    [Family] VARCHAR(32) NOT NULL,
    [ListPrice] MONEY NOT NULL DEFAULT 0.00
)

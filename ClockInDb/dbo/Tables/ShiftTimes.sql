﻿CREATE TABLE [dbo].[ShiftTimes]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [EmpoyeeId] INT NOT NULL, 
    [StartTime] DATETIME2 NOT NULL, 
    [EndTime] DATETIME2 NOT NULL
)

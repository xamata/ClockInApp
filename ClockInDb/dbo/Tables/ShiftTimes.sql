﻿CREATE TABLE [dbo].[ShiftTimes]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [EmployeeId] INT NOT NULL, 
    [StartTime] DATETIME2 NOT NULL, 
    [StopTime] DATETIME2 NULL
)

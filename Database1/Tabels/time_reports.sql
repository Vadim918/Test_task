CREATE TABLE [dbo].[time_reports]
(
	[id] INT NOT NULL PRIMARY KEY,
	[employee_id] INT NULL CONSTRAINT [FK_dbo_time_reports_dbo_employees] FOREIGN KEY REFERENCES [dbo].[employees]([id]) ON DELETE SET NULL,
	[hours] FLOAT NOT NULL,
	[date] DATE NOT NULL
);
GO

CREATE INDEX [IX_dbo_Book_PublisherId] ON [dbo].[time_reports]([employee_id]);
GO
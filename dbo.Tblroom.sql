CREATE TABLE [dbo].[Tblroom] (
    [Id]                      INT           IDENTITY (1, 1) NOT NULL,
    [room_num]               INT NULL,
    [reserve_date]                DATE NULL,
    [days_reserve]  INT NULL,
    [isEmpty] NVARCHAR(MAX) NULL,
    [status]              NVARCHAR(MAX)           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


CREATE TABLE [dbo].[TblEmployee] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [firstname]    NVARCHAR (50)  NULL,
    [lastname]     NVARCHAR (50)  NULL,
    [salary]       NVARCHAR (100) NULL,
    [job]          NVARCHAR (100) NULL,
    [NationalCode] NVARCHAR (50)  NULL,
    [Password]     NVARCHAR(MAX)            NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


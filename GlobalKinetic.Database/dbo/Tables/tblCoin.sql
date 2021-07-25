CREATE TABLE [dbo].[tblCoin] (
    [CoinId]                INT IDENTITY (1, 1) NOT NULL,
    [Amount]                DECIMAL(5, 2),
    [Volume]                DECIMAL(5, 2),
    [DateCreated]           DATETIME,
    [DateModified]          DATETIME,
    [IsDeleted]             BIT,
    CONSTRAINT [PK_tblCoin] PRIMARY KEY CLUSTERED ([CoinId] ASC)
);


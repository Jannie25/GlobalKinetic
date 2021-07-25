CREATE PROCEDURE [dbo].[usp_InsertCoin]
(
	@Volume DECIMAL(5, 2),
	@Amount DECIMAL(5, 2)
)
AS
BEGIN
	INSERT INTO [tblCoin]
	(
		[Volume],
		[Amount],
		[DateCreated],
		[IsDeleted]
	)
	VALUES
	(
		@Volume,
		@Amount,
		GETDATE(),
		0
	)
END
GO

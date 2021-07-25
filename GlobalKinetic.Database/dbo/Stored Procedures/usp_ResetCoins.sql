CREATE PROCEDURE [dbo].[usp_ResetCoins]
AS
BEGIN
	DECLARE @DateModified DATETIME = GETDATE()

	UPDATE	[tblCoin]
	SET		[IsDeleted] = 1,
			[DateModified] = @DateModified
	WHERE	[IsDeleted] = 0
END

CREATE PROCEDURE [dbo].[usp_GetCoins]
AS
BEGIN
	SET NOCOUNT ON

	SELECT	[Amount],
			[Volume]
	FROM	[tblCoin]
	WHERE	[IsDeleted] = 0
END

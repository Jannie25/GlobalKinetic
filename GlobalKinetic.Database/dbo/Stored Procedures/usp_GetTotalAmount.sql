CREATE PROCEDURE [dbo].[usp_GetTotalAmount]
AS
BEGIN
	SET NOCOUNT ON

	SELECT	ISNULL(SUM([Amount]), 0) AS [TotalAmount]
	FROM	[tblCoin]
	WHERE	[IsDeleted] = 0
END

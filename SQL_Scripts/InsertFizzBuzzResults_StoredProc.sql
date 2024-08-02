CREATE PROCEDURE dbo.InsertFizzBuzzResults
	@Results dbo.FizzBuzzResultsType READONLY
AS
BEGIN
	INSERT INTO FizzBuzzResult (ResultID, ResultText)
	SELECT ResultID,ResultText
	FROM @Results
END
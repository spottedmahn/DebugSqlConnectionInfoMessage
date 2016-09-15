CREATE PROCEDURE dbo.[TestPrints]
AS
	Print 'hello world 1'
	select 1 as 'Test Column'
	print 'hello world 2'
RETURN 0

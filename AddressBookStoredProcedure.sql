create Procedure spGetPerson
As begin
try
select * from BookAddress
End try
Begin Catch
SELECT
		ERROR_NUMBER() AS ErrorNumber
		,ERROR_SEVERITY() AS ErrorSeverity
		,ERROR_STATE() AS ErrorState
		,ERROR_PROCEDURE() AS ErrorProcedure
		,ERROR_LINE() AS ErrorLine
		,ERROR_MESSAGE() AS ErrorMessage
END CATCH

Exec spGetPerson

Create Procedure spUpdatePerson(@ID bigint,@Address varchar(max),@Phonenumber bigint)
As begin
try
Update BookAddress set Phonenumber=@Phonenumber,Address=@Address where ID=@ID
End try
Begin Catch
SELECT
		ERROR_NUMBER() AS ErrorNumber
		,ERROR_SEVERITY() AS ErrorSeverity
		,ERROR_STATE() AS ErrorState
		,ERROR_PROCEDURE() AS ErrorProcedure
		,ERROR_LINE() AS ErrorLine
		,ERROR_MESSAGE() AS ErrorMessage
END CATCH

Exec spUpdatePerson
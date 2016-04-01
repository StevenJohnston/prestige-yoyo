/*
	Name: Steven Johnston Matthew Warren
	Date: 3/18/2016
	Description: Stored procedure for inserting new log to database. This will create
					All the missing links if not found such as factory, line, machine, product
*/
USE [Prestige YoYo]
GO

/****** Object:  StoredProcedure [dbo].[AddLog]    Script Date: 3/18/2016 12:31:50 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AddLog] 
(      
	@factoryName NCHAR(64),
	@serial NCHAR(64),
	@lineName NCHAR(64),
	@machineName NCHAR(64),
	@reason NCHAR(64),
	@dateTime DATETIME,
	@returnMessage VARCHAR(1024) OUT
)
AS	
BEGIN
	DECLARE @factoryID INT
	DECLARE @lineID INT
	DECLARE @machineID INT
	DECLARE @productID INT
	DECLARE @errorID INT
	DECLARE @statusID INT
	DECLARE @logID INT
	
	SET @returnMessage = ' '

	SET @factoryID = (SELECT id FROM Factory WHERE name=@factoryName)
	
	IF @factoryID IS NULL
	BEGIN
		INSERT INTO Factory VALUES(@factoryName)
		SET @factoryID = (SELECT IDENT_CURRENT('Factory'))
		SET @returnMessage = @returnMessage + 'Creating new Factory (' + @factoryName + ')\\r\\n';
	END
	

	SET @lineID = (SELECT id FROM Line WHERE name=@lineName)
	IF @lineID IS NULL
	BEGIN
		INSERT INTO Line VALUES(@lineName,@factoryID)
		SET @lineID = (SELECT IDENT_CURRENT('Line'))
		SET @returnMessage = @returnMessage + 'Creating new Line (' + @lineName + ')\\r\\n';
	END


	SET @machineID = (SELECT id FROM Machine WHERE name=@machineName)
	
	IF @machineID IS NULL
	BEGIN
		INSERT INTO Machine VALUES(@machineName,@lineID)
		SET @machineID = (SELECT IDENT_CURRENT('Machine'))
		SET @returnMessage = @returnMessage + 'Creating new Machine (' + @machineName + ')\\r\\n';
	END

	--Insert Product
	SET @productID = (SELECT id FROM Product WHERE serial=@serial)
	
	IF @productID IS NULL
	BEGIN
		INSERT INTO Product VALUES(@serial)
		SET @productID = (SELECT IDENT_CURRENT('Product'));
		
		SET @returnMessage = @returnMessage + 'Creating new Product (' + @serial + ')\\r\\n';
	END

	--Get Error ID
	SET @errorID = (SELECT id FROM [dbo].[Error] where reason=@reason)

	--Get Status ID
	SET @statusID = (SELECT id FROM [dbo].[Status] WHERE [state]=@machineName)

	--Add Log
	INSERT INTO [dbo].[Log] VALUES(@machineID,@statusID,@productID,@dateTime,@errorID)
	

	SET @logID = (SELECT IDENT_CURRENT('Log'));
	SET @returnMessage = @returnMessage + CONCAT('Successfully Logged LogID: ' , @logID , '\\r\\n');

	--return @returnMessage;

END
GO



>***INSTALLATION***
```
STEP - 1
Download and run the application.

##STEP - 2
Open your Sql Server.

##STEP - 3
Use the below line of code to enable the OLE automation procedures.

sp_configure 'show advanced options', 1;
GO
RECONFIGURE;
GO
sp_configure 'Ole Automation Procedures', 1;
GO
RECONFIGURE;
GO

##STEP - 4
Put a debugg point on About Mthod in HomeController

##STEP - 5
Exec The code on your database


DECLARE @URL NVARCHAR(MAX) = 'http://localhost:55467/Home/About';
DECLARE @Object AS INT;
DECLARE @ResponseText AS VARCHAR(8000);
DECLARE @Body AS VARCHAR(8000) =
'{
   "employeeId": 1,
   "firstName": "Nancy",
   "lastName": "Davolio",
   "title": "Sales Representative",
   "birthDate": "2020-08-18T00:00:00.000",
   "hireDate": "2020-08-18T00:00:00.000",
   "address": "507 - 20th Ave. E. Apt. 2A",
   "city": "Seattle",
   "region": "WA",
   "postalCode": "98122",
   "country": "USA",
   "homePhone": "(206) 555-9857"
}'
EXEC sp_OACreate 'MSXML2.XMLHTTP', @Object OUT;
EXEC sp_OAMethod @Object, 'open', NULL, 'post',
                 @URL,
                 'false'
EXEC sp_OAMethod @Object, 'setRequestHeader', null, 'Content-Type', 'application/json'
EXEC sp_OAMethod @Object, 'send', null, @body
EXEC sp_OAMethod @Object, 'responseText', @ResponseText OUTPUT
IF CHARINDEX('false',(SELECT @ResponseText)) > 0
BEGIN
 SELECT @ResponseText As 'Message'
END
ELSE
BEGIN
 SELECT @ResponseText As 'Employee Details'
END
EXEC sp_OADestroy @Object


```

Data will be post.
Thanks
https://www.zealousweb.com/calling-rest-api-from-sql-server-stored-procedure/

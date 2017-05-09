
CREATE PROCEDURE Login @User varchar(50), @Pass varchar(50), @Rights varchar(16) output AS

SELECT @Rights=UserLogin FROM clients WHERE UserLogin=@User AND Password=@Pass
UPDATE clients SET LastLogin=GETDATE() WHERE UserLogin=@User
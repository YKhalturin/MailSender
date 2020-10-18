CREATE TABLE[dbo].[Users] (
    [Id] INT IDENTITY(1, 1) NOT NULL,
    [Name] NVARCHAR(10)  
    );

    DELETE FROM [dbo].[Users];

    INSERT INTO [dbo].[Users] (Name) VALUES ('Albert');
    INSERT INTO [dbo].[Users] (Name) VALUES ('Albert');
    INSERT INTO [dbo].[Users] (Name) VALUES ('Albert');
    INSERT INTO [dbo].[Users] (Name) VALUES ('Andrey');
    INSERT INTO [dbo].[Users] (Name) VALUES ('Andrey');
    INSERT INTO [dbo].[Users] (Name) VALUES ('Nikolay');
    INSERT INTO [dbo].[Users] (Name) VALUES ('Alex');
    INSERT INTO [dbo].[Users] (Name) VALUES ('Artem');

 SELECT Name, COUNT(Name) as cnt
    FROM [dbo].[Users]
    WHERE Name Like 'A%'
    GROUP BY Name
    HAVING COUNT(Name) > 1


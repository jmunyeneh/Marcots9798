IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200516052925_contactStatusRemove')
BEGIN
    CREATE TABLE [Adddress] (
        [AddrID] int NOT NULL IDENTITY,
        [Address1] nvarchar(50) NULL,
        [Address2] nvarchar(50) NULL,
        [City] nvarchar(50) NULL,
        [State] nvarchar(50) NULL,
        [Country] nvarchar(50) NULL,
        [PostalCode] nvarchar(50) NULL,
        CONSTRAINT [PK_Adddress] PRIMARY KEY ([AddrID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200516052925_contactStatusRemove')
BEGIN
    CREATE TABLE [ContactStatus] (
        [ContactStatusId] int NOT NULL IDENTITY,
        [ContactStatusDesc] nvarchar(50) NULL,
        CONSTRAINT [PK_ContactStatus] PRIMARY KEY ([ContactStatusId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200516052925_contactStatusRemove')
BEGIN
    CREATE TABLE [Days] (
        [DayID] int NOT NULL IDENTITY,
        [DayNum] int NULL,
        CONSTRAINT [PK_Days] PRIMARY KEY ([DayID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200516052925_contactStatusRemove')
BEGIN
    CREATE TABLE [MarStatus] (
        [ID] int NOT NULL IDENTITY,
        [Description] varchar(20) NULL,
        CONSTRAINT [PK_MarStatus] PRIMARY KEY ([ID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200516052925_contactStatusRemove')
BEGIN
    CREATE TABLE [Months] (
        [MonthID] int NOT NULL IDENTITY,
        [MonthName] nvarchar(50) NULL,
        CONSTRAINT [PK_Months] PRIMARY KEY ([MonthID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200516052925_contactStatusRemove')
BEGIN
    CREATE TABLE [Photo] (
        [ID] int NOT NULL IDENTITY,
        [Name] nvarchar(50) NULL,
        [Description] nvarchar(50) NULL,
        [Image] varbinary(max) NULL,
        [MyPicture] bit NULL,
        CONSTRAINT [PK_Photo] PRIMARY KEY ([ID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200516052925_contactStatusRemove')
BEGIN
    CREATE TABLE [Person] (
        [PersonID] int NOT NULL IDENTITY,
        [OwnerID] nvarchar(100) NULL,
        [FirstName] nvarchar(50) NULL,
        [MidName] nvarchar(3) NULL,
        [LastName] nvarchar(50) NULL,
        [NickName] nvarchar(50) NULL,
        [Description] nvarchar(100) NULL,
        [Telephone] nvarchar(14) NULL,
        [Kids] int NULL,
        [Email] nvarchar(40) NULL,
        [Occupation] nvarchar(100) NULL,
        [StatusID] int NULL,
        [BirthDay] int NULL,
        [BirthMonth] int NULL,
        [InsertedDate] datetime NULL,
        [ModifiedDate] datetime NULL,
        [ContactStatusID] int NULL,
        CONSTRAINT [PK_Person] PRIMARY KEY ([PersonID]),
        CONSTRAINT [FK_Person_Days] FOREIGN KEY ([BirthDay]) REFERENCES [Days] ([DayID]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Person_Months] FOREIGN KEY ([BirthMonth]) REFERENCES [Months] ([MonthID]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Person_ContactStatus] FOREIGN KEY ([ContactStatusID]) REFERENCES [ContactStatus] ([ContactStatusId]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Person_MarStatus] FOREIGN KEY ([StatusID]) REFERENCES [MarStatus] ([ID]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200516052925_contactStatusRemove')
BEGIN
    CREATE TABLE [FamAddress] (
        [ID] int NOT NULL IDENTITY,
        [AddrID] int NOT NULL,
        [PersonID] int NOT NULL,
        CONSTRAINT [PK_FamAddress] PRIMARY KEY ([ID]),
        CONSTRAINT [FK_FamAddress_Adddress] FOREIGN KEY ([AddrID]) REFERENCES [Adddress] ([AddrID]) ON DELETE NO ACTION,
        CONSTRAINT [FK_FamAddress_Person] FOREIGN KEY ([PersonID]) REFERENCES [Person] ([PersonID]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200516052925_contactStatusRemove')
BEGIN
    CREATE TABLE [FamilyPhoto] (
        [ID] int NOT NULL IDENTITY,
        [PersonID] int NULL,
        [PhotoID] int NULL,
        CONSTRAINT [PK_FamilyPhoto] PRIMARY KEY ([ID]),
        CONSTRAINT [FK_FamilyPhoto_Person] FOREIGN KEY ([PersonID]) REFERENCES [Person] ([PersonID]) ON DELETE NO ACTION,
        CONSTRAINT [FK_FamilyPhoto_Photo] FOREIGN KEY ([PhotoID]) REFERENCES [Photo] ([ID]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200516052925_contactStatusRemove')
BEGIN
    CREATE INDEX [IX_FamAddress_AddrID] ON [FamAddress] ([AddrID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200516052925_contactStatusRemove')
BEGIN
    CREATE INDEX [IX_FamAddress_PersonID] ON [FamAddress] ([PersonID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200516052925_contactStatusRemove')
BEGIN
    CREATE INDEX [IX_FamilyPhoto_PersonID] ON [FamilyPhoto] ([PersonID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200516052925_contactStatusRemove')
BEGIN
    CREATE INDEX [IX_FamilyPhoto_PhotoID] ON [FamilyPhoto] ([PhotoID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200516052925_contactStatusRemove')
BEGIN
    CREATE INDEX [IX_Person_BirthDay] ON [Person] ([BirthDay]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200516052925_contactStatusRemove')
BEGIN
    CREATE INDEX [IX_Person_BirthMonth] ON [Person] ([BirthMonth]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200516052925_contactStatusRemove')
BEGIN
    CREATE INDEX [IX_Person_ContactStatusID] ON [Person] ([ContactStatusID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200516052925_contactStatusRemove')
BEGIN
    CREATE INDEX [IX_Person_StatusID] ON [Person] ([StatusID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200516052925_contactStatusRemove')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200516052925_contactStatusRemove', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200516222611_0200516052925_contactStatusRemove')
BEGIN
    ALTER TABLE [Person] DROP CONSTRAINT [FK_Person_ContactStatus];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200516222611_0200516052925_contactStatusRemove')
BEGIN
    DROP TABLE [ContactStatus];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200516222611_0200516052925_contactStatusRemove')
BEGIN
    DROP INDEX [IX_Person_ContactStatusID] ON [Person];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200516222611_0200516052925_contactStatusRemove')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Person]') AND [c].[name] = N'ContactStatusID');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Person] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [Person] DROP COLUMN [ContactStatusID];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200516222611_0200516052925_contactStatusRemove')
BEGIN
    ALTER TABLE [Person] ADD [ContactStatus] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200516222611_0200516052925_contactStatusRemove')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200516222611_0200516052925_contactStatusRemove', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200516224018_Migration_1')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200516224018_Migration_1', N'3.1.4');
END;

GO


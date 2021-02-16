IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214032454_InitialCreate')
BEGIN
    CREATE TABLE [Empleado] (
        [Id] int NOT NULL IDENTITY,
        [Nombre] nvarchar(max) NULL,
        [Apellido] nvarchar(max) NULL,
        [TipoDeDocumento] nvarchar(max) NULL,
        [NumeroDeDocumento] nvarchar(max) NULL,
        CONSTRAINT [PK_Empleado] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214032454_InitialCreate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210214032454_InitialCreate', N'2.1.14-servicing-32113');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214033127_Initial')
BEGIN
    ALTER TABLE [Empleado] ADD [Area] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214033127_Initial')
BEGIN
    ALTER TABLE [Empleado] ADD [SubArea] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210214033127_Initial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210214033127_Initial', N'2.1.14-servicing-32113');
END;

GO


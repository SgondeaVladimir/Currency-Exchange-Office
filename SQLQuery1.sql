
CREATE TABLE [dbo].[Valute] (
    [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [Cod] NVARCHAR(10) NOT NULL,
    [Denumire] NVARCHAR(50) NOT NULL
);


CREATE TABLE [dbo].[Clienti] (
    [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [NumeComplet] NVARCHAR(100) NOT NULL,
    [CNP] NVARCHAR(13) NOT NULL,
    [Telefon] NVARCHAR(15) NULL
);


CREATE TABLE [dbo].[Casieri] (
    [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [Nume] NVARCHAR(100) NOT NULL,
    [CodAngajat] NVARCHAR(20) NOT NULL
);


CREATE TABLE [dbo].[CursuriValutare] (
    [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [ValutaId] INT NOT NULL,
    [DataCotatiei] DATETIME NOT NULL,
    [CursCumparare] DECIMAL(18,4) NOT NULL,
    [CursVanzare] DECIMAL(18,4) NOT NULL,
    FOREIGN KEY ([ValutaId]) REFERENCES [dbo].[Valute] ([Id])
);


CREATE TABLE [dbo].[Tranzactii] (
    [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [ClientId] INT NOT NULL,
    [ValutaId] INT NOT NULL,
    [CasierId] INT NOT NULL,
    [DataTranzactie] DATETIME NOT NULL,
    [SumaValuta] DECIMAL(18,2) NOT NULL,
    [Tip] INT NOT NULL, 
    [SumaTotalaLei] DECIMAL(18,2) NOT NULL,
    FOREIGN KEY ([ClientId]) REFERENCES [dbo].[Clienti] ([Id]),
    FOREIGN KEY ([ValutaId]) REFERENCES [dbo].[Valute] ([Id]),
    FOREIGN KEY ([CasierId]) REFERENCES [dbo].[Casieri] ([Id])
);
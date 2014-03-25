CREATE TABLE [dbo].[Test] (
    [Id] INT identity	NOT NULL,
    [dummy] NCHAR(10) NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[TestItem] (
    [Id]                   INT         NOT NULL,
    [Infinitive]           NCHAR (254) NOT NULL,
    [SimplePast]           NCHAR (254) NOT NULL,
    [PastParticiple]       NCHAR (254) NOT NULL,
    [AnswerSimplePast]     NCHAR (254) NULL,
    [AnswerPastParticiple] NCHAR (254) NULL,
    [TestId]               INT         NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TestItem_ToTest] FOREIGN KEY ([TestId]) REFERENCES [dbo].[Test] ([Id])
);

CREATE TABLE [dbo].[TestOnderdeel] (
    [ID]       INT         NOT NULL,
    [tekst]    NCHAR (254) NOT NULL,
    [antwoord] NCHAR (254) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);


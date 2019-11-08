create database tracker;
use tracker;

CREATE TABLE [dbo].[category] (
    [category_name]        VARCHAR (30)  NOT NULL,
    [category_type]        VARCHAR (30)  NOT NULL,
    [category_description] VARCHAR (255) NULL,
    CONSTRAINT [pk_category] PRIMARY KEY CLUSTERED ([category_name] ASC, [category_type] ASC)
);

CREATE TABLE [dbo].[transact] (
    [transaction_id] INT           IDENTITY (1, 1) NOT NULL,
    [amount]         INT           NOT NULL,
    [date]           DATE          NOT NULL,
    [description]    VARCHAR (255) NULL,
    [category_name]  VARCHAR (30)  NOT NULL,
    [category_type]  VARCHAR (30)  NOT NULL,
    [username]       VARCHAR (20)  NOT NULL,
    CONSTRAINT [pk_transact] PRIMARY KEY CLUSTERED ([transaction_id] ASC),
    CONSTRAINT [fk_transact_user] FOREIGN KEY ([username]) REFERENCES [dbo].[users] ([username]) ON DELETE CASCADE,
    CONSTRAINT [fk_transact_category] FOREIGN KEY ([category_name], [category_type]) REFERENCES [dbo].[category] ([category_name], [category_type]) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE [dbo].[users] (
    [username]  VARCHAR (20) NOT NULL,
    [firstname] VARCHAR (30) NOT NULL,
    [lastname]  VARCHAR (30) NOT NULL,
    [pwd]       VARCHAR (20) NOT NULL,
    CONSTRAINT [pk_user] PRIMARY KEY CLUSTERED ([username] ASC)
);


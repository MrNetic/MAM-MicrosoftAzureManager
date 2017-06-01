CREATE TABLE [config].[tbl_subscriptions]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Description] VARCHAR(500) NOT NULL, 
	[SubscriptionID] UNIQUEIDENTIFIER NOT NULL,
	[TenantID] UNIQUEIDENTIFIER NOT NULL,
    [ApplicationID] UNIQUEIDENTIFIER NOT NULL, 
    [ApplicationKey] VARCHAR(500) NOT NULL
    
)

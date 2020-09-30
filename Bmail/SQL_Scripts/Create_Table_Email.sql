IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('Email') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
BEGIN
	CREATE TABLE Email(
		EmailId int identity(1,1) primary key,
		Sender nvarchar(100) not null,
        Receiver nvarchar(100) not null,
        Content nvarchar(max) null,
        Subject nvarchar(200) not null,
        [Format] nvarchar(20) null,
        Attachments binary null,
		CampaignId int references Campaign(CampaignId)

	)
END
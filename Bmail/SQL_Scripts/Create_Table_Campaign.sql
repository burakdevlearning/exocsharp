IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = object_id('Campaign') AND  OBJECTPROPERTY(id, 'IsUserTable') = 1)
BEGIN
	CREATE TABLE Campaign(
		CampaignId int identity(1,1) primary key,
		Name nvarchar(255) not null
	)
END
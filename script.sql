USE [BookStoreDB]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 5/28/2017 5:09:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Customer_ID] [char](8) NOT NULL,
	[Customer_Name] [varchar](60) NOT NULL,
	[Age] [int] NOT NULL,
	[Customer_Address] [varchar](150) NOT NULL,
	[Customer_Type] [varchar](50) NOT NULL,
	[Phone_Number] [varchar](15) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Gender] [char](6) NOT NULL,
	[Username] [varchar](20) NOT NULL,
	[Password] [varchar](25) NOT NULL,
	[Balance] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Customer_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerRequest]    Script Date: 5/28/2017 5:09:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerRequest](
	[Request_ID] [char](7) NOT NULL,
	[Customer_ID] [char](8) NOT NULL,
	[Product_ID] [char](8) NOT NULL,
	[Staff_ID] [char](6) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Req_Status] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Request_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 5/28/2017 5:09:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Product_ID] [char](8) NOT NULL,
	[Product_Title] [varchar](50) NOT NULL,
	[Publisher_ID] [char](7) NOT NULL,
	[Category] [varchar](20) NOT NULL,
	[Stock_Qty] [int] NULL,
	[Price] [int] NULL,
	[Date_Publish] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[Product_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Product_Title] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Publisher]    Script Date: 5/28/2017 5:09:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publisher](
	[Publisher_ID] [char](7) NOT NULL,
	[Publisher_Name] [varchar](50) NOT NULL,
	[Publisher_Address] [varchar](100) NOT NULL,
	[Phone_Number] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Publisher_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Publisher_Name] ASC,
	[Publisher_Address] ASC,
	[Phone_Number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 5/28/2017 5:09:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[Staff_ID] [char](6) NOT NULL,
	[Staff_Name] [varchar](50) NOT NULL,
	[Staff_Address] [varchar](100) NOT NULL,
	[Gender] [char](6) NOT NULL,
	[Age] [int] NOT NULL,
	[Username] [varchar](20) NOT NULL,
	[Password] [varchar](25) NOT NULL,
	[Email] [varchar](60) NOT NULL,
	[Position] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Staff_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TransactionDetails]    Script Date: 5/28/2017 5:09:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TransactionDetails](
	[Transaction_ID] [char](8) NOT NULL,
	[Product_ID] [char](8) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Transaction_ID] ASC,
	[Product_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TransactionHeader]    Script Date: 5/28/2017 5:09:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TransactionHeader](
	[Transaction_ID] [char](8) NOT NULL,
	[Transaction_Date] [date] NOT NULL,
	[Request_ID] [char](7) NOT NULL,
	[Payment_Type] [varchar](15) NOT NULL,
	[CardNumber] [varchar](16) NULL,
PRIMARY KEY CLUSTERED 
(
	[Transaction_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CustomerRequest]  WITH CHECK ADD FOREIGN KEY([Customer_ID])
REFERENCES [dbo].[Customer] ([Customer_ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CustomerRequest]  WITH CHECK ADD FOREIGN KEY([Product_ID])
REFERENCES [dbo].[Product] ([Product_ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CustomerRequest]  WITH CHECK ADD FOREIGN KEY([Staff_ID])
REFERENCES [dbo].[Staff] ([Staff_ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([Publisher_ID])
REFERENCES [dbo].[Publisher] ([Publisher_ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[TransactionDetails]  WITH CHECK ADD FOREIGN KEY([Product_ID])
REFERENCES [dbo].[Product] ([Product_ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[TransactionDetails]  WITH CHECK ADD FOREIGN KEY([Transaction_ID])
REFERENCES [dbo].[TransactionHeader] ([Transaction_ID])
GO
ALTER TABLE [dbo].[TransactionHeader]  WITH CHECK ADD FOREIGN KEY([Request_ID])
REFERENCES [dbo].[CustomerRequest] ([Request_ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Customer]  WITH CHECK ADD CHECK  (([Age]>=(13) AND [Age]<=(120)))
GO
ALTER TABLE [dbo].[Customer]  WITH CHECK ADD CHECK  (([Balance]>=(0) AND [Balance]<=(1000000000)))
GO
ALTER TABLE [dbo].[Customer]  WITH CHECK ADD CHECK  (([Gender]='Female' OR [Gender]='Male'))
GO
ALTER TABLE [dbo].[CustomerRequest]  WITH CHECK ADD CHECK  (([Customer_ID] like 'CST[0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[CustomerRequest]  WITH CHECK ADD CHECK  (([Product_ID] like 'PRD[0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[CustomerRequest]  WITH CHECK ADD CHECK  (([Quantity]>=(1) AND [Quantity]<=(10000)))
GO
ALTER TABLE [dbo].[CustomerRequest]  WITH CHECK ADD CHECK  (([Req_Status]>=(0) AND [Req_Status]<=(1)))
GO
ALTER TABLE [dbo].[CustomerRequest]  WITH CHECK ADD CHECK  (([Request_ID] like 'RQ[0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[CustomerRequest]  WITH CHECK ADD CHECK  (([Staff_ID] like 'STF[0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD CHECK  (([Product_ID] like 'PRD[0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[Publisher]  WITH CHECK ADD CHECK  (([Publisher_ID] like 'PBL[0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[Staff]  WITH CHECK ADD CHECK  (([Age]>=(17) AND [Age]<=(60)))
GO
ALTER TABLE [dbo].[Staff]  WITH CHECK ADD CHECK  (([Gender]='Female' OR [Gender]='Male'))
GO
ALTER TABLE [dbo].[Staff]  WITH CHECK ADD CHECK  (([Staff_ID] like 'STF[0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[TransactionDetails]  WITH CHECK ADD CHECK  (([Product_ID] like 'PRD[0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[TransactionDetails]  WITH CHECK ADD CHECK  (([Quantity]>=(1) AND [Quantity]<=(10000)))
GO
ALTER TABLE [dbo].[TransactionDetails]  WITH CHECK ADD CHECK  (([Transaction_ID] like 'TR[0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[TransactionHeader]  WITH CHECK ADD CHECK  (([CardNumber] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[TransactionHeader]  WITH CHECK ADD CHECK  (([Payment_Type]='Debit Card' OR [Payment_Type]='Credit Card' OR [Payment_Type]='Cash'))
GO
ALTER TABLE [dbo].[TransactionHeader]  WITH CHECK ADD CHECK  (([Request_ID] like 'RQ[0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[TransactionHeader]  WITH CHECK ADD CHECK  (([Transaction_ID] like 'TR[0-9][0-9][0-9][0-9][0-9][0-9]'))
GO

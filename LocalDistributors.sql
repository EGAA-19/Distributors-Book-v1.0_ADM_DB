USE [LocalDistributors]
GO
/****** Object:  Table [dbo].[Distributors]    Script Date: 12/07/2023 03:44:27 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Distributors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Company] [nvarchar](100) NULL,
	[Phone] [nvarchar](100) NULL,
	[Representative] [nvarchar](100) NULL,
	[Email] [nvarchar](100) NULL,
	[City] [nvarchar](100) NULL,
	[Adress] [nvarchar](100) NULL,
	[Transport] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[DeleteDistributor]    Script Date: 12/07/2023 03:44:27 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteDistributor]
@Id int

AS
BEGIN

DELETE FROM Distributors
WHERE Id = @Id;

END
GO
/****** Object:  StoredProcedure [dbo].[ListDistributors]    Script Date: 12/07/2023 03:44:27 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListDistributors]
     @Company varchar(100) = null
AS
BEGIN

SELECT
Id,
Company,
Phone,
Representative,
Email,
City,
Adress,
Transport

FROM Distributors
WHERE @Company is null OR Upper(Company) LIKE '%' +  Upper(@Company);

END

GO
/****** Object:  StoredProcedure [dbo].[ModifyDistributor]    Script Date: 12/07/2023 03:44:27 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModifyDistributor]
@Id INT,
@Company NVARCHAR (100),
@Phone NVARCHAR (100),
@Representative NVARCHAR (100),
@Email NVARCHAR (100),
@City NVARCHAR (100),
@Adress NVARCHAR (100),
@Transport BIT

AS
BEGIN

UPDATE Distributors
SET Company = @Company,
Phone = @Phone,
Representative = @Representative,
Email = @Email,
City = @City,
Adress = @Adress,
Transport = @Transport

WHERE Id = @Id

END
GO
/****** Object:  StoredProcedure [dbo].[ObtainDistributor]    Script Date: 12/07/2023 03:44:27 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ObtainDistributor]
@Id int

AS
BEGIN

SELECT
Id,
Company,
Phone,
Representative,
Email,
City,
Adress,
Transport

FROM Distributors
WHERE Id = @Id;

END


GO
/****** Object:  StoredProcedure [dbo].[UploadDistributor]    Script Date: 12/07/2023 03:44:27 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UploadDistributor]

@Company NVARCHAR(100),
@Phone NVARCHAR(100),
@Representative NVARCHAR(100),
@Email NVARCHAR(100),
@City NVARCHAR(100),
@Adress NVARCHAR(100),
@Transport BIT

AS
BEGIN

INSERT INTO Distributors
(
Company,
Phone,
Representative,
Email,
City,
Adress,
Transport
)

VALUES
(
@Company,
@Phone,
@Representative,
@Email,
@City,
@Adress,
@Transport 
)


END
GO

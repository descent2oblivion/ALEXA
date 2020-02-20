CREATE TABLE [dbo].[arearps](
	[idarearp] [int] IDENTITY(1,1) NOT NULL,
	[arearp] [varchar](20) NOT NULL,
 CONSTRAINT [PK_arearps] PRIMARY KEY CLUSTERED 
(
	[idarearp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cancelaciones]    Script Date: 20/02/2020 03:01:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cancelaciones](
	[idcan] [int] IDENTITY(1,1) NOT NULL,
	[iddoc] [int] NOT NULL,
	[comentarios] [varchar](200) NULL,
	[fecha] [datetime] NOT NULL,
	[autorizo] [varchar](100) NULL,
 CONSTRAINT [PK_cancelaciones] PRIMARY KEY CLUSTERED 
(
	[idcan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[carpetas]    Script Date: 20/02/2020 03:01:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[carpetas](
	[idcarpeta] [int] IDENTITY(1,1) NOT NULL,
	[carpeta] [varchar](20) NOT NULL,
 CONSTRAINT [PK_carpetas] PRIMARY KEY CLUSTERED 
(
	[idcarpeta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[documentos]    Script Date: 20/02/2020 03:01:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[documentos](
	[iddoc] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [varchar](50) NOT NULL,
	[doc] [varchar](100) NOT NULL,
	[idpersonal] [int] NOT NULL,
	[comentarios] [varchar](200) NOT NULL,
	[autorizo] [varchar](100) NOT NULL,
	[idrama] [int] NOT NULL,
	[idcarpeta] [int] NOT NULL,
	[activo] [int] NOT NULL,
 CONSTRAINT [PK_documentos] PRIMARY KEY CLUSTERED 
(
	[iddoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[historial]    Script Date: 20/02/2020 03:01:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[historial](
	[idhist] [int] IDENTITY(1,1) NOT NULL,
	[iddoc] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[comentarios] [varchar](200) NOT NULL,
	[autorizo] [varchar](100) NULL,
 CONSTRAINT [PK_historial] PRIMARY KEY CLUSTERED 
(
	[idhist] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[mos]    Script Date: 20/02/2020 03:01:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mos](
	[idmo] [int] IDENTITY(1,1) NOT NULL,
	[mo] [varchar](15) NOT NULL,
 CONSTRAINT [PK_mos] PRIMARY KEY CLUSTERED 
(
	[idmo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[personales]    Script Date: 20/02/2020 03:01:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[personales](
	[idpersonal] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[idpuesto] [int] NULL,
	[idmo] [int] NULL,
	[idarearp] [int] NULL,
 CONSTRAINT [PK_personales] PRIMARY KEY CLUSTERED 
(
	[idpersonal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[puestos]    Script Date: 20/02/2020 03:01:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[puestos](
	[idpuesto] [int] IDENTITY(1,1) NOT NULL,
	[puesto] [varchar](30) NOT NULL,
 CONSTRAINT [PK_puestos] PRIMARY KEY CLUSTERED 
(
	[idpuesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ramas]    Script Date: 20/02/2020 03:01:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ramas](
	[idrama] [int] IDENTITY(1,1) NOT NULL,
	[rama] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ramas] PRIMARY KEY CLUSTERED 
(
	[idrama] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[cancelaciones]  WITH CHECK ADD  CONSTRAINT [FK_cancelaciones_documentos] FOREIGN KEY([iddoc])
REFERENCES [dbo].[documentos] ([iddoc])
GO
ALTER TABLE [dbo].[cancelaciones] CHECK CONSTRAINT [FK_cancelaciones_documentos]
GO
ALTER TABLE [dbo].[documentos]  WITH CHECK ADD  CONSTRAINT [FK_documentos_carpetas] FOREIGN KEY([idcarpeta])
REFERENCES [dbo].[carpetas] ([idcarpeta])
GO
ALTER TABLE [dbo].[documentos] CHECK CONSTRAINT [FK_documentos_carpetas]
GO
ALTER TABLE [dbo].[documentos]  WITH CHECK ADD  CONSTRAINT [FK_documentos_personales] FOREIGN KEY([idpersonal])
REFERENCES [dbo].[personales] ([idpersonal])
GO
ALTER TABLE [dbo].[documentos] CHECK CONSTRAINT [FK_documentos_personales]
GO
ALTER TABLE [dbo].[documentos]  WITH CHECK ADD  CONSTRAINT [FK_documentos_ramas] FOREIGN KEY([idrama])
REFERENCES [dbo].[ramas] ([idrama])
GO
ALTER TABLE [dbo].[documentos] CHECK CONSTRAINT [FK_documentos_ramas]
GO
ALTER TABLE [dbo].[historial]  WITH CHECK ADD  CONSTRAINT [FK_historial_documentos] FOREIGN KEY([iddoc])
REFERENCES [dbo].[documentos] ([iddoc])
GO
ALTER TABLE [dbo].[historial] CHECK CONSTRAINT [FK_historial_documentos]
GO
ALTER TABLE [dbo].[personales]  WITH CHECK ADD  CONSTRAINT [FK_personales_arearps] FOREIGN KEY([idarearp])
REFERENCES [dbo].[arearps] ([idarearp])
GO
ALTER TABLE [dbo].[personales] CHECK CONSTRAINT [FK_personales_arearps]
GO
ALTER TABLE [dbo].[personales]  WITH CHECK ADD  CONSTRAINT [FK_personales_mos] FOREIGN KEY([idmo])
REFERENCES [dbo].[mos] ([idmo])
GO
ALTER TABLE [dbo].[personales] CHECK CONSTRAINT [FK_personales_mos]
GO
ALTER TABLE [dbo].[personales]  WITH CHECK ADD  CONSTRAINT [FK_personales_puestos] FOREIGN KEY([idpuesto])
REFERENCES [dbo].[puestos] ([idpuesto])
GO
ALTER TABLE [dbo].[personales] CHECK CONSTRAINT [FK_personales_puestos]
GO
/****** Object:  StoredProcedure [dbo].[actDoc]    Script Date: 20/02/2020 03:01:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		emmanuel chavez
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[actDoc] 
	-- Add the parameters for the stored procedure here
	@p0 int,
	@p1 varchar(50),
	@p2 varchar(100),
	@p3 varchar(100),
	@p4 varchar(200),
	@p5 varchar(100),
	@p6 varchar(50),
	@p7 varchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @per int = (select personales.idpersonal from personales where personales.nombre = @p3)
	declare @ram int = (select ramas.idrama from ramas where ramas.rama = @p6)
	declare @car int = (select carpetas.idcarpeta from carpetas where carpetas.carpeta = @p7)

	UPDATE documentos SET
	codigo = @p1, doc = @p2, idpersonal = @per, comentarios = @p4, autorizo = @p5, idrama = @ram, idcarpeta = @car, activo = 1
	where documentos.iddoc = @p0
	

	insert into historial (iddoc, fecha, comentarios, autorizo) values (@p0, CURRENT_TIMESTAMP, @p4, @p5)
END
GO
/****** Object:  StoredProcedure [dbo].[buscarCodigo]    Script Date: 20/02/2020 03:01:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		emmanuel chavez
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[buscarCodigo]
	-- Add the parameters for the stored procedure here
	@p1 varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select documentos.iddoc from documentos where documentos.codigo = @p1
END
GO
/****** Object:  StoredProcedure [dbo].[buscarNombre]    Script Date: 20/02/2020 03:01:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		emmanuel chavez
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[buscarNombre] 
	-- Add the parameters for the stored procedure here
	@p1 varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select documentos.iddoc from documentos where documentos.doc = @p1
END
GO
/****** Object:  StoredProcedure [dbo].[habDoc]    Script Date: 20/02/2020 03:01:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		emmanuel chavez
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[habDoc]
	-- Add the parameters for the stored procedure here
	@p1 int,
	@p2 varchar(200),
	@p3 varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update documentos set activo = 1 where documentos.iddoc = @p1
	insert into historial(iddoc, fecha, comentarios, autorizo) values (@p1, CURRENT_TIMESTAMP, @p2, @p3)
END
GO
/****** Object:  StoredProcedure [dbo].[regArearp]    Script Date: 20/02/2020 03:01:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		emmanuel chavez
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[regArearp] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into arearps (arearp) values ('Quebalix 1')
	insert into arearps (arearp) values ('Quebalix 2')
	insert into arearps (arearp) values ('Quebalix 3')
	insert into arearps (arearp) values ('Quebalix 4')
	insert into arearps (arearp) values ('Comunicaciones')
	insert into arearps (arearp) values ('C. Herramientas')
	insert into arearps (arearp) values ('U. Ligeras')
	insert into arearps (arearp) values ('Oficinas')
END
GO
/****** Object:  StoredProcedure [dbo].[regCan]    Script Date: 20/02/2020 03:01:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		emmanuel chavez
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[regCan]
	-- Add the parameters for the stored procedure here
	@p1 int,
	@p2 varchar(200),
	@p3 varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update documentos set activo = 0 where documentos.iddoc = @p1
	insert into cancelaciones (iddoc, fecha, comentarios, autorizo) values (@p1, CURRENT_TIMESTAMP, @p2, @p3)
	insert into historial(iddoc, fecha, comentarios, autorizo) values (@p1, CURRENT_TIMESTAMP, @p2, @p3)
END
GO
/****** Object:  StoredProcedure [dbo].[regCarpetas]    Script Date: 20/02/2020 03:01:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		emmanuel chavez
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[regCarpetas] 
	-- Add the parameters for the stored procedure here
	  
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

INSERT INTO carpetas (carpeta)VALUES('Formatos')
INSERT INTO carpetas (carpeta)VALUES('Procedimientos')
INSERT INTO carpetas (carpeta)VALUES('Instructivos')
INSERT INTO carpetas (carpeta)VALUES('Ayuda visual')

END
GO
/****** Object:  StoredProcedure [dbo].[regDoc]    Script Date: 20/02/2020 03:01:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		emmanuel chavez
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[regDoc] 
	-- Add the parameters for the stored procedure here
	@p1 varchar(50),
	@p2 varchar(100),
	@p3 varchar(100),
	@p4 varchar(200),
	@p5 varchar(100),
	@p6 varchar(50),
	@p7 varchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @per int = (select personales.idpersonal from personales where personales.nombre = @p3)
	declare @ram int = (select ramas.idrama from ramas where ramas.rama = @p6)
	declare @car int = (select carpetas.idcarpeta from carpetas where carpetas.carpeta = @p7)

	insert into documentos (codigo, doc, idpersonal, comentarios, autorizo, idrama, idcarpeta, activo) 
	values (@p1, @p2, @per, @p4, @p5, @ram, @car, 1)

	declare @idoc int = (select top (1) documentos.iddoc from documentos where documentos.codigo = @p1)
	insert into historial (iddoc, fecha, comentarios, autorizo) values (@idoc, CURRENT_TIMESTAMP, @p4, @p5)
END
GO
/****** Object:  StoredProcedure [dbo].[regHis]    Script Date: 20/02/2020 03:01:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		emmanuel chavez
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[regHis] 
	-- Add the parameters for the stored procedure here
	@p1 int,
	@p2 varchar(200)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into historial (iddoc, fecha, comentarios) values (@p1, CURRENT_TIMESTAMP, @p2)
END
GO
/****** Object:  StoredProcedure [dbo].[regMos]    Script Date: 20/02/2020 03:01:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		emmanuel chavez
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[regMos] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO mos (mo)VALUES('Mantenimiento')
	INSERT INTO mos (mo)VALUES('Operacion')
END
GO
/****** Object:  StoredProcedure [dbo].[regPers]    Script Date: 20/02/2020 03:01:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		emmanuel chavez
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[regPers] 
	-- Add the parameters for the stored procedure here
	@p1 varchar(100),
	@p2 varchar(30),
	@p3 varchar(15),
	@p4 varchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @pues int = (select puestos.idpuesto from puestos where puestos.puesto = @p2)
	declare @mu int = (select mos.idmo from mos where mos.mo = @p3)
	declare @arp int = (select arearps.idarearp from arearps where arearps.arearp = @p4)

	insert into personales (nombre, idpuesto, idmo, idarearp) values (@p1, @pues, @mu, @arp)
END
GO
/****** Object:  StoredProcedure [dbo].[regPuestos]    Script Date: 20/02/2020 03:01:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		emmanuel chavez
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[regPuestos] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO puestos (puesto)VALUES('Gerente')
	INSERT INTO puestos (puesto)VALUES('Superintendente')
	INSERT INTO puestos (puesto)VALUES('Jefe')
	INSERT INTO puestos (puesto)VALUES('Supervisor')
	INSERT INTO puestos (puesto)VALUES('Operador')

END
GO
/****** Object:  StoredProcedure [dbo].[regRamas]    Script Date: 20/02/2020 03:01:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		emmanuel chavez
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[regRamas]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO ramas (rama) VALUES ('Quebalix 1 - MTTO')
	INSERT INTO ramas (rama) VALUES ('Quebalix 2 - MTTO')
	INSERT INTO ramas (rama) VALUES ('Quebalix 3 - MTTO')
	INSERT INTO ramas (rama) VALUES ('Quebalix 4 - MTTO')
	INSERT INTO ramas (rama) VALUES ('Quebalix-Generales  - MTTO')
	INSERT INTO ramas (rama) VALUES ('Quebalix 1 - OP')
	INSERT INTO ramas (rama) VALUES ('Quebalix 2 - OP')
	INSERT INTO ramas (rama) VALUES ('Quebalix 3 - OP')
	INSERT INTO ramas (rama) VALUES ('Quebalix 4 - OP')
	INSERT INTO ramas (rama) VALUES ('Quebalix-Generales - OP')
	INSERT INTO ramas (rama) VALUES ('Comunicaciones')
	INSERT INTO ramas (rama) VALUES ('C. Herramientas')
	INSERT INTO ramas (rama) VALUES ('U. Ligeras')
	INSERT INTO ramas (rama) VALUES ('Oficinas')

END
GO
/****** Object:  StoredProcedure [dbo].[validarDatos]    Script Date: 20/02/2020 03:01:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		emmanuel chavez
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[validarDatos] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select count (ramas.idrama) from ramas
END
GO
/****** Object:  StoredProcedure [dbo].[verCancelados]    Script Date: 20/02/2020 03:01:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		emmanuel chavez
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[verCancelados] 
	-- Add the parameters for the stored procedure here
	 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT cancelaciones.fecha, documentos.codigo, documentos.doc, cancelaciones.comentarios
	FROM cancelaciones INNER JOIN
    documentos ON cancelaciones.iddoc = documentos.iddoc
END
GO
/****** Object:  StoredProcedure [dbo].[verDoc]    Script Date: 20/02/2020 03:01:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		emanuel chavez
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[verDoc] 
	-- Add the parameters for the stored procedure here
	@p1 int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT documentos.iddoc, documentos.codigo, documentos.doc, personales.nombre, documentos.comentarios, documentos.autorizo, ramas.rama, carpetas.carpeta
	FROM documentos INNER JOIN
		 personales ON documentos.idpersonal = personales.idpersonal INNER JOIN
		 ramas ON documentos.idrama = ramas.idrama INNER JOIN
		 carpetas ON documentos.idcarpeta = carpetas.idcarpeta
	where documentos.iddoc = @p1

END
GO
/****** Object:  StoredProcedure [dbo].[verDocs]    Script Date: 20/02/2020 03:01:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		emmanuel chavez
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[verDocs] 
	-- Add the parameters for the stored procedure here
	@p1 varchar(50),
	@p2 varchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @r int = (select ramas.idrama from ramas where ramas.rama = @p1)
	declare @c int = (select carpetas.idcarpeta from carpetas where carpetas.carpeta = @p2)

	select documentos.iddoc, documentos.codigo, documentos.doc from documentos where documentos.idrama = @r and documentos.idcarpeta = @c and documentos.activo = 1
END
GO
/****** Object:  StoredProcedure [dbo].[verHist]    Script Date: 20/02/2020 03:01:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		emmanuel chavez
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[verHist] 
	-- Add the parameters for the stored procedure here
	@p1 int 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select historial.fecha, historial.comentarios from historial where historial.iddoc = @p1
END
GO
/****** Object:  StoredProcedure [dbo].[verRevs]    Script Date: 20/02/2020 03:01:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		emmanuel chavez
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[verRevs] 
	-- Add the parameters for the stored procedure here
	@p1 int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select top (2) historial.fecha from historial where historial.iddoc = @p1 order by fecha desc
END
GO

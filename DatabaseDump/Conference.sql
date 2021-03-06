USE [Сonference]
GO
/****** Object:  Table [dbo].[AuditAction]    Script Date: 24.06.2022 21:16:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AuditAction](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[time_moment] [datetime] NOT NULL,
	[username] [nvarchar](256) NOT NULL,
	[action_done] [nvarchar](256) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Conference]    Script Date: 24.06.2022 21:16:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Conference](
	[idConf] [int] IDENTITY(1,1) NOT NULL,
	[nameConf] [nvarchar](50) NOT NULL,
	[beginConf] [date] NOT NULL,
	[endConf] [date] NOT NULL,
	[build] [nvarchar](50) NOT NULL,
	[ranked] [int] NULL,
 CONSTRAINT [PK_Conference] PRIMARY KEY CLUSTERED 
(
	[idConf] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [id_Unique] UNIQUE NONCLUSTERED 
(
	[idConf] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EquipAndPerf]    Script Date: 24.06.2022 21:16:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EquipAndPerf](
	[idPerf] [int] NOT NULL,
	[idEquip] [int] NOT NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_EquipAndPerf] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Equipment]    Script Date: 24.06.2022 21:16:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Equipment](
	[idEquip] [int] IDENTITY(1,1) NOT NULL,
	[nameEquip] [nvarchar](50) NOT NULL,
	[idPerf] [int] NULL,
 CONSTRAINT [PK_Equipment] PRIMARY KEY CLUSTERED 
(
	[idEquip] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PerfAndSpeaker]    Script Date: 24.06.2022 21:16:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PerfAndSpeaker](
	[idSpeaker] [int] NOT NULL,
	[idPerf] [int] NOT NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_PerfAndSpeaker] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Performance]    Script Date: 24.06.2022 21:16:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Performance](
	[idPerf] [int] IDENTITY(1,1) NOT NULL,
	[idSect] [int] NOT NULL,
	[topicrf] [nvarchar](50) NOT NULL,
	[datetimePerf] [datetime] NOT NULL,
	[durationPerf] [time](7) NOT NULL,
 CONSTRAINT [PK_Performance] PRIMARY KEY CLUSTERED 
(
	[idPerf] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room]    Script Date: 24.06.2022 21:16:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[idRoom] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[UCR] [nvarchar](50) NULL,
	[DCR] [datetime] NULL,
	[Number] [int] NULL,
	[ULC] [nvarchar](50) NULL,
	[DLC] [datetime] NULL,
 CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED 
(
	[idRoom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Section]    Script Date: 24.06.2022 21:16:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Section](
	[idSect] [int] IDENTITY(1,1) NOT NULL,
	[idConf] [int] NOT NULL,
	[nameSect] [nvarchar](50) NOT NULL,
	[headSect] [nvarchar](50) NOT NULL,
	[roomSect] [int] NOT NULL,
 CONSTRAINT [PK_Section_1] PRIMARY KEY CLUSTERED 
(
	[idSect] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Speaker]    Script Date: 24.06.2022 21:16:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Speaker](
	[idSpeaker] [int] IDENTITY(1,1) NOT NULL,
	[degreeSpeaker] [nvarchar](50) NOT NULL,
	[academStatus] [nvarchar](50) NOT NULL,
	[placeOfWork] [nvarchar](50) NOT NULL,
	[positionSpeaker] [nvarchar](50) NOT NULL,
	[profBiogSpeaker] [varchar](max) NULL,
	[idPerf] [int] NULL,
 CONSTRAINT [PK_Speaker] PRIMARY KEY CLUSTERED 
(
	[idSpeaker] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Equipment]  WITH CHECK ADD  CONSTRAINT [FK_Equipment_Performance] FOREIGN KEY([idPerf])
REFERENCES [dbo].[Performance] ([idPerf])
GO
ALTER TABLE [dbo].[Equipment] CHECK CONSTRAINT [FK_Equipment_Performance]
GO
ALTER TABLE [dbo].[Performance]  WITH CHECK ADD  CONSTRAINT [FK_Performance_Section] FOREIGN KEY([idSect])
REFERENCES [dbo].[Section] ([idSect])
GO
ALTER TABLE [dbo].[Performance] CHECK CONSTRAINT [FK_Performance_Section]
GO
ALTER TABLE [dbo].[Section]  WITH CHECK ADD  CONSTRAINT [FK_Section_Conference] FOREIGN KEY([idConf])
REFERENCES [dbo].[Conference] ([idConf])
GO
ALTER TABLE [dbo].[Section] CHECK CONSTRAINT [FK_Section_Conference]
GO
ALTER TABLE [dbo].[Section]  WITH CHECK ADD  CONSTRAINT [FK_Section_Rooms] FOREIGN KEY([roomSect])
REFERENCES [dbo].[Room] ([idRoom])
GO
ALTER TABLE [dbo].[Section] CHECK CONSTRAINT [FK_Section_Rooms]
GO
ALTER TABLE [dbo].[Speaker]  WITH CHECK ADD  CONSTRAINT [FK_Speaker_Performance] FOREIGN KEY([idPerf])
REFERENCES [dbo].[Performance] ([idPerf])
GO
ALTER TABLE [dbo].[Speaker] CHECK CONSTRAINT [FK_Speaker_Performance]
GO

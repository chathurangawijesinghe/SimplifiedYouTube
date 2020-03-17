/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

SET IDENTITY_INSERT [dbo].[Videos] ON 
GO
INSERT [dbo].[Videos] ([Id], [Name], [Description], [VideoName], [BasePath]) VALUES (1, N'test 1', N'test 1 video', N'sample1.mp4', N'/')
GO
INSERT [dbo].[Videos] ([Id], [Name], [Description], [VideoName], [BasePath]) VALUES (2, N'test 2', N'test 2 video', N'sample2.mp4', N'/')
GO
INSERT [dbo].[Videos] ([Id], [Name], [Description], [VideoName], [BasePath]) VALUES (3, N'test 3', N'test 3 video', N'sample3.mp4', N'/')
GO
INSERT [dbo].[Videos] ([Id], [Name], [Description], [VideoName], [BasePath]) VALUES (4, N'test 4', N'test 4 video', N'sample4.mp4', N'/')
GO
INSERT [dbo].[Videos] ([Id], [Name], [Description], [VideoName], [BasePath]) VALUES (5, N'test 5', N'test 5 video', N'sample5.mp4', N'/')
GO
INSERT [dbo].[Videos] ([Id], [Name], [Description], [VideoName], [BasePath]) VALUES (6, N'test 6', N'test 6 video', N'sample6.mp4', N'/')
GO
INSERT [dbo].[Videos] ([Id], [Name], [Description], [VideoName], [BasePath]) VALUES (7, N'test 7', N'test 7 video', N'sample7.mp4', N'/')
GO
INSERT [dbo].[Videos] ([Id], [Name], [Description], [VideoName], [BasePath]) VALUES (8, N'test 8', N'test 8 video', N'sample8.mp4', N'/')
GO
INSERT [dbo].[Videos] ([Id], [Name], [Description], [VideoName], [BasePath]) VALUES (9, N'test 9', N'test 9 video', N'sample9.mp4', N'/')
GO
INSERT [dbo].[Videos] ([Id], [Name], [Description], [VideoName], [BasePath]) VALUES (10, N'test 10', N'test 10 video', N'sample10.mp4', N'/')
GO
INSERT [dbo].[Videos] ([Id], [Name], [Description], [VideoName], [BasePath]) VALUES (11, N'test 11', N'test 11 video', N'sample11.mp4', N'/')
GO
INSERT [dbo].[Videos] ([Id], [Name], [Description], [VideoName], [BasePath]) VALUES (12, N'test 12', N'test 12 video', N'sample12.mp4', N'/')
GO
SET IDENTITY_INSERT [dbo].[Videos] OFF
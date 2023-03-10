USE [master]
GO
/****** Object:  Database [higher_edu]    Script Date: 1/20/2018 7:19:08 PM ******/
CREATE DATABASE [higher_edu]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'higher_edu', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\higher_edu.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'higher_edu_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\higher_edu_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [higher_edu] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [higher_edu].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [higher_edu] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [higher_edu] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [higher_edu] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [higher_edu] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [higher_edu] SET ARITHABORT OFF 
GO
ALTER DATABASE [higher_edu] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [higher_edu] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [higher_edu] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [higher_edu] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [higher_edu] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [higher_edu] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [higher_edu] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [higher_edu] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [higher_edu] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [higher_edu] SET  DISABLE_BROKER 
GO
ALTER DATABASE [higher_edu] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [higher_edu] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [higher_edu] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [higher_edu] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [higher_edu] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [higher_edu] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [higher_edu] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [higher_edu] SET RECOVERY FULL 
GO
ALTER DATABASE [higher_edu] SET  MULTI_USER 
GO
ALTER DATABASE [higher_edu] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [higher_edu] SET DB_CHAINING OFF 
GO
ALTER DATABASE [higher_edu] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [higher_edu] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [higher_edu] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'higher_edu', N'ON'
GO
USE [higher_edu]
GO
/****** Object:  Table [dbo].[admin]    Script Date: 1/20/2018 7:19:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[admin](
	[id] [varchar](50) NULL,
	[password] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[college_details]    Script Date: 1/20/2018 7:19:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[college_details](
	[cid] [varchar](50) NULL,
	[cname] [varchar](max) NULL,
	[address] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[feedback]    Script Date: 1/20/2018 7:19:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[feedback](
	[uid] [varchar](50) NULL,
	[feedback] [varchar](max) NULL,
	[date] [varchar](max) NULL,
	[time] [varchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[main_stream]    Script Date: 1/20/2018 7:19:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[main_stream](
	[id] [varchar](50) NULL,
	[name] [varchar](50) NULL,
	[stream] [varchar](50) NULL,
	[features] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[questions]    Script Date: 1/20/2018 7:19:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[questions](
	[qid] [varchar](50) NULL,
	[type] [varchar](max) NULL,
	[question] [varchar](max) NULL,
	[a1] [varchar](max) NULL,
	[a2] [varchar](max) NULL,
	[a3] [varchar](max) NULL,
	[a4] [varchar](max) NULL,
	[ans] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[register]    Script Date: 1/20/2018 7:19:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[register](
	[sid] [varchar](50) NULL,
	[name] [varchar](50) NULL,
	[mobile] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[ssc] [varchar](50) NULL,
	[hsc] [varchar](50) NULL,
	[uname] [varchar](50) NULL,
	[password] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[results]    Script Date: 1/20/2018 7:19:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[results](
	[uid] [varchar](50) NULL,
	[apti] [varchar](50) NULL,
	[maths] [varchar](50) NULL,
	[eng] [varchar](50) NULL,
	[ssc] [varchar](50) NULL,
	[hsc] [varchar](50) NULL,
	[course] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[stream]    Script Date: 1/20/2018 7:19:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[stream](
	[st] [varchar](50) NULL,
	[cid] [varchar](50) NULL,
	[cname] [varchar](50) NULL,
	[mainstream] [varchar](50) NULL,
	[stream] [varchar](50) NULL,
	[cutoff] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[trainingdata]    Script Date: 1/20/2018 7:19:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[trainingdata](
	[mstream] [varchar](50) NULL,
	[stream] [varchar](50) NULL,
	[apti] [varchar](50) NULL,
	[maths] [varchar](50) NULL,
	[eng] [varchar](50) NULL,
	[ssc] [varchar](50) NULL,
	[hsc] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[admin] ([id], [password]) VALUES (N'admin', N'admin')
INSERT [dbo].[college_details] ([cid], [cname], [address]) VALUES (N'8001', N'Thakur College', N'Mumbai')
INSERT [dbo].[feedback] ([uid], [feedback], [date], [time]) VALUES (N'1001', N'good app', N'2018/01/20', N'6:41 PM')
INSERT [dbo].[main_stream] ([id], [name], [stream], [features]) VALUES (N'1001', N'BCOM', N'Commerce', N'3 years course')
INSERT [dbo].[main_stream] ([id], [name], [stream], [features]) VALUES (N'1002', N'BSCIT', N'Science', N'3 year graduation degree')
INSERT [dbo].[main_stream] ([id], [name], [stream], [features]) VALUES (N'1003', N'BA', N'Arts', N'Bachelor of arts for arts student 3 years degree')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'101', N'Apptitude', N'A man has Rs. 480 in the denominations of one-rupee notes, five-rupee notes and ten-rupee notes. The number of notes of each denomination is equal. What is the total number of notes that he has ?', N'45', N'60', N'75', N'90', N'90')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'102', N'Apptitude', N'There are two examinations rooms A and B. If 10 students are sent from A to B, then the number of students in each room is the same. If 20 candidates are sent from B to A, then the number of students in A is double the number of students in B. The number of students in room A is:', N'20', N'80', N'100', N'200', N'100')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'103', N'Apptitude', N'The price of 10 chairs is equal to that of 4 tables. The price of 15 chairs and 2 tables together is Rs. 4000. The total price of 12 chairs and 3 tables is:', N'Rs. 3500', N'Rs. 3750', N'Rs. 3840', N'Rs. 3900', N'Rs. 3900')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'104', N'Apptitude', N'	
If a - b = 3 and a2 + b2 = 29, find the value of ab.', N'10', N'12', N'15', N'18', N'10')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'105', N'Apptitude', N'The price of 2 sarees and 4 shirts is Rs. 1600. With the same money one can buy 1 saree and 6 shirts. If one wants to buy 12 shirts, how much shall he have to pay ?', N'Rs. 1200', N'Rs. 2400', N'Rs. 4800', N'Cannot be determined', N'Rs. 2400')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'106', N'Apptitude', N'A sum of Rs. 1360 has been divided among A, B and C such that A gets  of what B gets and B gets  of what C gets. Bs share is:', N'Rs. 120', N'Rs. 160', N'Rs. 240', N'Rs. 300', N'Rs. 240')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'107', N'Apptitude', N'A fires 5 shots to Bs 3 but A kills only once in 3 shots while B kills once in 2 shots. When B has missed 27 times, A has killed:', N'30 birds', N'60 birds', N'72 birds', N'90 birds', N'30 birds')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'108', N'Apptitude', N'	
Eight people are planning to share equally the cost of a rental car. If one person withdraws from the arrangement and the others share equally the entire cost of the car, then the share of each of the remaining persons increased by:', N'1/7', N'1/8', N'1/9', N'7/8', N'1/7')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'109', N'Apptitude', N'To fill a tank, 25 buckets of water is required. How many buckets of water will be required to fill the same tank if the capacity of the bucket is reduced to two-fifth of its present ?', N'10', N'35', N'62.5', N'Cannot be determined', N'62.5')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'110', N'Apptitude', N'	
In a regular week, there are 5 working days and for each day, the working hours are 8. A man gets Rs. 2.40 per hour for regular work and Rs. 3.20 per hours for overtime. If he earns Rs. 432 in 4 weeks, then how many hours does he work for ?', N'160', N'175', N'180', N'195', N'175')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'123', N'Maths', N'The average weight of 8 persons increases by 2.5 kg when a new person comes in place of one of them weighing 65 kg. What might be the weight of the new person?', N'76 kg', N'76.5 kg', N'85 kg', N'Data inadequate', N'85 kg')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'124', N'Maths', N'The captain of a cricket team of 11 members is 26 years old and the wicket keeper is 3 years older. If the ages of these two are excluded, the average age of the remaining players is one year less than the average age of the whole team. What is the average age of the team?', N'23 years', N'24 years', N'25 years', N'None of these', N'23 years')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'125', N'Maths', N'The average monthly income of P and Q is Rs. 5050. The average monthly income of Q and R is Rs. 6250 and the average monthly income of P and R is Rs. 5200. The monthly income of P is:', N'3500', N'4000', N'4050', N'5000', N'4000')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'128', N'Maths', N'In Aruns opinion, his weight is greater than 65 kg but less than 72 kg. His brother doest not agree with Arun and he thinks that Aruns weight is greater than 60 kg but less than 70 kg. His mothers view is that his weight cannot be greater than 68 kg. If all are them are correct in their estimation, what is the average of different probable weights of Arun?', N'67 kg', N'68 kg', N'69 kg', N'Data inadequate', N'67 kg')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'129', N'Maths', N'The average weight of A, B and C is 45 kg. If the average weight of A and B be 40 kg and that of B and C be 43 kg, then the weight of B is:', N'17 kg', N'20 kg', N'26 kg', N'31 kg', N'31 kg')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'130', N'Maths', N'The average weight of 16 boys in a class is 50.25 kg and that of the remaining 8 boys is 45.15 kg. Find the average weights of all the boys in the class.', N'47.55 kg', N'48 kg', N'48.55 kg', N'49.25 kg', N'48.55 kg')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'131', N'Maths', N'A library has an average of 510 visitors on Sundays and 240 on other days. The average number of visitors per day in a month of 30 days beginning with a Sunday is:', N'250', N'276', N'280', N'285', N'285')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'132', N'Maths', N'If the average marks of three batches of 55, 60 and 45 students respectively is 50, 55, 60, then the average marks of all the students is:', N'53.33', N'54.68', N'55', N'None of these', N'54.68')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'133', N'Maths', N'A pupils marks were wrongly entered as 83 instead of 63. Due to that the average marks for the class got increased by half (1/2). The number of pupils in the class is:', N'10', N'20', N'40', N'73', N'40')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'134', N'Maths', N'A, B and C can do a piece of work in 20, 30 and 60 days respectively. In how many days can A do the work if he is assisted by B and C on every third day?', N'12 days', N'15 days', N'16 days', N'18 days', N'15 days')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'135', N'Maths', N'A alone can do a piece of work in 6 days and B alone in 8 days. A and B undertook to do it for Rs. 3200. With the help of C, they completed the work in 3 days. How much is to be paid to C?', N'Rs. 375', N'Rs. 400', N'Rs. 600', N'Rs. 800', N'Rs. 400')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'136', N'Maths', N'If 6 men and 8 boys can do a piece of work in 10 days while 26 men and 48 boys can do the same in 2 days, the time taken by 15 men and 20 boys in doing the same type of work will be', N'4 days', N'5 days', N'6 days', N'7 days', N'4 days')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'137', N'English', N'The workers are hell bent at getting what is due to them.', N'hell bent on getting', N'hell bent for getting', N'hell bent upon getting', N'No improvement', N'hell bent upon getting')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'138', N'English', N'When it was feared that the serfs might go too far and gain their freedom from serfdom, the protestant leaders joined the princes at crushing them.', N'into crushing', N'in crushing', N'without crushing', N'No improvement', N'in crushing')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'139', N'English', N'If the room had been brighter, I would have been able to read for a while before bed time.', N'If the room was brighter', N'If the room are brighter', N'Had the room been brighter', N'No improvement', N'Had the room been brighter')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'140', N'English', N'The record for the biggest tiger hunt has not been met since 1911 when Lord Hardinge. then Viceroy of India, shot a tiger than measured 11 feet and 6 inches.', N'improved', N'broken', N'bettered', N'No improvement', N'broken')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'141', N'English', N'his powerful desire brought about his downfall.', N'His intense desire', N'His desire for power', N'His fatal desire', N'No improvement', N'His desire for power')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'142', N'English', N'Will you kindly open the knot?', N'untie', N'break', N'loose', N'No improvement', N'untie')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'143', N'English', N'He sent a word to me that he would be coming late.', N'sent word', N'had sent a word', N'sent words', N'No improvement', N'sent word')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'144', N'English', N'John had told me that he hasnt done it yet.', N'told', N'tells', N'was telling', N'No improvement', N'tells')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'145', N'English', N'If he had time he will call you.', N'would have', N'would have had', N'has
', N'No improvement', N'has')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'146', N'English', N'Will you lend me few rupees in this hour of need?', N'lend me any rupees', N'borrow me a few rupees', N'lend me a few rupees', N'No improvement', N'lend me a few rupees')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'147', N'English', N'During his long discourse, he did not touch that point.', N'touch upon', N'touch on', N'touch of', N'No improvement', N'touch on')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'111', N'Apptitude', N'Free notebooks were distributed equally among children of a class. The number of notebooks each child got was one-eighth of the number of children. Had the number of children been half, each child would have got 16 notebooks. Total how many notebooks were distributed ?', N'256', N'432', N'512', N'640', N'512')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'112', N'Apptitude', N'Brass gets discoloured in air because of the presence of which of the following gases in air?', N'Oxygen', N'Hydrogen sulphide', N'Carbon dioxide', N'Nitrogen', N'Hydrogen sulphide')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'113', N'Apptitude', N'A train running at the speed of 60 km/hr crosses a pole in 9 seconds. What is the length of the train?', N'120 metres', N'180 metres', N'324 metres', N'150 metres', N'150 metres')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'114', N'Apptitude', N'A train 125 m long passes a man, running at 5 km/hr in the same direction in which the train is going, in 10 seconds. The speed of the train is:', N'45 km/hr', N'50 km/hr', N'54 km/hr', N'55 km/hr', N'50 km/hr')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'115', N'Apptitude', N'The length of the bridge, which a train 130 metres long and travelling at 45 km/hr can cross in 30 seconds, is:', N'200 m', N'225 m', N'245 m', N'250 m', N'245 m')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'116', N'Apptitude', N'Two trains running in opposite directions cross a man standing on the platform in 27 seconds and 17 seconds respectively and they cross each other in 23 seconds. The ratio of their speeds is:', N'1 : 3', N'3 : 2', N'3 : 4', N'None of these', N'3 : 2')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'117', N'Apptitude', N'A train passes a station platform in 36 seconds and a man standing on the platform in 20 seconds. If the speed of the train is 54 km/hr, what is the length of the platform?', N'120 m', N'240 m', N'300 m', N'None of these', N'240 m')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'118', N'Apptitude', N'A train 240 m long passes a pole in 24 seconds. How long will it take to pass a platform 650 m long?', N'65 sec', N'89 sec', N'100 sec', N'150 sec', N'89 sec')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'119', N'Apptitude', N'Two trains of equal length are running on parallel lines in the same direction at 46 km/hr and 36 km/hr. The faster train passes the slower train in 36 seconds. The length of each train is:', N'50 m', N'72 m', N'80 m', N'82 m', N'50 m')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'120', N'Maths', N'In the first 10 overs of a cricket game, the run rate was only 3.2. What should be the run rate in the remaining 40 overs to reach the target of 282 runs?', N'6.25', N'6.5', N'6.75', N'7', N'6.25')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'121', N'Maths', N'	
A grocer has a sale of Rs. 6435, Rs. 6927, Rs. 6855, Rs. 7230 and Rs. 6562 for 5 consecutive months. How much sale must he have in the sixth month so that he gets an average sale of Rs. 6500?', N'Rs. 4991', N'Rs. 5991', N'Rs. 6001', N'Rs. 6991', N'Rs. 4991')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'122', N'Maths', N'The average of 20 numbers is zero. Of them, at the most, how many may be greater than zero?', N'0', N'1', N'10', N'19', N'19')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'126', N'Maths', N'The average age of husband, wife and their child 3 years ago was 27 years and that of wife and the child 5 years ago was 20 years. The present age of the husband is:', N'35 years', N'40 years', N'50 years', N'None of these', N'40 years')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'127', N'Maths', N'A car owner buys petrol at Rs.7.50, Rs. 8 and Rs. 8.50 per litre for three successive years. What approximately is the average cost per litre of petrol if he spends Rs. 4000 each year?', N'Rs. 7.98', N'Rs. 8', N'Rs. 8.50', N'Rs. 9', N'Rs. 7.98')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'148', N'English', N'He found a wooden broken chair in the room.', N'wooden and broken chair', N'broken wooden chair', N'broken and wooden chair', N'No improvement', N'broken wooden chair')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'149', N'English', N'He could not look anything in the dark room.', N'look at', N'see', N'see through', N'No improvement', N'see')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'150', N'English', N'The greatest thing in style is to have a use of metaphor.', N'knowledge', N'command', N'need', N'No improvement', N'knowledge')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'151', N'English', N'While crossing the highway a five year old child was knocked out by a passing car.', N'away', N'up', N'down', N'No improvement', N'down')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'152', N'English', N'hoping not to be disturbed, I sat down in my easy chair to read the book. I won as a prize.', N'I had won as a prize', N'I have won as prize', N'I had to win as a prize', N'No improvement', N'I had won as a prize')
INSERT [dbo].[questions] ([qid], [type], [question], [a1], [a2], [a3], [a4], [ans]) VALUES (N'153', N'English', N'More than one person was killed in accident.', N'were killed', N'are killed', N'have been killed', N'No improvement', N'No improvement')
INSERT [dbo].[register] ([sid], [name], [mobile], [email], [ssc], [hsc], [uname], [password]) VALUES (N'1001', N'Mary', N'7123456789', N'mary@gmail.com', N'50', N'70', N'mary', N'mary123')
INSERT [dbo].[results] ([uid], [apti], [maths], [eng], [ssc], [hsc], [course]) VALUES (N'1001', N'4', N'0', N'6', N'50', N'60', N'BA')
INSERT [dbo].[stream] ([st], [cid], [cname], [mainstream], [stream], [cutoff]) VALUES (N'6001', N'8001', N'Thakur College', N'Commerce', N'BCOM', N'70')
INSERT [dbo].[stream] ([st], [cid], [cname], [mainstream], [stream], [cutoff]) VALUES (N'6002', N'8001', N'Thakur College', N'Arts', N'BA', N'70')
INSERT [dbo].[stream] ([st], [cid], [cname], [mainstream], [stream], [cutoff]) VALUES (N'6003', N'8001', N'Thakur College', N'Science', N'BSCIT', N'70')
INSERT [dbo].[trainingdata] ([mstream], [stream], [apti], [maths], [eng], [ssc], [hsc]) VALUES (N'Arts', N'BA', N'5', N'5', N'5', N'50', N'50')
INSERT [dbo].[trainingdata] ([mstream], [stream], [apti], [maths], [eng], [ssc], [hsc]) VALUES (N'Commerce', N'BCOM', N'7', N'7', N'7', N'50', N'60')
INSERT [dbo].[trainingdata] ([mstream], [stream], [apti], [maths], [eng], [ssc], [hsc]) VALUES (N'Science', N'BSCIT', N'10', N'10', N'10', N'60', N'60')
USE [master]
GO
ALTER DATABASE [higher_edu] SET  READ_WRITE 
GO

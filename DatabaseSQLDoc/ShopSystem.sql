--create database ShopSystem
go
use ShopSystem
go
if exists(select * from sysObjects where name='Shop_UserInfo' and xtype='U')
drop table Shop_UserInfo
go
--用户信息表
create table Shop_UserInfo
(
  Id uniqueidentifier primary key,
  UserName varchar(200),
  [Password] varchar(200),
  [Address] text,
  Sex varchar(5),
  TelNum varchar(20),
  PhoneNum varchar(20),
  [Status] varchar(20),
  CreateDate datetime,
  CreateBy uniqueidentifier,
  UpdateDate datetime,
  UpdateBy uniqueidentifier
)
go
if exists(select * from sysObjects where name='Shop_VipScore' and xtype='U')
drop table Shop_VipScore
go
--会员信息表
create table Shop_VipScore
(
  Id uniqueidentifier primary key,
  CardNumber int,
  Score int,
  VipName varchar(200),
  VipPhone int,
  VipSex varchar(3),
  VipRemark varchar(2000),
  [Status] varchar(20),
  VipLevelId uniqueidentifier,
  CreateBy uniqueidentifier,
  CreateDate datetime,
  UpdateBy uniqueidentifier,
  UpdateDate datetime
)
go
if exists(select * from sysObjects where name='Shop_VipLevel' and xtype='U')
drop table Shop_VipLevel
go
--会员等级表
create table Shop_VipLevel
(
  Id uniqueidentifier primary key,
  LevelNumber int,
  Score int,2
  Discount float,
  [Status] varchar(20),
  CreateBy uniqueidentifier,
  CreateDate datetime,
  UpdateBy uniqueidentifier,
  UpdateDate datetime
)
go
if exists(select * from sysObjects where name='Shop_VipScoreBuyLog' and xtype='U')
drop table Shop_VipScoreBuyLog
go
--会员积分消费表
create table Shop_VipScoreBuyLog(
  Id uniqueidentifier primary key,
  VipId uniqueidentifier,
  BuyScore int,
  Remoark varchar(2000),
  [Status] varchar(20),
  CreateBy uniqueidentifier,
  CreateDate datetime,
  UpdateBy uniqueidentifier,
  UpdateDate datetime  
)
go
if exists(select * from sysObjects where name='Shop_StockInfo' and xtype='U')
drop table Shop_StockInfo
go
--库存表
create table Shop_StockInfo(
  Id uniqueidentifier primary key,
  ShopImg nvarchar(200),
  ShopImgName nvarchar(200),
  ShopName nvarchar(300),
  ShopNum int,
  ShopSource nvarchar(500),
  ShopPurchasePrice decimal,
  ShopPrice decimal,
  ShopRemark nvarchar(500),
  [Status] varchar(20),
  CreateBy uniqueidentifier,
  CreateDate datetime,
  UpdateBy uniqueidentifier,
  UpdateDate datetime
)
go
if exists(select * from sysObjects where name='Shop_OrderInfo' and xtype='U')
drop table Shop_OrderInfo
go
--订单表
create table Shop_OrderInfo(
  Id uniqueidentifier primary key,
  StockId uniqueidentifier,
  BuyNum int,
  VipNumber nvarchar(500),
  VipScore int,
  OrderPrice decimal,
  OrderRemark nvarchar(500),
  [Status] varchar(20),
  CreateBy uniqueidentifier,
  CreateDate datetime,
  UpdateBy uniqueidentifier,
  UpdateDate datetime
)
go
if exists(select * from sysObjects where name='Shop_StockInfo_Item' and xtype='U')
drop table Shop_StockInfo_Item
go
--库存详情表
create table Shop_StockInfo_Item(
  Id uniqueidentifier primary key,
  StockInfoId uniqueidentifier,
  ShopNumber varchar(100),
  Size varchar(20),
  Color varchar(50),
  Number int,
  CreateBy uniqueidentifier,
  CreateDate datetime,
  UpdateBy uniqueidentifier,
  UpdateDate datetime
)
select NEWID()

select * from Shop_UserInfo
select * from Shop_VipLevel
select * from Shop_VipScore
select * from Shop_VipScoreBuyLog
select * from Shop_StockInfo
select *,StockInfoId from Shop_StockInfo_Item

--delete from Shop_StockInfo
--delete from Shop_StockInfo_Item

update Shop_StockInfo set [Status]='ACTIVE' 

SELECT * FROM (  SELECT ROW_NUMBER() OVER (order by T.Id desc)AS Row, T.*  from Shop_StockInfo T  ) TT WHERE TT.Row between 0 and 10
SELECT * FROM (  SELECT ROW_NUMBER() OVER (order by T.Status='ACTIVE')AS Row, T.*  from Shop_StockInfo T  ) TT WHERE TT.Row between 0 and 10
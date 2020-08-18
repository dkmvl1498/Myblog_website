create database BlogerWebsite
use BlogerWebsite

create table tblAllOfWeb
(
	id int identity primary key,
	slogan Nvarchar(250),
	img_Logo Varchar(250),
	img_Login Varchar(250),
	link_FanPage_Face Varchar(250),
	link_FanPage_TW Varchar(250),
	link_FanPage_IG Varchar(250)
)
create table tblAccount
(
	id_acc int identity primary key,
	userName varchar(12),
	pass_Word varchar(30),
	access Varchar(10)
)

create table tblUser
(
	id_User int identity Primary key,
	id_acc int references tblAccount(id_acc),
	name_User Nvarchar(30),
	nickName Nvarchar(15),
	date_Of_Birth date,
	Email varchar(30),
	title_User Nvarchar(150),
	link_FB varchar(150),
	link_IG varchar(150),
	sl_BaiViet int default(0)
)

create table tblTHeLoai
(
	id_theloai int identity primary key,
	name_TheLoai Nvarchar(20),
	soLuong int
)

create table tblBaiViet
(
	id_BaiViet int identity primary key,
	id_theLoai int references tblTheLoai(id_theLoai),
	titleBaiViet Nvarchar(50),
	img_Title varchar(50),
	danhGia int check(danhGia <= '5'),
	view_BaiViet int
)

create table tblTag
(
	id_tag int identity primary key,
	name_tag Nvarchar(10),
	sl_tag int
)

create table tblUser_Baiviet
(
	id_User_Baiviet int identity primary key,
	id_User int references tblUser(id_User),
	id_Baiviet int references tblBaiViet(id_BaiViet)
)

create table tblTag_BaiViet
(
	id_Tag_Baiviet int identity primary key,
	id_tag int references tblTag(id_Tag),
	id_BaiViet int references tblBaiViet(id_BaiViet)
)

create table tblBV_comment
(
	id_Cmt int identity primary key,
	id_BaiViet int references tblBaiViet(id_BaiViet),
	text_cmt Nvarchar(250),
	cmt_like int default(0),
	cmt_dislike int default(0)
)

alter table tblBV_comment
add time_cmt Smalldatetime
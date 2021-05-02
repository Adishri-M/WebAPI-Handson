create database DbBooks

use DbBooks

create table Books ( BookCode int primary key, Title varchar(50), Publisher varchar(20), Type varchar(10), Price Numeric(4,2));

Insert into Books values(2000, 'A Deepness in the Sky', 'TB','SFI','7.12')

select * from Books
drop table Books
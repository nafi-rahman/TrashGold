CREATE DATABASE DEMO_DB;
CREATE TABLE REG_TBL
(
USERID INT IDENTITY(1,1) PRIMARY KEY,
USERTYPE VARCHAR(50),
USERNAME VARCHAR(50),
EMAIL VARCHAR(50),
PASS VARCHAR(50)

);

SELECT * FROM REG_TBL;

SELECT * FROM REG_TBL;

insert into REG_TBL VALUES ('admin','hadi','hadi@gmail.com','1234');
insert into REG_TBL VALUES ('donor','pasha','pasha@gmail.com','4321');
delete from REG_TBL where USERNAME= '@name';
select * from REG_TBL WHERE USERNAME='hadi' and PASS='1234' and USERTYPE='admin';
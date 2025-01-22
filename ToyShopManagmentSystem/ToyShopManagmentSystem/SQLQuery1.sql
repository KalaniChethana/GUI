CREATE TABLE users
(
	id int PRIMARY KEY IDENTITY(1,1),
	username VARCHAR(MAX) NULL,
	password VARCHAR(MAX) NULL,
	role VARCHAR(MAX) NULL,
	status VARCHAR(MAX) NULL,
	date DATE NULL

)
SELECT * FROM users

INSERT INTO users(username, password,role,status,date)VALUES('admin','admin123','Ádmin','Active','2025-01-15')


SELECT name FROM sys.databases;

USE master;
GO


SELECT DB_NAME();
SELECT name FROM sys.databases;

CREATE TABLE categories
(
    id int PRIMARY KEY IDENTITY(1,1),  
	category VARCHAR(MAX) NULL,
	date DATE NULL
);

SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'categories';

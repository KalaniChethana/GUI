CREATE TABLE users
(
	id int PRIMARY KEY IDENTITY(1,1),
	username VARCHAR(MAX) NULL,
	password VARCHAR(MAX) NULL,
	role VARCHAR(MAX) NULL,
	status VARCHAR(MAX) NULL,
	date DATE NULL
);


SELECT * FROM users

INSERT INTO users(username, password, role, status, date) VALUES('admin', 'admin123','Admin','Active','2025-01-15')

CREATE TABLE categories
(
    id INT IDENTITY(1,1) PRIMARY KEY,  
	category VARCHAR(MAX) NULL,
	date DATE NULL
);


SELECT * FROM categories

INSERT INTO categories(category,date)VALUES('cloths','2025-01-15')


SELECT DB_NAME();



CREATE TABLE products
(
	id INT IDENTITY(1,1) PRIMARY KEY,  
	prod_id VARCHAR(100) NULL, 
	prod_name VARCHAR(255) NULL, 
	category VARCHAR(100) NULL, 
	price DECIMAL(18,2) NULL, 
	stock INT NULL, 
	status VARCHAR(50) NULL, 
	date_insert DATE NULL 
);

SELECT * FROM products;

INSERT INTO products (prod_id, prod_name, category, price, stock, status, date_insert)VALUES ('P001', 'Toy Car', 'Toys', 12.99, 50, 'Available', '2025-01-15');

CREATE TABLE orders
(
	id int PRIMARY KEY IDENTITY(1,1),
	prod_id VARCHAR(MAX) NULL,
	prod_name VARCHAR(MAX) NULL,
	category VARCHAR(MAX) NULL,
	qty INT NULL,
	orig_price FLOAT NULL,
	total_price FLOAT NULL,
	order_DATE DATE NULL,
	customer_id INT NULL

);

SELECT * FROM orders



CREATE TABLE customers
(
	id INT PRIMARY KEY IDENTITY(1,1),
	customer_id INT NULL,
	total_price FLOAT NULL,
	amount FLOAT NULL,
	change FLOAT NULL,
	oder_date DATE NULL
);

 SELECT * FROM customers


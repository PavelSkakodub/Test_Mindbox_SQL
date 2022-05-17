CREATE TABLE products ( 
Id INT PRIMARY KEY, 
NAME VARCHAR(30));

INSERT INTO products 
VALUES (1, 'BMW X7'), (2, 'Окорочок'), (3, 'Карандаш'), (4, 'Курица');

CREATE TABLE categories ( 
Id INT PRIMARY KEY, 
Name VARCHAR(30) );

INSERT INTO categories 
VALUES (1, 'Авто'), (2, 'Мясные продукты'), (3, 'Канцелярские изделия');

CREATE TABLE ProductCategories ( 
ProductId INT FOREIGN KEY REFERENCES Products(Id), 
CategoryId INT FOREIGN KEY REFERENCES Categories(Id), 
PRIMARY KEY (ProductId, CategoryId) );

INSERT INTO ProductCategories VALUES (1, 1), (2, 2), (3, 3), (4,2);

SELECT P.Name, C.Name 
FROM Products P 
LEFT JOIN ProductCategories PC ON P.Id = PC.ProductId 
LEFT JOIN Categories C ON PC.CategoryId = C.Id;
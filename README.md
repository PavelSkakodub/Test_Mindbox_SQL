# Test_Mindbox_SQL
Использовался EF Core Code First. 
Это на SQL:

CREATE TABLE Products (
Id INT PRIMARY KEY,
"Name" TEXT
);

INSERT INTO Products
VALUES
(1, 'BMW X7'),
(2, 'Окорочок'),
(3, 'Карандаш'),
(4, 'Курица');

CREATE TABLE Categories (
Id INT PRIMARY KEY,
"Name" TEXT
);

INSERT INTO Categories
VALUES
(1, 'Авто'),
(2, 'Мясные продукты'),
(3, 'Канцелярские изделия');

CREATE TABLE ProductCategories (
ProductId INT FOREIGN KEY REFERENCES Products(Id),
CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO ProductCategories
VALUES
(1, 1), (2, 2), (3, 3), (4,2);

SELECT P."Name", C."Name"
FROM Products P
LEFT JOIN ProductCategories PC
ON P.Id = PC.ProductId
LEFT JOIN Categories C
ON PC.CategoryId = C.Id;

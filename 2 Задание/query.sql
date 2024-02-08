CREATE TABLE Products (
	Id INT PRIMARY KEY,
	"Name" nvarchar(150)
);
INSERT INTO Products
VALUES
	(1, 'Warhammer 40000'),
	(2, 'Ларри Кинг. Как разговаривать с кем угодно'),
	(3, 'Intel i5-4690'),
	(4, 'Барби');
	
CREATE TABLE Categories (
	Id INT PRIMARY KEY,
	"Name" nvarchar(150)
);

INSERT INTO Categories
VALUES
	(1, 'Games'),
	(2, 'Books'),
	(3, 'Components');

CREATE TABLE ProductCategories (
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO ProductCategories
VALUES
	(1, 1),
	(1, 2),
	(2, 2),
	(3, 3);

SELECT Products."Name", Categories."Name"
FROM Products 
LEFT JOIN ProductCategories 
	ON Products.Id = ProductCategories.ProductId
LEFT JOIN Categories 
	ON ProductCategories.CategoryId = Categories.Id;
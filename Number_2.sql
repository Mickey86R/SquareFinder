CREATE TABLE Product
(
    id INT IDENTITY(1, 1) NOT NULL,
    [name] NVARCHAR(50),
    PRIMARY KEY (id)
)

INSERT INTO Product VALUES ('nike'),
                           ('abibas'),
                           ('gazmyas'),
                           ('calvados'),
                           ('ananas')

CREATE TABLE Category
(
    id INT IDENTITY(1, 1) NOT NULL,
    [name] NVARCHAR(50),
    PRIMARY KEY(id)
)

INSERT INTO Category VALUES ('smex'),
                           ('pal'),
                           ('sport'),
                           ('fruit')

CREATE TABLE ProdCat(
    idProd INT,
    idCat INT,
    FOREIGN KEY (idProd) REFERENCES Product(id),
    FOREIGN KEY (idCat) REFERENCES Category(id)
)

INSERT INTO ProdCat VALUES (1, 3),
                           (1, 2),
                           (2, 1),
                           (2, 2),
                           (2, 3),
                           (3, 1),
                           (3, 2),
                           (5, 4)

SELECT Product.[name] AS "Имя подукта", 
       Category.[name] AS "Имя категории" FROM ProdCat
    FULL JOIN Product ON ProdCat.idProd = Product.id
    FULL JOIN Category ON ProdCat.idCat = Category.id
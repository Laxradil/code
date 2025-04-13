CREATE TABLE admin
(
        id INT PRIMARY KEY IDENTITY(1,1), 
        username VARCHAR(MAX) NULL,
        passowrd VARCHAR(MAX) NULL, 
        date_created DATE NULL,
) 

SELECT * FROM admin
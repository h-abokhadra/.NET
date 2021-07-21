use BooksDB

/*-----------------------------------------*/
/*Stored Procedure*/

CREATE OR ALTER PROCEDURE spGetTitle
AS
BEGIN
  Select * from Titles
END

/* Test the spGetTitle Stored Procedure*/
spGetTitle


/*-----------------------------------------*/
/*Stored Procedure with one parameter*/

CREATE OR ALTER PROCEDURE spGetTitleOnePar
@EditionNumber INT
AS
BEGIN
  Select * from Titles
  where @EditionNumber = EditionNumber 
END

/* Test the spGetTitleOnePar Stored Procedure*/
spGetTitleOnePar @EditionNumber=10


/*-----------------------------------------*/
/*Stored Procedure with two parameter*/

CREATE OR ALTER PROCEDURE spGetTitleTwoPar
@Copyright VARCHAR (4),
@EditionNumber INT
AS
BEGIN
select * from Titles
where Copyright>@Copyright and EditionNumber> @EditionNumber;
END


/* Test the spGetTitleTwoPar Stored Procedure*/
spGetTitleTwoPar @Copyright='2016', @EditionNumber=3
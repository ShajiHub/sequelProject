
CREATE PROCEDURE spGetBookDetails
@book_title VARCHAR(80)
AS
BEGIN
SELECT
    TI.title as "Book Name",
    AU.au_fname AS "Author FName",
    AU.au_lname AS "Author LName",
    FORMAT(TI.price,'C') As "Book Price"
    
FROM 
 authors AS AU 
JOIN
  titleauthor as TA
 ON AU.au_id=TA.au_id
 JOIN
 titles AS TI 
  ON TI.title_id=TA.title_id
WHERE
    title like'%'+@book_title+'%'
END

EXEC spGetBookdetails
@book_title = "Secrets"
   


CREATE PROCEDURE spListByCategories
@book_category VARCHAR(80)
AS
BEGIN

    SELECT 
         TI.title as "Book Name",
         TI.notes as "Overview"
    FROM
        titles AS TI 
    WHERE
        TI.type=@book_category
    ORDER BY TI.title 

END

EXEC spListByCategories
@book_category = 'business'

--select * from titles order by type ASC
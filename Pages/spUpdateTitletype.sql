
CREATE PROC spUpdatetitleType
@bookName VARCHAR(80),
@bookType VARCHAR(80)
AS
BEGIN
 UPDATE titles
 SET 
    
    type = @bookType
    
    WHERE titles.title= @bookName
END

GO
EXEC spUpdatetitleType
@bookName = 'Straight Talk About Computers',
@bookType = 'Technology'

--select * from titles

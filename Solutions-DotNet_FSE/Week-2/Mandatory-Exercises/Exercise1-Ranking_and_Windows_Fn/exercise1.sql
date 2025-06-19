/* Row_NUMBER() */
SELECT * FROM (
    SELECT 
        ProductID,
        ProductName,
        Category,
        Price,
        ROW_NUMBER() OVER (PARTITION BY Category ORDER BY Price) AS RowNum
    FROM Products
) AS RankedProducts
WHERE RowNum <= 3;


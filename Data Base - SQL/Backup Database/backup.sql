-- Set the path where you want to save the CSV files
DECLARE @BackupPath NVARCHAR(255) = 'C:\Your\Backup\Path\';

-- Declare variables
DECLARE @TableName NVARCHAR(255);
DECLARE @CsvFileName NVARCHAR(255);

-- Cursor to iterate through all tables in the database
DECLARE tableCursor CURSOR FOR
SELECT table_name
FROM information_schema.tables
WHERE table_type = 'BASE TABLE';

OPEN tableCursor;

FETCH NEXT FROM tableCursor INTO @TableName;

WHILE @@FETCH_STATUS = 0
BEGIN
    -- Construct the CSV file name based on the table name
    SET @CsvFileName = @BackupPath + @TableName + '.csv';

    -- Generate dynamic SQL to export table data to CSV
    DECLARE @SqlQuery NVARCHAR(MAX);
    SET @SqlQuery = 'SELECT * INTO OUTFILE ''' + @CsvFileName + ''' FIELDS TERMINATED BY '','' OPTIONALLY ENCLOSED BY ''"'' LINES TERMINATED BY ''\n'' FROM ' + @TableName;

    -- Execute the dynamic SQL
    EXEC sp_executesql @SqlQuery;

    -- Fetch the next table
    FETCH NEXT FROM tableCursor INTO @TableName;
END

CLOSE tableCursor;
DEALLOCATE tableCursor;


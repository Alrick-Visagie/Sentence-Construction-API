IF EXISTS(SELECT * FROM master.sys.sysdatabases 
          WHERE name='dbSentenceConstruction')
BEGIN
    PRINT 'Database Exists'
END
ELSE
BEGIN
    CREATE DATABASE dbSentenceConstruction
END
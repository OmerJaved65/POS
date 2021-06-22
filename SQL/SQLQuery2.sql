/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Product]
      ,[Quantity]
      ,[Rate]
      ,[total]
  FROM [POS].[dbo].[POS_TABLE]
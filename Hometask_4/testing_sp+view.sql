
-- Проверка sp_mostPopularProducts
declare @begin_date datetime = cast('2022-01-01 00:00:00.0000000' as datetime2(7))
declare @end_date datetime = cast('2022-08-31 00:00:00.0000000' as datetime2(7))

exec [dbo].[sp_mostPopularProducts] '66962DE5-D5D2-4028-B1B1-2F288BE28399', @begin_date, @end_date 


-- Проверка представления vw_ClientsActivity
select * from vw_ClientsActivity
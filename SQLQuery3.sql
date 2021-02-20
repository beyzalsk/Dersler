-- Açıklama satırı 
Select CompanyName SirketeAdi, City Sehir from Customers
-- Where koşul belli eder
-- case insensitive büyük küçük harf duyarlı değildir 
Select * from Customers where City = 'London' -- sehiri London olanlar
Select * from Products where CategoryId=1 or CategoryId =3 -- Kategori Idsi 1 ve 3 olanlar 
Select * from Products where CategoryID =4 or UnitPrice>=8 -- Kategori Id si 4 ve fiyatı 8e eşit ve 8 den büyük olanlar 
-- order by sıralama 
Select * from Products order by UnitPrice asc -- asc artan demek dsc düşen demek
-- count listedeki bütün ürünleri tek satır ve  sütunda sayar
Select count(*) from Products -- tüm satırları sayar 
select count(*)Adet from Products  -- yine tüm satırları sayar ama adet olarak isim verir 
Select count(*) from Products where  CategoryId = 1 -- Kategori Id si 1 olanların satırlarını sayar 
select categoryId, count(*) from Products group by CategoryID -- kategori Idsine göre hangisinden kaç ürün var onu  getirir 
select count(*) from  Products group by CategoryID having count(*)<10 --10dan az kalanları verir 
select count(*) from Products where UnitPrice>30 group by CategoryID having count(*)<10 





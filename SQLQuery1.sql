-- yorum satırı olarak kullanılır 
-- çalıştırcağın kodu seç öyle çalıştır.
Select ContactName, CompanyName, City from Customers  
-- Select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers  isimleri değiştiriyor 

Select * from Customers where City = 'London' 
-- where koşul belli eder 
-- case insemsitive büyük küçük harf duyarlı değil 
Select * from Products  where CategoryID=1 oR UnitPrice>=10
-- order by sıralama 
select * from Products order by UnitPrice asc --asc artan demek dsc de düşen demek 
-- Count listede bulunan ürünleri tek satır ve sütunda sayar
select count(*) from Products -- tüm satırları say 
select count(*) from Products where CategoryId =1 -- 1 ıdsinde kaç veri var 
 select count(*)Adet From Products
 select categoryId, count(*) from products group by CategoryID -- kategorilerine göre ürün sayısını verir 
 select count(*) from products group by CategoryID having count(*) <10 -- 10 dan az kalanları verir 
 select count(*) from products where UnitPrice>20 group by CategoryID having count(*) <10 -- fiyatı 20den fazla ve sayısı 10dan az 
 select * from Products inner join Categories 
 on Products.CategoryID = Categories.CategoryID 




 
 -- İNNER JOİN SADECE EŞLEŞEN SATIRLARI GETİRİR		
 -- left join solda olup sağda olmayanlarıda getir 
 
 


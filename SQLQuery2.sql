-- yorum satırı olarak kullanılır 
-- çalıştırcağın kodu seç öyle çalıştır.
Select ContactName, CompanyName, City from Customers  
-- Select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers  isimleri değiştiriyor 

Select * from Customers where City = 'London' 
-- where koşul belli eder 
-- case insemsitive büyük küçük harf duyarlı değil 
Select * from Products  where CategoryID=1 oR UnitPrice>=10
-- order by sıralama 
select * from Products order by UnitPrice asc --asc artan demek 
select * from Products order by UnitPrice dsc --azalan


 
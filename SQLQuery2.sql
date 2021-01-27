--Select
--ANSI standarti
Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers

Select * from Customers where City='London'

--case insensitive - boyuk kicik herf ferq etmir
sElECt * from Products where categoryID=1 or categoryId=3
sElECt * from Products where categoryID=1 and UnitPrice>10

--order by - siralamada istifade olunur.
select * from Products order by UnitPrice
--Artan sira
select * from Products order by UnitPrice asc --ascending-artan

--Azalan sira
select * from Products order by UnitPrice desc --Descending-düşən

select * from Products where CategoryID=1 order by UnitPrice desc

--sayi tapmaq
select count(*)  from Products 
select count(*) Say from Products 
select count(*)  from Products where CategoryID=2


select CategoryId,count(*) Say from Products where UnitPrice>20
group by CategoryID having count(*)<10

-- Inner join
select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName
from Products inner join Categories on Products.CategoryID=Categories.CategoryID
where Products.UnitPrice>10

--DTO Data Tranformation object


-- cedvel adinda bosluq olarsa [] arasina almaq lazmdi meselen [Order Details]
--left join
select * from Products p left join [Order Details] od on p.ProductID=od.ProductID

select * from Customers c left join Orders o on c.CustomerId=o.CustomerID
where o.CustomerID is null

--right join
select * from Customers c right join Orders o on c.CustomerId=o.CustomerID

--cox tablo join edersek
select * from Products p inner join [Order Details] od on p.ProductID=od.ProductID
inner join Orders o on o.OrderID=od.OrderID

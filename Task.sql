----------------------Task 1--------------------
use AdventureWorks2019
go
select FirstName,LastName from Person.Person WHERE Title is not null

----------------------Task 2--------------------
select FirstName,LastName from Person.Person WHERE FirstName like '%a%' and LastName like '%a%'

----------------------Task 3--------------------
Select crc.CurrencyCode,c.Name
from Sales.Currency c,Sales.CountryRegionCurrency crc

----------------------Task 4---------------------
create schema HR
go
select * into HR.Dept from HumanResources.Department

----------------------Task 5------------------------
create table studetails
(
SNo int identity(1,1),
FirstName Varchar(50),
LastName Varchar(50),
DateofJoining date,
Department Varchar(30)
)
insert into studetails values('Jayakanthan','S','08/7/2018','IT')
insert into studetails values('Ajay','R','09/7/2018','EEE')
insert into studetails values('Dev','G','06/23/2021','CSE')


select * from studetails
 
---------------------Task 6-----------------------------
Select beadd.BusinessEntityID,beadd.AddressTypeID
from Person.BusinessEntityAddress beadd
inner join HumanResources.department dept
on dept.ModifiedDate=beadd.ModifiedDate

-----------------------Task 7----------------------------

select  distinct GroupName from HumanResources.Department

-----------------------Task 8----------------------------
Select  pch.StandardCost,sum(Pro.ListPrice+Pro.StandardCost) as SumOfListPrice_SC
from Production.ProductCostHistory Pch
join Production.Product pro
on pro.StandardCost=pch.StandardCost group by pch.StandardCost

------------------------Task 9-----------------------------
select DATEDIFF(YEAR,StartDate,EndDate) as YearsOnRole
from
HumanResources.EmployeeDepartmentHistory
 

------------------------Task 10-------------------------------
select Sum(SalesQuota+5000) as tot 
from Sales.SalesPersonQuotaHistory 
where SalesQuota>100000 group by SalesQuota order by SalesQuota asc 

-----------------------Task 11------------------------------------
Select max(TaxRate) as MAX_TaxRate from Sales.SalesTaxRate

-----------------------Task 12-----------------------------------

select DepartmentID,E.BusinessEntityID,ShiftID,BirthDate,FLOOR(DATEDIFF(DAY, BirthDate, GETDATE()) / 365.25) AS AGE
FROM HumanResources.Employee E 
JOIN HumanResources.EmployeeDepartmentHistory EDH ON EDH.BusinessEntityID = E.BusinessEntityID

----------------------------Task 13--------------------------------

CREATE VIEW HumanResources.Name_age
AS 
select DepartmentID,E.BusinessEntityID,ShiftID,BirthDate,FLOOR(DATEDIFF(DAY, BirthDate, GETDATE()) / 365.25) AS AGE
FROM HumanResources.Employee E 
JOIN HumanResources.EmployeeDepartmentHistory EDH ON EDH.BusinessEntityID = E.BusinessEntityID


--------------------------------Task 15---------------------------------

select D.DepartmentID,MAX(EPH.Rate)Rate from HumanResources.Department D
JOIN HumanResources.EmployeeDepartmentHistory EDH ON EDH.DepartmentID = D.DepartmentID
JOIN HumanResources.EmployeePayHistory EPH ON EPH.BusinessEntityID =EDH.BusinessEntityID
GROUP BY D.DepartmentID ORDER BY D.DepartmentID

---------------------------------Task 16----------------------------------

SELECT 
FirstName,MiddleName,Title,AddressTypeID,p.BusinessEntityID
from person.person p
LEFT JOIN person.BusinessEntityAddress BEA ON p.BusinessEntityID =BEA.BusinessEntityID
WHERE p.Title IS NOT NULL


----------------------------------Task 17-------------------------------

Select ProductID,LocationID,Shelf
from Production.ProductInventory where (ProductID between 300 and 350) and (LocationID =50) or (Shelf='E')

-----------------------------------Task18-------------------------------------
SELECT Pint.LocationID,Shelf,Name
FROM Production.ProductInventory Pint 
JOIN Production.Location Ploc
ON 
Pint.LocationID=Ploc.LocationID

--------------------------------------------Task 19--------------------------

Select AddressID,AddressLine1,AddressLine2,stpro.StateProvinceID,StateProvinceCode,CountryRegionCode
from Person.StateProvince stpro
join Person.Address Padd
on
stpro.StateProvinceID=Padd.StateProvinceID

----------------------------------------------Task 20--------------------------
select CRC.CurrencyCode,SUM(SOH.SubTotal+SOH.TaxAmt) As Total
from Sales.SalesOrderHeader SOH
INNER JOIN Sales.SalesTerritory ST ON SOH.TerritoryID = ST.TerritoryID
INNER JOIN Sales.CountryRegionCurrency CRC ON CRC.CountryRegionCode = ST.CountryRegionCode
GROUP BY CurrencyCode
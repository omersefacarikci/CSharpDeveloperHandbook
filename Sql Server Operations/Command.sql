use DBKitap

-- Select Komutu
-- Kullanýmý: Select sütun adý/*(bütün verileri getirir) from TabloAdi 

Select KitapAdi,Yazar from Kitaplar
Select * from Kitaplar

-- Select ile where kullanýmý

Select * from Kitaplar where KitapAdi = 'Dune'
Select * from Kitaplar where KitapAdi = 'Kablolardaki Hayalet' or KitapAdi='KitapAdi'

-- Insert Komutu
-- Kullanýmý: Insert into tabloAdi (kolon1, kolon2) values (value1, value2)

insert into Kitaplar (KitapAdi,Yazar,Sayfa) values ('Kartal','Reþat Nuri Güntekin','345')

-- Update Komutu
-- Kullanýmý: update tabloAdi set kolon1 = value1

update Kitaplar set Sayfa = 345 where KitapAdi = 'Dune'

-- Delete Komutu
-- Kullanýmý: delete from tabloAdi where ..........

delete from Kitaplar where KitapID=4

-- Sum Fonksiyonu
-- Bir tablodaki ilgili sütuna ait deðerlerin toplamýný hesaplayan fonksiyondur.
-- Kullanýmý: select sum(kolonAdi) from tablo

select sum(Fiyat) as Fiyatlar from Kitaplar 

-- Count Fonksiyonu
-- Bir tabloda istenen nitelikte ki deðer kaç adet olduðunu veren komuttur.
-- Kullanýmý: select count(*) from tabloAdi

select COUNT(*) as KitapSayýsý from Kitaplar where Yazar='Tom Hanks'

-------------------------------------------------------------------------------------------

-- Min / Max Fonksiyonu
-- Bir tabloda ilgili sütuna ait deðerler içinde en küçük ve en büyük deðerleri bulan fonksiyondur.
-- select min(kolonAdi) from tabloAdi
-- select max(kolonAdi) from tabloAdi

select MIN(Fiyat) as 'En düþük fiyat' from Kitaplar
select max(Fiyat) as 'En yüksek fiyat' from Kitaplar

-- Avg Fonksiyonu 
-- Bir tabloda ilgili sütuna ait deðerlerin ortalamasýný hesaplayan komuttur.
-- select avg(kolonAdi) from tabloAdi

select AVG(Fiyat) as 'Ortalama' from Kitaplar 

-- Group By
select Yazar,COUNT(*) as 'Kitap Adedi' from Kitaplar
group by Yazar

-- Alt Sorgu
select * from Kitaplar where Fiyat=(select MAX(Fiyat) from Kitaplar)
select * from Kitaplar where Yayinevi=(select ID from Yayinevi where Ad='Mars')
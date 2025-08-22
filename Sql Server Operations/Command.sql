use DBKitap

-- Select Komutu
-- Kullan�m�: Select s�tun ad�/*(b�t�n verileri getirir) from TabloAdi 

Select KitapAdi,Yazar from Kitaplar
Select * from Kitaplar

-- Select ile where kullan�m�

Select * from Kitaplar where KitapAdi = 'Dune'
Select * from Kitaplar where KitapAdi = 'Kablolardaki Hayalet' or KitapAdi='KitapAdi'

-- Insert Komutu
-- Kullan�m�: Insert into tabloAdi (kolon1, kolon2) values (value1, value2)

insert into Kitaplar (KitapAdi,Yazar,Sayfa) values ('Kartal','Re�at Nuri G�ntekin','345')

-- Update Komutu
-- Kullan�m�: update tabloAdi set kolon1 = value1

update Kitaplar set Sayfa = 345 where KitapAdi = 'Dune'

-- Delete Komutu
-- Kullan�m�: delete from tabloAdi where ..........

delete from Kitaplar where KitapID=4

-- Sum Fonksiyonu
-- Bir tablodaki ilgili s�tuna ait de�erlerin toplam�n� hesaplayan fonksiyondur.
-- Kullan�m�: select sum(kolonAdi) from tablo

select sum(Fiyat) as Fiyatlar from Kitaplar 

-- Count Fonksiyonu
-- Bir tabloda istenen nitelikte ki de�er ka� adet oldu�unu veren komuttur.
-- Kullan�m�: select count(*) from tabloAdi

select COUNT(*) as KitapSay�s� from Kitaplar where Yazar='Tom Hanks'

-------------------------------------------------------------------------------------------

-- Min / Max Fonksiyonu
-- Bir tabloda ilgili s�tuna ait de�erler i�inde en k���k ve en b�y�k de�erleri bulan fonksiyondur.
-- select min(kolonAdi) from tabloAdi
-- select max(kolonAdi) from tabloAdi

select MIN(Fiyat) as 'En d���k fiyat' from Kitaplar
select max(Fiyat) as 'En y�ksek fiyat' from Kitaplar

-- Avg Fonksiyonu 
-- Bir tabloda ilgili s�tuna ait de�erlerin ortalamas�n� hesaplayan komuttur.
-- select avg(kolonAdi) from tabloAdi

select AVG(Fiyat) as 'Ortalama' from Kitaplar 

-- Group By
select Yazar,COUNT(*) as 'Kitap Adedi' from Kitaplar
group by Yazar

-- Alt Sorgu
select * from Kitaplar where Fiyat=(select MAX(Fiyat) from Kitaplar)
select * from Kitaplar where Yayinevi=(select ID from Yayinevi where Ad='Mars')
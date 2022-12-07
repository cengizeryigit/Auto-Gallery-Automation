--Sorgu 1 Ara� kiralayan m��teriler
Select Musteri_Tc,Musteri_Adi_Soyadi,Count(Musteri_Adi_Soyadi) AS KiralamaSayisi From Musteri_Tablosu
Inner Join Sozlesme_Tablosu on Musteri_Tablosu.Musteri_Id = Sozlesme_Tablosu.Musteri_Id
Where Sozlesme_Turu_Id=1 
Group By Musteri_Adi_Soyadi, Musteri_Tc
Order By KiralamaSayisi DESC

--Sorgu 2 En�ok ara� kiralayan m��teri
Select MAX(a.KiralamaSayisi) AS En�okkiralama,Musteri_Adi_Soyadi, Musteri_Tc From 
(
Select Musteri_Tc,Musteri_Adi_Soyadi,Count(Musteri_Adi_Soyadi) AS KiralamaSayisi From Musteri_Tablosu
Inner Join Sozlesme_Tablosu on Musteri_Tablosu.Musteri_Id = Sozlesme_Tablosu.Musteri_Id
Where Sozlesme_Turu_Id=1 
Group By Musteri_Adi_Soyadi, Musteri_Tc
) AS a 
Where a.KiralamaSayisi=2 Group By Musteri_Adi_Soyadi, Musteri_Tc

--Sorgu 3 Ara� sat�n alan m��teriler
Select Musteri_Tc,Musteri_Adi_Soyadi,Count(Musteri_Adi_Soyadi) AS Sat�nAlmaSayisi From Musteri_Tablosu
Inner Join Sozlesme_Tablosu on Musteri_Tablosu.Musteri_Id = Sozlesme_Tablosu.Musteri_Id
Where Sozlesme_Turu_Id=2 
Group By Musteri_Adi_Soyadi, Musteri_Tc
Order By Sat�nAlmaSayisi DESC

--Sorgu 4 En �ok Ara� Kiralayan Personel
Select MAX(a.Ara�KiralamaSay�s�) AS Ara�KiralamaSay�s�,a.Personel_Adi_Soyadi,a.Personel_Tc From
(
Select Personel_Tc,Personel_Adi_Soyadi,Count(Personel_Adi_Soyadi) AS Ara�KiralamaSay�s� From Personel_Tablosu
Inner Join Sozlesme_Tablosu on Personel_Tablosu.Personel_Id = Sozlesme_Tablosu.Personel_Id 
Where Sozlesme_Turu_Id=1 
Group By Personel_Tc,Personel_Adi_Soyadi
) AS a Where a.Ara�KiralamaSay�s�=4  Group By a.Personel_Adi_Soyadi,a.Personel_Tc

--Sorgu 5 En �ok Ara� Satan Personel
Select MAX(a.Ara�Sat��Say�s�) AS Ara�Sat��Say�s�,a.Personel_Adi_Soyadi,a.Personel_Tc From
(
Select Personel_Tc,Personel_Adi_Soyadi,Count(Personel_Adi_Soyadi) AS Ara�Sat��Say�s� From Personel_Tablosu
Inner Join Sozlesme_Tablosu on Personel_Tablosu.Personel_Id = Sozlesme_Tablosu.Personel_Id 
Where Sozlesme_Turu_Id=2 
Group By Personel_Tc,Personel_Adi_Soyadi
) AS a Where a.Ara�Sat��Say�s�=2  Group By a.Personel_Adi_Soyadi,a.Personel_Tc

--Sorgu 6 En Az Ara� Kiralayan Personel
Select MIN(a.Ara�KiralamaSay�s�) AS Ara�KiralamaSay�s�,a.Personel_Adi_Soyadi,a.Personel_Tc From
(
Select Personel_Tc,Personel_Adi_Soyadi,Count(Personel_Adi_Soyadi) AS Ara�KiralamaSay�s� From Personel_Tablosu
Inner Join Sozlesme_Tablosu on Personel_Tablosu.Personel_Id = Sozlesme_Tablosu.Personel_Id 
Where Sozlesme_Turu_Id=1 
Group By Personel_Tc,Personel_Adi_Soyadi
) AS a Where a.Ara�KiralamaSay�s�=1  Group By a.Personel_Adi_Soyadi,a.Personel_Tc

--Sorgu 7 En Az Ara� Satan Personel
Select MIN(a.Ara�Sat��Say�s�) AS Ara�Sat��Say�s�,a.Personel_Adi_Soyadi,a.Personel_Tc From
(
Select Personel_Tc,Personel_Adi_Soyadi,Count(Personel_Adi_Soyadi) AS Ara�Sat��Say�s� From Personel_Tablosu
Inner Join Sozlesme_Tablosu on Personel_Tablosu.Personel_Id = Sozlesme_Tablosu.Personel_Id 
Where Sozlesme_Turu_Id=2 
Group By Personel_Tc,Personel_Adi_Soyadi
) AS a Where a.Ara�Sat��Say�s�=1  Group By a.Personel_Adi_Soyadi,a.Personel_Tc
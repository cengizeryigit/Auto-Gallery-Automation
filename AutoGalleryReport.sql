--Sorgu 1 Araç kiralayan müþteriler
Select Musteri_Tc,Musteri_Adi_Soyadi,Count(Musteri_Adi_Soyadi) AS KiralamaSayisi From Musteri_Tablosu
Inner Join Sozlesme_Tablosu on Musteri_Tablosu.Musteri_Id = Sozlesme_Tablosu.Musteri_Id
Where Sozlesme_Turu_Id=1 
Group By Musteri_Adi_Soyadi, Musteri_Tc
Order By KiralamaSayisi DESC

--Sorgu 2 Ençok araç kiralayan müþteri
Select MAX(a.KiralamaSayisi) AS Ençokkiralama,Musteri_Adi_Soyadi, Musteri_Tc From 
(
Select Musteri_Tc,Musteri_Adi_Soyadi,Count(Musteri_Adi_Soyadi) AS KiralamaSayisi From Musteri_Tablosu
Inner Join Sozlesme_Tablosu on Musteri_Tablosu.Musteri_Id = Sozlesme_Tablosu.Musteri_Id
Where Sozlesme_Turu_Id=1 
Group By Musteri_Adi_Soyadi, Musteri_Tc
) AS a 
Where a.KiralamaSayisi=2 Group By Musteri_Adi_Soyadi, Musteri_Tc

--Sorgu 3 Araç satýn alan müþteriler
Select Musteri_Tc,Musteri_Adi_Soyadi,Count(Musteri_Adi_Soyadi) AS SatýnAlmaSayisi From Musteri_Tablosu
Inner Join Sozlesme_Tablosu on Musteri_Tablosu.Musteri_Id = Sozlesme_Tablosu.Musteri_Id
Where Sozlesme_Turu_Id=2 
Group By Musteri_Adi_Soyadi, Musteri_Tc
Order By SatýnAlmaSayisi DESC

--Sorgu 4 En Çok Araç Kiralayan Personel
Select MAX(a.AraçKiralamaSayýsý) AS AraçKiralamaSayýsý,a.Personel_Adi_Soyadi,a.Personel_Tc From
(
Select Personel_Tc,Personel_Adi_Soyadi,Count(Personel_Adi_Soyadi) AS AraçKiralamaSayýsý From Personel_Tablosu
Inner Join Sozlesme_Tablosu on Personel_Tablosu.Personel_Id = Sozlesme_Tablosu.Personel_Id 
Where Sozlesme_Turu_Id=1 
Group By Personel_Tc,Personel_Adi_Soyadi
) AS a Where a.AraçKiralamaSayýsý=4  Group By a.Personel_Adi_Soyadi,a.Personel_Tc

--Sorgu 5 En Çok Araç Satan Personel
Select MAX(a.AraçSatýþSayýsý) AS AraçSatýþSayýsý,a.Personel_Adi_Soyadi,a.Personel_Tc From
(
Select Personel_Tc,Personel_Adi_Soyadi,Count(Personel_Adi_Soyadi) AS AraçSatýþSayýsý From Personel_Tablosu
Inner Join Sozlesme_Tablosu on Personel_Tablosu.Personel_Id = Sozlesme_Tablosu.Personel_Id 
Where Sozlesme_Turu_Id=2 
Group By Personel_Tc,Personel_Adi_Soyadi
) AS a Where a.AraçSatýþSayýsý=2  Group By a.Personel_Adi_Soyadi,a.Personel_Tc

--Sorgu 6 En Az Araç Kiralayan Personel
Select MIN(a.AraçKiralamaSayýsý) AS AraçKiralamaSayýsý,a.Personel_Adi_Soyadi,a.Personel_Tc From
(
Select Personel_Tc,Personel_Adi_Soyadi,Count(Personel_Adi_Soyadi) AS AraçKiralamaSayýsý From Personel_Tablosu
Inner Join Sozlesme_Tablosu on Personel_Tablosu.Personel_Id = Sozlesme_Tablosu.Personel_Id 
Where Sozlesme_Turu_Id=1 
Group By Personel_Tc,Personel_Adi_Soyadi
) AS a Where a.AraçKiralamaSayýsý=1  Group By a.Personel_Adi_Soyadi,a.Personel_Tc

--Sorgu 7 En Az Araç Satan Personel
Select MIN(a.AraçSatýþSayýsý) AS AraçSatýþSayýsý,a.Personel_Adi_Soyadi,a.Personel_Tc From
(
Select Personel_Tc,Personel_Adi_Soyadi,Count(Personel_Adi_Soyadi) AS AraçSatýþSayýsý From Personel_Tablosu
Inner Join Sozlesme_Tablosu on Personel_Tablosu.Personel_Id = Sozlesme_Tablosu.Personel_Id 
Where Sozlesme_Turu_Id=2 
Group By Personel_Tc,Personel_Adi_Soyadi
) AS a Where a.AraçSatýþSayýsý=1  Group By a.Personel_Adi_Soyadi,a.Personel_Tc
/*
Soru: Klavyeden girilen dairenin yarıçap uzunluğuna göre
alanını ve çevresini hesaplayıp sonucu
ekranda gösteren uygulama

1.Aşama = Klavyeden değer oku
2.Aşama = İşlem Yap
3.Aşama = Sonuçları göster
*/

const double pi = 3.14;//const sonradan değişkenin değerinin değişmeyeceğini belirtir
//1.Aşama
Console.Write("Dairenin yarı çapını gir:");
double r = Convert.ToDouble(Console.ReadLine());

//pi = 0; burada hata alırız çünkü pi sabit

//2.Aşama
double alan = pi * r * r;
double cevre = 2 * pi * r;

//3.Aşama
Console.WriteLine($"Yarıçapı {r} olan Dairenin Alanı = {alan:f2}");
Console.WriteLine($"Yarıçapı {r} olan Dairenin Çevresi = {cevre:f2}");

/*
Console.Write("1.Öğrencinin Ortalamasını Gir:");
double ogrOrt1 = Convert.ToDouble(Console.ReadLine());
Console.Write("2.Öğrencinin Ortalamasını Gir:");
double ogrOrt2 = Convert.ToDouble(Console.ReadLine());
Console.Write("3.Öğrencinin Ortalamasını Gir:");
double ogrOrt3 = Convert.ToDouble(Console.ReadLine());
//...
Console.Write("10.Öğrencinin Ortalamasını Gir:");
double ogrOrt10 = Convert.ToDouble(Console.ReadLine());
*/
double toplamlar = 0;//döngü öncesinde dışında
int ogrSayisi = 10;
for(int i = 1; i <= ogrSayisi; i++)
{
    Console.Write($"{i}.Öğrencinin Ortalamasını Gir:");
    double ogrOrt = Convert.ToDouble(Console.ReadLine());
    toplamlar+=ogrOrt;//üzerine ekle
}

//döngü dışı
Console.WriteLine($"Genel Ortalama:{toplamlar/ogrSayisi}");

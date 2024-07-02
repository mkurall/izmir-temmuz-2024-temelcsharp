
void BilgiVer()//imza (başlık)
{   //gövde
    Console.WriteLine("Bu uygulama BTKAKADEMİ C# Kursunda Yazıldı.");
}
void Bekle()
{
    Console.WriteLine("Uygulamayı sonlandırmak için bir tuşa basın...");
    Console.ReadKey();
}
int Oku(string mesaj)
{
    Console.Write(mesaj);
    int sayi = Convert.ToInt32(Console.ReadLine());
    return sayi;
}
int Islem(int a, int b)
{
    int sonuc = a + b;
    return sonuc;
}

//ANAPROGRAM BOLUMU
BilgiVer();//metodu çağırdık

int s1 = Oku("1.Sayıyı Gir:");
int s2 = Oku("2.Sayıyı Gir:");

int sonuc = Islem(s1, s2);

Console.WriteLine($"İşlem Sonucu = {sonuc}");
Bekle();
//ANAPROGRAM SONU



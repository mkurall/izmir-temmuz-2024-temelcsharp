int topla(params int[] sayilar)//değişken sayıda parametre
{
    int toplam = 0;
    for (int i = 0;i<sayilar.Length;i++)
       toplam+=sayilar[i];
    return toplam;
}

void artir(ref int x)//a geldi
{
    x++;
}

void sayiTut(out int s)
{
    s = new Random().Next(1, 100);
}

void selam(string ad, string soyad, int yas)
{
    Console.WriteLine($"Merhaba, {ad} {soyad}, yaşınız {yas}");
}


Console.WriteLine($"Dizinin Toplamı:{topla(2,3,6,9)}");

int a = 5, b = 3;
int r;

artir(ref a);

sayiTut(out r);

Console.WriteLine($"a değeri:{a}");
Console.WriteLine($"r değeri:{r}");

selam(soyad:"KURAL",yas:43, ad:"Mustafa");

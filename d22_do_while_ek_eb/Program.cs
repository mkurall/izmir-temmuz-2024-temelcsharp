/*
Klavyeden 0 girilinceye kadar okunan sayılardan
en küçük ve en büyük olanı döngü sonunda ekrana
yazan uygulama
sayı  -> klavyeden girilen
ek    -> en küçük girilen
eb    -< en büyük girilen
*/
int sayi;
int eb = int.MinValue; //tanımlama
int ek = int.MaxValue; //girlebilecek en küçük ihtimalden daha küçük olmalı

do
{
    Console.Write("Bir sayı girin:");
    sayi = Convert.ToInt32(Console.ReadLine());

    if(sayi != 0)
    {
        if(sayi<ek) //ek kullanılmadan önce yukarda başlangıç değeri ata
            ek = sayi;

        if(sayi > eb)//kullanılan yer
            eb = sayi;
    }

} while(sayi!=0);


Console.WriteLine($"En küçük: {ek} En büyük:{eb}");
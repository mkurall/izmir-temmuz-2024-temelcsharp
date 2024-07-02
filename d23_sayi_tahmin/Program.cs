//rasgele 1-100 arasında sayı üretir
int rasgele = new Random().Next(1,100);
int hak = 5;
while(true)
{
    Console.Write($"Tahminiz nedir? (Kalan Hak = {hak})");
    int tahmin = Convert.ToInt32(Console.ReadLine());
    hak--;//bir hakkım gitti

    if(tahmin == rasgele)
    {
        Console.WriteLine("TEBRİKLER BİLDİNİZ!");
        break;
    } 
    else
    {
        if(hak==0)
        {
            Console.WriteLine($"ÜZGÜNÜM BİLEMEDİN! Sayı:{rasgele}");
            break;
        }

        if(rasgele > tahmin)
        {
            Console.WriteLine("Bilemedin. Daha Yüksek!");
        }
        else
        {
            Console.WriteLine("Bilemedin. Daha Küçük!");
        }
    }
}

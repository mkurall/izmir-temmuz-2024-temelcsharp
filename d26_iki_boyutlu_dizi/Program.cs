char[,] karakterler = {
    {'A','H','C','E'},
    {'R','A','C','E'},
    {'B','C','H','C'},
};

int boyut = karakterler.Rank;
int satSay = karakterler.GetLength(0);
int sutSay  = karakterler.GetLength(1);

Console.WriteLine($"Boyut: {boyut}");
Console.WriteLine($"Satırlar: {satSay}");
Console.WriteLine($"Sütunlar: {sutSay}");

char ara = 'C';
int sayi = 0;

for(int sat = 0; sat<satSay;sat++)
{
    for (int sut = 0; sut < sutSay; sut++)
    {
        if(ara == karakterler[sat, sut])
          sayi++;
    }
}


Console.WriteLine($"Bulunan '{ara}' sayısı: {sayi}");
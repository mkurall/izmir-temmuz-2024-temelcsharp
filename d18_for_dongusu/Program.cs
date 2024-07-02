for(int i = 1; i <= 5; i++)
{
    Console.WriteLine($"{i}.Gün");
}

for(int i = 5; i >= 0; i--)
{
    Console.WriteLine($"{i} Gün Kaldı");
}

for(int i = 0; i >= 10; i+=2)
    Console.WriteLine(i); //tek satır kodlarda blok oluşturmaya gerek yok


//for(;;) {}//Sonsuz Döngü
int a=3;//for bloğunun dışı
for(;a<11;)
{
   Console.WriteLine($"a = {a}");
   a++; 
}

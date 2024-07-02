/*
Kullanıcının boyuna (cm) ve kilosuna(kg) göre vücut kitle indeksini(vki)
hesaplayıp ekrana yazan ve buna göre --formül vki = kg/m2
Zayıf(<18.5), Normal(18.5<vki<25), Kilolu(25<vki<30), Çok Kilolu(>30) olma durumunu ekrana yazan uygulama
*/
Console.Write("Boyunuz (cm)");
double boy = Convert.ToDouble(Console.ReadLine())/100;//metre
Console.Write("Kilonuzu girin(kg):");
double kilo = Convert.ToDouble(Console.ReadLine());

double vki = kilo/(boy*boy);

Console.WriteLine($"Boyu {boy}m olan ve Kilosu {kilo}kg olan kişinin Vki:{vki}");
/*
if(vki<18.5)
{
    Console.WriteLine("ZAYIF");
}
else if(vki>=18.5 && vki<25)
{
    Console.Write("NORMAL");
}
else if(vki>=25 && vki<30)
{
    Console.Write("KİLOLU");
}
else if(vki>=30)
{
    Console.Write("ÇOK KİLOLU");
}
*/
if(vki<18.5)
{
    Console.WriteLine("ZAYIF");
}
else if(vki<25)
{
    Console.Write("NORMAL");
}
else if(vki<30)
{
    Console.Write("KİLOLU");
}
else
{
    Console.Write("ÇOK KİLOLU");
}
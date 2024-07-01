byte a = 189;
int b = 257;
string sayi = "1234";//metin

byte c = (byte)b;//Açık Dönüşüm  byte <- int
int d = a;//Örtük dönüşüm  int <- byte
int s = Convert.ToInt32(sayi);//int <- ToInt32(string)

//+ metin ile birleştir
Console.WriteLine("a'nın değeri:" + a);//189
Console.WriteLine("b'nin değeri:" + b);//2024
Console.WriteLine("sayi'nin değeri:" + sayi);//1234

Console.WriteLine("c'nın değeri:" + c);//??
Console.WriteLine("d'nın değeri:" + d);//189
Console.WriteLine("s'nın değeri:" + s);//1234




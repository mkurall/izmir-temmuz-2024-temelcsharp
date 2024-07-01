Console.WriteLine("Bu uygulama klavyeden " + 
"girilen iki tam sayıyı toplar");

Console.Write("1.Sayıyı Girin:");
var s1 = Console.ReadLine();

Console.Write("2.Sayıyı Girin:");
var s2 = Console.ReadLine();

int sayi1 = Convert.ToInt32(s1);//elimde artık sayı var
int sayi2 = Convert.ToInt32(s2);//elimde artık sayı var
//+ karakteri metinler üzerrinde birleştirme yapar
//+ karakteri sayılar üzerinde toplama yapar
//Console.WriteLine("Sayıların Toplamı = " + (sayi1 + sayi2));
int toplam = sayi1 + sayi2;
Console.WriteLine("Sayıların Toplamı = " + toplam);

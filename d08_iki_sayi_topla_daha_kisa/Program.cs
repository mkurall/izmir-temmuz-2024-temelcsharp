Console.WriteLine("Bu uygulama klavyeden " + 
"girilen iki tam sayıyı toplar");

Console.Write("1.Sayıyı Girin:");
var s1 = Convert.ToInt32(Console.ReadLine());//  int <- ToInt32(string)

Console.Write("2.Sayıyı Girin:");
var s2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Sayıların Toplamı = " + (s1 + s2));
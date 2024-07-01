Console.Write("Adınızı girin:");
var ad = Console.ReadLine();
Console.Write("Soyadınızı girin:");
var soyad = Console.ReadLine();

Console.Write("Cinsiyetinizi girin[E/K]:");
var cinsiyet = Console.ReadLine();
Console.Write("Doğum yılınızı girin:");
var dogumYili = Convert.ToInt32(Console.ReadLine());//------int
Console.Write("Kilonuzu girin:");
var kilo = Convert.ToDouble(Console.ReadLine());//----------double
Console.Write("Boyunuzu girin:");
var boy = Convert.ToDouble(Console.ReadLine());//-----------double

Console.WriteLine("\\Kişisel \"Size Özel\" Bilgileriniz\n--------------------------------");//\n bir alt satıra geç
Console.WriteLine($"Ad Soyad     : {ad} {soyad}");//string interpolation
Console.WriteLine($"Cinsiyetiniz : {cinsiyet}");//string interpolation
Console.WriteLine($"Doğum Yılınız: {dogumYili}");//string interpolation
Console.WriteLine($"Yaşınız      : {2024 - dogumYili}");//string interpolation
Console.WriteLine($"Kilonuz      : {kilo,10:f2}");//string interpolation
Console.WriteLine($"Boyunuz      : {boy,10:f2}");//string interpolation

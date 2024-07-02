string pinKodu = "1234";
string okunanPinKodu = "";//değer atamamız gerek

//Kullanıcı pin kodunu girmeye başlayacak
while(pinKodu!=okunanPinKodu)//farklı olduğu sürece
{
    Console.WriteLine("Pin Kodunu Gir:");
    okunanPinKodu = Console.ReadLine();
}
//1234 != 1234 = False
Console.WriteLine("TEBRİKLER GİRİŞ BAŞARILI!");


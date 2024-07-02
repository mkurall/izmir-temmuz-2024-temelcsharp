Console.Write("Yaşınızı girin:");
byte yas = Convert.ToByte(Console.ReadLine());
Console.Write("Cinsiyetinizi Girin(e/k):");
char cinsiyet = Convert.ToChar(Console.ReadLine());
Console.Write("Sağlık Özrünüz Var Mı(e/h):");
char saglikOzru = Convert.ToChar(Console.ReadLine());

//A Noktası

if(yas>=20 && (cinsiyet=='e' || cinsiyet == 'E') && saglikOzru == 'h')//true yada false
{
    Console.WriteLine("ASKERE GİDEBİLİRSİNİZ.");
}
else
{
    Console.WriteLine("ASKERLİK İÇİN UYGUN DEĞİLSİNİZ.");
}

//B Noktası
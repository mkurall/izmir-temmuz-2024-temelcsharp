Console.Write("Cinsiyetiniz(e/k):");
char cinsiyet = Convert.ToChar(Console.ReadLine());

if(cinsiyet == 'e' || cinsiyet == 'E')
{
    Console.Write("Yaşınız:");
    byte yas = Convert.ToByte(Console.ReadLine());

    if(yas>20)
    {
        Console.Write("Sağlık Özrü Var Mı(e/h):");
        char saglikOzru = Convert.ToChar(Console.ReadLine());

        if(!(saglikOzru == 'e' || saglikOzru == 'E'))//e veya E değilse!
        {
            Console.Write("ASKERE GİDEBİLİRSİNİZ");
        }
        else Console.Write("SAĞLIK ÖZRÜNDEN DOLAYI ASKERE GİDEMEZSİNİZ.");
    }
    else Console.Write("YAŞINIZDAN DOLAYI ASKERE GİDEMEZSİNİZ");
}
else Console.Write("CİNSİYETİNİZDEN DOLAYI ASKERE GİDEMZSİNİZ");

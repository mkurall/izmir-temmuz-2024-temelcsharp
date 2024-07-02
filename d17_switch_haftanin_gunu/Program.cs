Console.Write("Haftanın Kaçıncı günü:");
int gunNo = Convert.ToInt32(Console.ReadLine());

//1-PZT, 2-SAL 3-ÇRŞ......7-PZR
/*
if(gunNo == 1)
    Console.Write("PAZARTESİ");
else if(gunNo == 2)
    Console.Write("SALI");
else if(gunNo == 3)
    Console.Write("ÇARŞAMBA");
else if(gunNo == 4)
    Console.Write("PERŞEMBE");
else if(gunNo == 5)
    Console.Write("CUMA");
else if(gunNo == 6)
    Console.Write("CUMARTESİ");
else if(gunNo == 7)
    Console.Write("PAZAR");
else 
    Console.Write("HATALI GÜN!");
*/

switch(gunNo)
{
    case 1:
        Console.Write("PAZARTESİ");
    break;
    case 2:Console.Write("SALI");break;
    case 3:Console.Write("ÇARŞAMBA");break;
    case 4:Console.Write("PERŞEMBE");break;
    case 5:Console.Write("CUMA");break;
    case 6:Console.Write("CUMARTESİ");break;
    case 7:Console.Write("PAZAR");break;
    default:Console.Write("HATALI GÜN!");break;
}

switch(gunNo)
{
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
    Console.WriteLine("HAFTA İÇİ");break;
    case 6:
    case 7:
    Console.WriteLine("HAFTA SONU");break;
    default : Console.WriteLine("HATALI GÜN!");break;
}



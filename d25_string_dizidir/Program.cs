string bilgi = "BTK AKADEMİ C# İzmir Yaz Eğitim";
//char[] bilgi2 = {'B','T','K'};

int uzunluk = bilgi.Length;

for(int i = uzunluk-1;i>=0;i--)
    Console.Write($"{bilgi[i]}");


string[] sehirler = {
    "İzmir",
    "İstanbul",
    "Ankara",
    "Manisa",
    "Aydın",
};

Console.WriteLine(sehirler[2]);
sehirler[4] = "Denizli";
int elemanSayisi = sehirler.Length;
Console.WriteLine($"Eleman Sayisi: {elemanSayisi}");
Console.WriteLine($"Ilk eleman: {sehirler[0]}");
Console.WriteLine($"Son eleman: {sehirler[elemanSayisi-1]}");

Console.WriteLine("Tüm Elamanlar");
for (int i = 0; i < elemanSayisi;i++)
{
    //i.indeksteki elemanı yazdır
    Console.WriteLine($"{sehirler[i]}");
}

/*
Klavyeden girilen 2 vize ve 1 final notuna göre
vizelerin %40'ı ve Finalin ise %60 ını alarak ortalamayı hesaplayan
ortaamayı ekrana ondalıklı kısmı 2 basamak olacak şekilde yazdıran
ortalamaya göre ekrana Başarı Durumunu: True veya False olarak yazdıran uygulama
*/
Console.Write("1.Vize:");
int v1 = int.Parse(Console.ReadLine());
Console.Write("2.Vize:");
int v2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Final:");
int final = Convert.ToInt32(Console.ReadLine());

double ort = v1 * 0.20 + v2 * 0.20 + final * 0.60;
bool durum = ort >= 70;

Console.WriteLine($"Ortalamanız: {ort:f2}");
Console.WriteLine($"Başarı Durumunuz:{durum}");
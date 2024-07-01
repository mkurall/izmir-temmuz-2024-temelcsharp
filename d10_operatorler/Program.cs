int a = 5, b = 3;
Console.WriteLine($"a = {a} b = {b}");
Console.WriteLine($"a + b = {a + b}");
Console.WriteLine($"a - b = {a - b}");
Console.WriteLine($"a * b = {a * b}");
Console.WriteLine($"a / b = {a / b}");
Console.WriteLine($"a % b = {a % b}");
Console.WriteLine($"a++ = {++a}");//++ öncesinde ise değerini 1 artır sonra kullan
Console.WriteLine($"b-- = {--b}");//-- sonrasında ise önce değişkeni kullanır sonra eksiltir

Console.WriteLine($"a == b = {a == b}");
Console.WriteLine($"a > b = {a > b}");
Console.WriteLine($"a != b = {a != b}");

Console.WriteLine($"True && False = {true && false}");
Console.WriteLine($"True && True = {true && true}");
Console.WriteLine($"True || False = {true || false}");
Console.WriteLine($"True || True = {true || true}");
Console.WriteLine($"!True = {!true}");

Console.WriteLine($"a<<2 = {a << 2}");//a nın değeri deişmedi aslında
Console.WriteLine($"b>>2 = {b >> 1}");//b nın değeri deişmedi aslında
Console.WriteLine($"~b = {~b}");

Console.WriteLine($"a+=b ==> a = {a+=b}");//a nın üzerine b yi ekle 
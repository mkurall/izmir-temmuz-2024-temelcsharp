//
void Say(int bas, int son, int art=1)
{
    if(bas<son)
        for (int i = bas; i<son;i+=art)
        Console.Write($"{i}, ");
    else
        for (int i = bas; i>son;i+=art)
        Console.Write($"{i}, ");

    Console.WriteLine();
}

Say(50,3,-2);//3, 5, 7
Say(4,15);//4, 5, 6,
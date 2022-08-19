void DZ1() 
{
Console.WriteLine("64. Введите первое число:");
int numa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");
int co = numb;
string Rec(int co, int numb) 
{
    while(co>numa) 
    {
        co--;
        if (co % 3 ==0) 
        {
            Console.Write(co + "\t");
            return Rec(co,numb);
        }
    }
    //Console.WriteLine(Rec(co,numb));
    return $"{co}";
}
Console.WriteLine(Rec(co,numb));
}

void DZ2() 
{
Console.WriteLine("66. Введите первое число:");
int numa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numb = Convert.ToInt32(Console.ReadLine());
string Rec(int numb, int sum = 0) 
{
    while(numb>numa) 
    {
        Console.Write(numb + " + ");
        numb--;
        sum+=numb;
        return Rec(numb,sum);
    }
    return $"{sum}";
}
Console.Write("\b\b = " + Rec(numb));
}
Console.WriteLine(" ");

DZ1();
DZ2();
//DZ3();
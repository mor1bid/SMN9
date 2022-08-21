void DZ1() 
{
Console.WriteLine("64. Введите первое число:");
int numa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numb = Convert.ToInt32(Console.ReadLine());
int co = numb;
string Rec(int co, int numb) 
{
    while(co>numa) 
    {
        co--;
        if (co % 3 ==0 && co!=numa) 
        {
            Console.Write(co + "\t");
            return Rec(co,numb);
        }
    }
    return $"{co}";
}
Console.WriteLine(Rec(co,numb));
}
Console.WriteLine(" ");

void DZ2() 
{
Console.WriteLine("66. Введите первое число:");
int numa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numb = Convert.ToInt32(Console.ReadLine());
string Rec(int numb, int sum = 0) 
{
    while(numb>numa+1) 
    {
        numb--;
        Console.Write(numb + " + ");
        sum+=numb;
        return Rec(numb,sum);
    }
    return $"{sum}";
}
Console.Write("\b\b= " + Rec(numb));
}
Console.WriteLine(" ");

void DZ3() 
{
//Console.WriteLine("66. Введите первое число:");
int numa = 3;
//Console.WriteLine("Введите второе число: ");
int numb = 2;
//int res = 0;
double A(double numa, double numb, double res = 0) 
{
    if(numa>0) 
    {
        numb +=1;
        return numb;
    }
    if (numb>0)
    {
        //numa = Math.Pow(numa-1, 1);
        res = A(numa-1, 1);
        return A(numa,res); 
    }
    else 
    { 
        res = A(numa-1,A(numa,numb-1)); 
        return A(numa,numb,res); 
    }
    //return res;
}
Console.Write(A(numa,numb));
}
Console.WriteLine(" ");

//DZ1();
//DZ2();
DZ3();
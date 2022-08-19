void Z3() 
{
Console.WriteLine("67. Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
//int sum = 0;
int Rec(int num, int sum = 0)
{
    if(num!=0)
    {
        sum+=num%10;
        num/=10;
        return Rec(num, sum);
    }
    else return sum;
}
Console.WriteLine(num + " = " + Rec(num));
}
//Z3();

void Z4() 
{
Console.WriteLine("67. Введите первое число:");
int numa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int numb = Convert.ToInt32(Console.ReadLine());
int i = 1;
int Rec(int numa, int numb)
{
    while (i<numb) 
    { 
        numa*=numb; 
        i++; 
        return Rec(numa,numb); 
    }
    return numa;

}
Console.WriteLine(numa + " в степени " + numb + " = " + Rec(numa,numb));
}
Console.WriteLine(" ");
//Z4();

void DZ1() 
{
Console.WriteLine("64. Введите первое число:");
int numa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");
int co = numb;
int Rec(int co, int numb) 
{
    while(co>numa) 
    {
        co--;
        if (co % 3 ==0) 
        {
            //Console.Write(co + " ");
            //Console.WriteLine(Rec(co,numb));
            return Rec(co,numb);
        }
    }
    return co;
}
Console.WriteLine(Rec(co,numb));
}
//DZ1();

void DZ2() 
{
Console.WriteLine("66. Введите первое число:");
int numa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numb = Convert.ToInt32(Console.ReadLine());
int Rec(int numb, int sum = 0) 
{
    while(numb>numa+1) 
    {
        numb--;
        Console.Write(numb + " + ");
        sum+=numb;
        return Rec(numb,sum);
    }
    return sum;
}
Console.Write("=" + Rec(numb));
}
Console.WriteLine(" ");
DZ2();
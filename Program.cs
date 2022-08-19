void Z0() 
{
Console.WriteLine("63.-65. Введите первое число:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int n = Convert.ToInt32(Console.ReadLine());
void Rec(int num, int co )
{
    if(co>num) return;
    Console.WriteLine(co);
    co++;
    Rec(num,co);
}
}
//Z0();

void Z12() 
{
Console.WriteLine("63.-65. Введите первое число:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int n = Convert.ToInt32(Console.ReadLine());
string Rec(int a, int b )
{
    if(a<=b) return $"{a} " + Rec(a+1, b);
    else return String.Empty;
}
Console.WriteLine(Rec(m,n));
}
//Z12();

void Z3() 
{
Console.WriteLine("67. Введите первое число:");
int numa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numb = Convert.ToInt32(Console.ReadLine());
int co = numb;
int Rec(int co, int numb) 
{
    while(co>=numa) 
    {
        co--;
        if (co % 3 ==0) 
        {
            Console.Write(co + " ");
            return Rec(co,numb);
        }
        return co;
    }
}
//Console.WriteLine(Rec(co,numb));
}
Z3();
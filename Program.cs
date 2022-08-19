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
    Rec(m,n);
}
}
Z0();

void Z12() 
{
Console.WriteLine("63.-65. Введите первое число:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int n = Convert.ToInt32(Console.ReadLine());
string Rec(int a, int b )
{
    if(a<=b) return $"{a}" + Rec(a+1, b);
    else return String.Empty;
}
Console.WriteLine(Rec(m,n));
}
//Z12();

void Z3() 
{
Console.WriteLine("67. Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
string Rec(int num) 
{
    if(num>0) return $"{num%10}"+ Rec(sum+num);
    else return string.Empty;
}
Console.WriteLine(Rec(sum));
}
//Z3();
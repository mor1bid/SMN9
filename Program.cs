void Z0() 
{
string Rec(int a, int b )
{
    if(a<=b) return $"{a}" + Rec(a+1, b);
    else return String.Empty;
}
Console.WriteLine(Rec(1,10));
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
string Rec(int sum) 
{
    if(num>=0) return $"{num%10}"+ Rec(sum+num);
    else return string.Empty;
}
Console.WriteLine(Rec(sum));
}
Z3();
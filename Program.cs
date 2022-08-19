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

void Z1() 
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
Z1();
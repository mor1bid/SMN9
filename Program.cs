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
Console.WriteLine("67. Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
int num = n;
int sum = 0;
while(num!=0)
{
    num%=10;
    sum+=num;
}
Console.WriteLine(n + " = " + sum);
// string Rec(int num, int co) 
// {
//     if(num>0) return $"{sum} "+ Rec(sum+(num%10), co);
//     else return string.Empty;
// }
// Console.WriteLine(Rec(sum, 0));
}
Z3();
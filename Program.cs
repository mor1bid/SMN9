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
Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
string Rec(int a, int b )
{
    if(a<=b) return $"{a}" + Rec(a+1, b);
    else return String.Empty;
}
Console.WriteLine("");
Console.WriteLine(Rec(1,n));
}
Z1();
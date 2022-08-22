void DZ1() 
{
Console.WriteLine("64. Введите 1-е число:");
int numa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число: ");
int numb = Convert.ToInt32(Console.ReadLine());
int co = numa;
Console.WriteLine("Числа, лежащие в заданном промежутке: ");
string Rec(int co, int numb) 
{
    while(co<numb || co>numb) 
    {
        if (co%3==0) 
        {
            Console.Write(co + "\t");
        }
        if (numa<numb) co++;
        else if (numa>numb) co--;
    }
    if (co%3!=0) Console.WriteLine("В данном промежутке нет чисел, кратных числу 3!");
    return $"{co}";
}
Console.WriteLine(Rec(co,numb));
}
Console.WriteLine(" ");

void DZ2() 
{
Console.WriteLine("66. Введите 1-е число:");
int numa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число: ");
int numb = Convert.ToInt32(Console.ReadLine());
string Rec(int numb, int sum = 0) 
{
    while(numb>numa+1 || numa>numb+1)  
    {
        if (numa<numb) numa++;
        else if (numa>numb) numa--;
        Console.Write(numa + " + ");
        sum+=numa;
    }
    return $"{sum}";
}
Console.Write("\b\b= " + Rec(numb));
}
Console.WriteLine(" ");

void DZ3() 
{
Console.WriteLine(" ");
Console.WriteLine("68. Введите 1-е число:");
int numa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число: ");
int numb = Convert.ToInt32(Console.ReadLine());
double A(double numa, double numb) 
{
    if(numa==0) 
    {
        numb +=1;
        return numb;
    }
    if (numa > 0 && numb==0)
    {
        numa = (A(numa-1, 1));
        return numa; 
    }
    if (numa>0 && numb>0) 
    { 
        numa = A(numa-1,A(numa,numb-1)); 
        return numa; 
    }
    return A(numa,numb);
}
Console.Write("A(" + numa + "," + numb + ") = ");
Console.Write(A(numa,numb));
}
Console.WriteLine(" ");

DZ1();
DZ2();
DZ3();
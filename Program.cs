﻿void DZ1() 
{
Console.WriteLine("64. Введите 1-е число:");
int numa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число: ");
int numb = Convert.ToInt32(Console.ReadLine());
int co = numb;
Console.WriteLine("Числа, лежащие в заданном промежутке: ");
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
Console.WriteLine("66. Введите 1-е число:");
int numa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число: ");
int numb = Convert.ToInt32(Console.ReadLine());
string Rec(int numb, int sum = 0) 
{
    if (numa<numb)
    {
        while(numb>numa+1) 
        {
            numb--;
            Console.Write(numb + " + ");
            sum+=numb;
            return Rec(numb,sum);
        }
    }
    if (numa>numb)
    {
        while(numa>numb+1) 
        {
            numb++;
            Console.Write(numb + " + ");
            sum+=numb;
            return Rec(numb,sum);
        }
        //Console.WriteLine("Заданы некорректные значения границ.");
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
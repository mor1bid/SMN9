void DZ1() 
{
    Console.WriteLine("64. Введите делитель: ");
int nummlt = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 1-е число:");
int numa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число: ");
int numb = Convert.ToInt32(Console.ReadLine());
int co = numa;
Console.WriteLine("Числа, лежащие в заданном промежутке и кратные числу " + nummlt + ": ");
string Rec(int co) 
{
    if(co<numb || co>numb) 
    {
        if (co%nummlt==0) 
        {
            Console.Write(co + "\t");
        }
        if (numa<numb) co++;
        else if (numa>numb) co--;
        return Rec(co);
    }
    else if (numb%nummlt==0) 
    { 
        Console.Write(numb + "\t");;
        return String.Empty;
    }
    else if (numa%nummlt==0) 
    {
        Console.Write(numa + "\t");;
        return String.Empty;
    }
    else return String.Empty;
}
Console.WriteLine(Rec(co));
}
Console.WriteLine(" ");

void DZ2() 
{
Console.WriteLine("66. Введите 1-е число:");
int numa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число: ");
int numb = Convert.ToInt32(Console.ReadLine());
string Rec(int numa, int sum = 0) 
{
    if(numb>numa || numa>numb)  
    {
        Console.Write(numa + " + ");
        sum+=numa;
        if (numa<numb) numa++;
        else if (numa>numb) numa--;
        return Rec(numa,sum);
    }
    else
    {
        Console.Write(numa + " + ");
        sum+=numa;
        return $"{sum}";
    }
}
Console.Write("\b\b= " + Rec(numa));
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
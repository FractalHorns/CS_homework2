/*void GetDiapazon(int quadrant)
{
    if(quadrant == 1) Console.WriteLine("x > 0, y > 0");
    else if(quadrant == 2) Console.WriteLine("x < 0, y > 0");
    else if(quadrant == 3) Console.WriteLine("x < 0, y < 0");
    else if(quadrant == 4) Console.WriteLine("x > 0, y < 0");
    else Console.WriteLine("NaN");
}

Console.Write("Input a number of quadrant: ");
int quadNum = Convert.ToInt32(Console.ReadLine());

GetDiapazon(quadNum);
*/
//             H O M E W O R K 06.01.2023 !
//Задача 21
 /*    
Double x1=0;
Double x2=0;
Double y1=0;
Double y2=0;
Double z1=0; 
Double z2=0;
Double d=0;
Console.Write("x1=");
x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("x2=");
x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("y1=");
y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("y2=");
y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("z1=");
z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("x2=");
z2 = Convert.ToDouble(Console.ReadLine());

d = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
d = Math.Round(d, 2);
Console.WriteLine(d);
*/

//Задача 23
/*
int a = 0;
int i = 1;
Console.Write("enter a: ");
a = Convert.ToInt32(Console.ReadLine());

while (i <= a)
{
    //Math.Pow(i, 3);
    
    Console.WriteLine(Math.Pow(i, 3));
    i++;
}
*/
//Задача 19  
//не получается запустить программу, выдает ошибки. 
//Решение само по себе верное
bool Transform(int num)
{  
    if ((num / 10000) == (num % 10)) & ((num / 1000) == (num % 100));
        return true;

    else   
        return false;
}


Console.Write("Введите 5-ти значное число: ");
num = Convert.ToInt32(Console.ReadLine());

Transform(num);

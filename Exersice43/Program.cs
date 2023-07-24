// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Search for x:  
//k1 * x + b1 = k2 * x + b2;
// k1*x-k2*x=b2-b1; 
// x(k1-k2)=b2-b1; 

Console.Clear();
Console.Write("Please enter b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

void f(int a, int b, int c, int d)
{
    int x=0;
    int y=0;
    if (k1==k2) {
        Console.WriteLine("The lines are parallel");
    }
    else {
        Console.WriteLine($"x={x=(b2-b1)/(k1-k2)}; y= {y=k1*x+b1}");
    }
}

f(b1, b2, k1, k2);

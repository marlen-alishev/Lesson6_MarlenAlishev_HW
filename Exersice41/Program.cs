// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

int f(int[] arrayX){
    int sum=0;
    for (int i=0; i<arrayX.Length; i++) {
        if (arrayX[i]>0){
            sum = sum + arrayX[i];
        }
    }
    return sum;
}

Console.Clear();
Console.Write("Please enter your numbers: ");
int[] array = Console.ReadLine().Split(" ").Select(x=>int.Parse(x)).ToArray();
Console.WriteLine($"[{string.Join(", ", array)}]"); 
Console.WriteLine($"The sum equals to: {f(array)}");

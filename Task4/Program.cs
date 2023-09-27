// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


// Решение через цикл for
Console.WriteLine("Выведем числа от 1 до N");
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = n / n; i <= n; i++) {
    Console.Write(i + ", ");
}


// Решение через цикл while
Console.WriteLine("Выведем числа от 1 до N");
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = n - n + 1;
while (i <= n) {
    if (i == n) {
        Console.Write(i + ".");
        break;
}
else {
    Console.Write(i + ", ");
}
i++;
}    
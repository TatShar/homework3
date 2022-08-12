// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Enret a number: ");

int n = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i <= n) {
    Console.Write(Math.Pow(i,3)+" ");
    i++;
}


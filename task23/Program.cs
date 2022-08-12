// Посмотрите другой вариант решения в этой папке, этот не удался.Почему? Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Enter a number N: ");
int n = Convert.ToInt32(Console.ReadLine());
String nText = Convert.ToString(n);

int index=0;
int res = 0;


while (index< nText.Length){
    res = Math.Pow(nText[index],3);
    Console.Write(n3);
    index++;
}

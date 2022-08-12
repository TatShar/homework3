// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Input five-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
string numT = Convert.ToString(num);

if (numT[0]==numT[4] && numT[1]==numT[3]){
Console.Write("number "+num+" is palindrom");
}
else if (numT.Length !=5) {
    Console.Write("Input five-digit number");
}
else {
    Console.Write("number "+num + "is not paliandrom");
}

// Обьявляем переменные
double num1, num2; // для преоброзавания
string input1, input2; // для ввода
input1 =  Console.ReadLine();
input2 = Console.ReadLine();

num1 = double.Parse(input1);
num2 = double.Parse(input2);

if (num1 > num2) // Сравниваем
{
    Console.Write(num1 + " больше чем " + num2);
}
else
{
    Console.Write(num2 + " Больше чем " + num1);
}


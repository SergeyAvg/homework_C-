// double num1, num2, num3; // для преоброзавания
// string input1, input2, input3; // для ввода
int num1, num2, num3;
string input1, input2, input3;
// Console.WriteLine("Введите 3 числа:");
input1 = Console.ReadLine();
input2 = Console.ReadLine();
input3 = Console.ReadLine();

// num1 = double.Parse(input1);
// num2 = double.Parse(input2);
// num3 = double.Parse(input3);

// double max;
// max = num1;
// if (max < num2)
// {
//     max = num2;
// }
// else if (max < num3)
// {
//     max = num3;
// }

// Console.Write(max);

num1 = Int32.Parse(input1);
num2 = Int32.Parse(input2);
num3 = Int32.Parse(input3);

int max;
max = num1;
if (num1 > max) max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.Write("Максимальное число" + max);

// Console.Write("Введите первое число и нажмите клавишу Enter: ");
// string input_a = Console.ReadLine();
// int a = Convert.ToInt32(input_a);
// Console.Write("Введите второе число и нажмите клавишу Enter: ");
// string input_b = Console.ReadLine();
// int b = Convert.ToInt32(input_b);
// Console.Write("Введите третье число и нажмите клавишу Enter: ");
// string input_c = Console.ReadLine();
// int c = Convert.ToInt32(input_c);
// int max = a;
// if (a>max) max = a;
// if (b>max) max = b;
// if (c>max) max = c;
// Console.WriteLine("Максимальное число: " + max);
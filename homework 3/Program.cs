string input;
int num;
input = Console.ReadLine();
num = Int32.Parse(input);
if (num % 2 == 0) 
{
    Console.Write("YES");
}
else
{
    Console.Write("NO");
}
string input;
int num, count;
input = Console.ReadLine();
num = Int32.Parse(input);
count = 1;
while (count < num + 1)
{
    if (count % 2 == 0) 
    {
        Console.WriteLine(count);
    }
    count += 1;
}
Console.WriteLine("Tabuada do número:");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int s = 0;
int produto;

while(s <= 10)
{
produto = c * s;
Console.WriteLine($"{c} x {s} = {produto}");
s += 1;
}
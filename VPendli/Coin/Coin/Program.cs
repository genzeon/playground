// See https://aka.ms/new-console-template for more information
using Pendlium;
Coin c = new Coin();
for (int i = 0; i < 20; i++)
{
    Console.WriteLine(c);
    c.Flip();
}

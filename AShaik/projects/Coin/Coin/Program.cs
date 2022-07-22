using CoinStimulates.Models;

coin c = new coin();
Console.WriteLine("before flip");
Console.WriteLine(c.ToString());
Console.WriteLine("after flip");
for (int i = 0; i < 100; i++)
{

    c.flip();
    Console.WriteLine(c.ToString());
}
Console.WriteLine();











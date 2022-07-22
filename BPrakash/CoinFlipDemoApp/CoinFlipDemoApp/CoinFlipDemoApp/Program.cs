using CoinFlipDemoApp;


Coin c= new Coin();
c.SetSides();
Console.WriteLine("The Initial State of Coin is : ");
Console.WriteLine(c.ToString());
Console.WriteLine("After Flipping : ");
for (int i=0;i<6; i++)
{
    c.Flip();
    Console.WriteLine(c.ToString());
}

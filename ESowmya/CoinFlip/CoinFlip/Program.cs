
using CoinFlip;
Coin coin = new Coin();
coin.set_intial_value();
Console.WriteLine(coin.ToString());
for(int i = 0; i <= 10; i++)
{
 coin.Flip();
    Console.WriteLine(coin.ToString());
    
}

using Coin_Flip;

Coin coin = new Coin();

coin.set_initial_Sides();

for(int i=0; i < 10; i++)
{
    coin.Flip();
    Console.WriteLine(coin.ToString());
}


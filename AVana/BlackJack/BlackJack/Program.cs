using BlackJack;

Deck a = new Deck();
Console.WriteLine("Enter No Of Players");
int player = Convert.ToInt32(Console.ReadLine());
a.DeckSize(player);
Console.WriteLine("before shuffle");
int A = 1;
Console.WriteLine(  "Value" + "     " + "Suit" + "     " + "Color" + "   " +  "Image");

foreach (var item in a.GetAll())
{
    Console.WriteLine(A + " " + item.Value + "     " + item.Suit + "     " + item.Color + "   " + item.Image+".png");
    A++;
}
a.DeckShuffle();
Console.WriteLine("after shuffle");

int B = 1;
Console.WriteLine("Value" + "     " + "Suit" + "     " + "Color" + "   " + "Image");
foreach (var item in a.GetAll())
{
    Console.WriteLine(B + " " + item.Value + "     " + item.Suit + "     " + item.Color + "  " + item.Image+".png");
    B++;
}

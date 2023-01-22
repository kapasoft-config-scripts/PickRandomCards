// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using PickRandomCards;

Console.Write("Please, enter number of cards to pick: ");
string line = Console.ReadLine();
if(int.TryParse(line, out int numerOfCards))
{
    string[] cardsPicked = CardPicker.PickSomeCards(numerOfCards);
    foreach(string card in cardsPicked)
    {
        Console.WriteLine(card);
    }
    
    //Console.WriteLine(cardsPicked);
}
else
{
    Console.WriteLine("Input isn't number but expected one");
}
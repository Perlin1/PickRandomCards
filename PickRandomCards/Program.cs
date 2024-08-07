
namespace PickRandomCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of cards to pick");
            string line = Console.ReadLine();
            if (int.TryParse(line, out int numberoOfCards))
            {
                string[] pickedCards = CardPicker.PickSomeCards(numberoOfCards);
                foreach(string card in pickedCards)
                {
                    Console.WriteLine(card);
                }
            }
            else
            {
                Console.WriteLine("Enter a valid number or GET OUT!!!");
            }
        }        
    }
}

using Library;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("The Great Gatsby", 1925, "F. Scott Fitzgerald", "978-0743273565");

            var member = new PremiumMember("Mickey Mouse");

            var library = new NationalLibrary();
            library.AddItem(book);
            library.AddItem(new Magazine("National Geographic", 1888, 1, "0027-9358"));

            var borrowedItem = library.BorrowItem("978-0743273565", member);
            Console.WriteLine($"Kikölcsönzött könyv: {borrowedItem}");

            if (library.FindItem("978-0743273565"))
            {
                Console.WriteLine("Könyv megtalálva");
            }
            else
            {
                Console.WriteLine("Könyv nem található");
            }

            try
            {
                library.BorrowItem("0027-9358-1", member);
                Console.WriteLine("Sikeres kölcsönzés");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            library.ReturnItem(borrowedItem, member);
            Console.WriteLine("Könyv visszavéve");

            try
            {
                library.BorrowItem("0027-9358-1", member);
                Console.WriteLine("Sikeres kölcsönzés");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}

namespace AddressBookDay27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Welcome to Address Book Program");
                AddressBookManagement addressBook = new AddressBookManagement();
                addressBook.ToAddAddress("Pooja", "Chakor", "Krantinagar", "Nashik", "Maharashtra", "chakorpooja07@gmail.com", 7040613418, 422003);
                addressBook.Display();
            }
        }
    }
}
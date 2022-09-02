using AddressBookSystem;

Console.WriteLine("Welcome to AddressBook Program.");
AddressBook addressBook = new AddressBook(); 
int option = 0;
while (option != 3) 
{
    Console.WriteLine("Press 1 for add contact./n Press 2 for list the contact./n Press 3 to exit.");
    Console.WriteLine("Please enter option number: ");
    option = int.Parse(Console.ReadLine()); 
    switch (option)
    {
        case 1: 
            addressBook.addContact();
            break;
        case 2:
            addressBook.listContact();
            break;
        case 3:
            Console.WriteLine("Exiting from Program.");
            break;
        default: 
            Console.WriteLine("Wrong option.");
            break;
    }
}
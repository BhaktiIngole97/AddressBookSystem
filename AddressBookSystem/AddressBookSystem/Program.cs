using AddressBookSystem;

Console.WriteLine("Welcome to AddressBook Program.");
AddressBook addressBook = new AddressBook();
int option = 0;
while (option != 9)
{
    Console.WriteLine("-------------------------------------------");
    Console.WriteLine("Press 1 for add contact.\nPress 2 for list the contact.\nPress 3  to edit the contact.");
    Console.WriteLine("Press 4 to delete the contact.\nPress 5 to add Unique contact.");
    Console.WriteLine("Press 6 to display Unique Contacts.\nPress 7 to search a contact.");
    Console.WriteLine("Press 8 to Display Sorted Contacts.\nPress 9 to exit");
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
            addressBook.editContact();
            break;
        case 4:
            addressBook.deleteContact();
            break;
        case 5:
            addressBook.AddUniqueContact();
            break;
        case 6:
            addressBook.displayUniqueContact();
            break;
        case 7:
            addressBook.ViewPersonByCityState();
            break;
        case 8:
            addressBook.SortContacts();
            break;
        case 9:
            Console.WriteLine("Exiting from Program.");
            break;
        default: 
            Console.WriteLine("Wrong option.");
            break;
    }
}
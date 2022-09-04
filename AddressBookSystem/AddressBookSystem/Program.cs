using AddressBookSystem;

Console.WriteLine("Welcome to AddressBook Program.");
AddressBook addressBook = new AddressBook(); 
int option = 0;
while (option != 10) 
{
    Console.WriteLine("-------------------------------------------");
    Console.WriteLine("Press 1 for Add Contact.\nPress 2 for List the Contact.\nPress 3  to Edit the Contact.");
    Console.WriteLine("Press 4 to Delete the Contact.\nPress 5 to add Unique Contact.");
    Console.WriteLine("Press 6 to Display Unique Contacts.\nPress 7 to Search a Contact.");
    Console.WriteLine("Press 8 to Display Sorted Contacts.\nPress 9 to Write and Read Contacts from file.\nPress 10 to exit");
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
            addressBook.ReadWriteFile();
            break;
        case 10:
            Console.WriteLine("Exiting from Program.");
            break;
        default: 
            Console.WriteLine("Wrong option.");
            break;
    }
}
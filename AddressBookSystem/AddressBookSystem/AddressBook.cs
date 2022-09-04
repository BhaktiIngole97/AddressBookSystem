using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class Person
    {
       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string[] Address { get; set; }
    }
    internal class AddressBook
    {
        public List<Person> People = new List<Person>(); 
        Dictionary<string, List<Person>> dict = new Dictionary<string, List<Person>>();
        public void addContact() 
        {
            Person person = new Person();
            Console.WriteLine("-------------------------------------------");
            Console.Write("Enter the First Name: ");
            person.FirstName = Console.ReadLine();
            bool check = checkDuplicate(person.FirstName); 
            if (check) 
            {
                return;
            }
            Console.Write("Enter the Last Name: ");
            person.LastName = Console.ReadLine();
            Console.Write("Enter the Mobile number: ");
            person.PhoneNumber = Console.ReadLine();
            Console.Write("Enter the Email ID: ");
            person.Email = Console.ReadLine();
            string[] add = new string[4];
            Console.Write("Enter the Address: ");
            add[0] = Console.ReadLine();
            Console.Write("Enter the City: ");
            add[1] = Console.ReadLine();
            Console.Write("Enter the State: ");
            add[2] = Console.ReadLine();
            Console.Write("Enter the Zipcode: ");
            add[3] = Console.ReadLine();
            person.Address = add;
            People.Add(person); 
        }
        public void printContact(Person person) 
        {
            Console.WriteLine("Full name : " + person.FirstName + " " + person.LastName);
            Console.WriteLine("Mobile number : " + person.PhoneNumber);
            Console.WriteLine("Email ID : " + person.Email);
            Console.WriteLine("Address : " + person.Address[0]);
            Console.WriteLine("City : " + person.Address[1]);
            Console.WriteLine("State : " + person.Address[2]);
            Console.WriteLine("Zipcode : " + person.Address[3]);
        }
        public Boolean checkDuplicate(string firstName)
        {
            foreach (var person in People)
            {
                if (person.FirstName == firstName)
                {
                    Console.WriteLine("Name already exits.");
                    return true;
                }
            }
            return false;
        }
        public void listContact()
        {
            if (People.Count != 0)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Following is your Contact List:");
                foreach (var person in People) 
                {
                    Console.WriteLine("-------------------------------------------");
                    printContact(person);
                }
            }
            else
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Address Book is empty.");
            }
        }
        public void editContact() 
        {
            string findContact;
            int option;
            if (People.Count != 0) 
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Enter the first name you want to edit : ");
                findContact = Console.ReadLine(); 
                foreach (var person in People)
                {
                    if (findContact.ToLower() == person.FirstName.ToLower()) 
                    {
                        Console.WriteLine("1 for First Name.\n2 for Last Name.\n3 for Mobile number.\n 4 for Email ID.");
                        Console.WriteLine("5 for Address.\n6 for City.\n7 for State.\n8 for Zipcode. ");
                        Console.WriteLine("Please enter option number: ");
                        option = int.Parse(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                Console.Write("Enter the First Name: ");
                                person.FirstName = Console.ReadLine();
                                break;
                            case 2:
                                Console.Write("Enter the Last Name: ");
                                person.LastName = Console.ReadLine();
                                break;
                            case 3:
                                Console.Write("Enter the Mobile number: ");
                                person.PhoneNumber = Console.ReadLine();
                                break;
                            case 4:
                                Console.Write("Enter the Email ID: ");
                                person.Email = Console.ReadLine();
                                break;
                            case 5:
                                Console.Write("Enter the Address: ");
                                person.Address[0] = Console.ReadLine();
                                break;
                            case 6:
                                Console.Write("Enter the City: ");
                                person.Address[1] = Console.ReadLine();
                                break;
                            case 7:
                                Console.Write("Enter the State: ");
                                person.Address[2] = Console.ReadLine();
                                break;
                            case 8:
                                Console.Write("Enter the Zipcode: ");
                                person.Address[3] = Console.ReadLine();
                                break;
                            default:
                                Console.WriteLine("Wrong input");
                                break;
                        }
                        return;
                    }
                    else 
                    {
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("Enter a valid name.");
                    }
                }
            }
            else
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Address Book is empty.");
            }
        }
        public void deleteContact()
        {
            if (People.Count != 0)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Enter the first name you want to delete : ");
                string deleteContact = Console.ReadLine(); 
                for (int i = 0; i < People.Count; i++) 
                {
                    if (deleteContact.ToLower() == People[i].FirstName.ToLower()) 
                    {
                        People.RemoveAt(i);
                        Console.WriteLine("Contact is deleted.");

                    }
                    else 
                    {
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("Enter a valid name.");
                    }
                }
            }
            else 
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Address Book is empty.");
            }
        }
        public void AddUniqueContact() 
        {
            Console.WriteLine("-------------------------------------------");
            Console.Write("Enter the First Name you want to add in Unique Contact Book: ");
            string firstName = Console.ReadLine();
            foreach (var person in People)
            {
                if (People.Contains(person))
                {
                    dict.Add(firstName, People);
                }
            }
        }
        public void displayUniqueContact() 
        {
            foreach (var item in dict)
            {
                foreach (var contact in item.Value)
                {
                    Console.WriteLine("-------------------------------------------");
                    printContact(contact);
                }
            }
        }
        public void SearchContact() 
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Enter the City or State to search contact: ");
            string result = Console.ReadLine();
            foreach (Person person in People.FindAll(e => e.Address[1].Equals(result) || e.Address[2].Equals(result)))
            {
                Console.WriteLine("-------------------------------------------");
                printContact(person);
            }
        }
        public void ViewPersonByCityState() 
        {
            Dictionary<string, List<Person>> CityAddressBook = new Dictionary<string, List<Person>>();
            Dictionary<string, List<Person>> StateAddressBook = new Dictionary<string, List<Person>>();
            Console.WriteLine("Press 1 if want to search by City or Press 2 if want to search by state");
            int choice = Convert.ToInt32(Console.ReadLine());
            string city, state;
            switch (choice)
            {
                case 1:
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("Enter the city you want to search: ");
                    city = Console.ReadLine();
                    CityAddressBook[city] = new List<Person>();
                    foreach (Person person in People.FindAll(e => e.Address[1].Equals(city)))
                    {
                        CityAddressBook[city].Add(person);
                    }
                    foreach (var person in CityAddressBook)
                    {
                        foreach (var item in person.Value)
                        {
                            Console.WriteLine("-------------------------------------------");
                            printContact(item);
                        }
                    }
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("Total count of people at {0} city: {1}", city, CityAddressBook[city].Count);
                    break;
                case 2:
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("Enter the state you want to search: ");
                    state = Console.ReadLine();
                    StateAddressBook[state] = new List<Person>();
                    foreach (Person person in People.FindAll(e => e.Address[2].Equals(state)))
                    {
                        StateAddressBook[state].Add(person);
                    }
                    foreach (var person in StateAddressBook)
                    {
                        foreach (var item in person.Value)
                        {
                            Console.WriteLine("-------------------------------------------");
                            printContact(item);
                        }
                    }
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("Total count of people at {0} state: {1}", state, StateAddressBook[state].Count);
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
        }
        public void SortContacts() 
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Press 1 to Sort by Name.\nPress 2 to Sort by City");
            Console.WriteLine("Press 3 to Sort by State.\nPress 4 to Sort by ZipCode");
            Console.WriteLine("Please enter the option: ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    foreach (Person person in People.OrderBy(name => name.FirstName)) 
                    {
                        Console.WriteLine("-------------------------------------------");
                        printContact(person);
                    }
                    break;
                case 2:
                    foreach (Person person in People.OrderBy(city => city.Address[1]))
                    {
                        Console.WriteLine("-------------------------------------------");
                        printContact(person);
                    }
                    break;
                case 3:
                    foreach (Person person in People.OrderBy(state => state.Address[2])) 
                    {
                        Console.WriteLine("-------------------------------------------");
                        printContact(person);
                    }
                    break;
                case 4:
                    foreach (Person person in People.OrderBy(code => code.Address[3]))
                    {
                        Console.WriteLine("-------------------------------------------");
                        printContact(person);
                    }
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
        }
    }
}


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
        public void addContact() 
        {
            Person person = new Person(); 
            Console.WriteLine("-------------------------------------------");
            Console.Write("Enter the First Name: ");
            person.FirstName = Console.ReadLine();
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
                    if (findContact == person.FirstName) 
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
    }
}


using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AddressBook
{
    public class ContactPerson:AddressBook
    {
        string firstName;
        string lastName;
        string address;
        string city;
        string state;
        long phone_Number;
        string email;
        bool isPresent = true;
        int zip;
        ArrayList arrayList=new ArrayList();
        

        //Method to add a contact person with required fields
        public void addPerson()
        {
            AddressBookFields addressBookMain;
            Console.WriteLine("Enter your firstName :-");
            firstName=Console.ReadLine();
            while (isPresent)
            {
                isPresent = false;
                foreach (AddressBookFields person in arrayList)
                {
                    if (person.FirstName.Equals(firstName))
                    {
                        Console.WriteLine("Person with that name is already present.Enter another name");
                        isPresent = true;
                        break;
                    }
                }
                if (isPresent == false)
                    break;
                Console.WriteLine("Enter your firstName :-");
                firstName = Console.ReadLine();
            }
            Console.WriteLine("Enter your lastName :- ");
            lastName=Console.ReadLine();
            Console.WriteLine("Enter your address :- ");
            address=Console.ReadLine();
            Console.WriteLine("Enter your city :- ");
            city=Console.ReadLine();
            Console.WriteLine("Enter your state :- ");
            state=Console.ReadLine() ;
            Console.WriteLine("Enter the Zip Code :- ");
            zip=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Eneter the phone_Number :- ");
            phone_Number=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the email_Id :- ");
            email=Console.ReadLine();
            //Adding all the details of user as One object
            addressBookMain = new AddressBookFields(firstName,lastName,address,city,state,zip,phone_Number,email);
            //Now adding that user to a list
            arrayList.Add(addressBookMain);
            Console.WriteLine(addressBookMain.ToString());
            Console.WriteLine("Saved Successfully........");

        }
        //Method To update a Person
        public void editPerson()
        {
            Console.WriteLine("Enter the Name ");
            string name=Console.ReadLine(); 
            foreach (AddressBookFields person in arrayList)
            {
                if (person.FirstName.Equals(name))
                {
                    addPerson();
                    return;
                }
            }
            Console.WriteLine($"There is no person with that name {name}");

        }
       //Method to remove a person
        public void removePerson() {
            Console.WriteLine("Enter the Name ");
            string name = Console.ReadLine();
            foreach (AddressBookFields person in arrayList)
            {
                if(person.FirstName.Equals(name))
                {
                    arrayList.Remove(person);
                    Console.WriteLine("Removed "+person.FirstName);
                    return;
                }
            }
            Console.WriteLine($"There is no person with that name {name}");

        }
        //Method to show all users
        public void showAllRecords()
        {
            foreach(AddressBookFields fields in arrayList)
            {
                Console.WriteLine(fields.ToString());
                Console.WriteLine("-------------------------------------------------------------------------");
            }
        }
    }
}

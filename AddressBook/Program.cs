using AddressBook;

Console.WriteLine("AddressBook System");
Console.WriteLine("Select option\n1)Create AddrssBookServiceDatabase\n2)Create Table\n3)Insert Contact\n" +
    "4)Update Details\n5)Fetch COntacts");
int op = Convert.ToInt16(Console.ReadLine());
AddressBookData ad = new AddressBookData();
AddressBookModel addressbook = new AddressBookModel();

switch (op)
{
    case 1:
        AddressBookData.Create_Database();
        break;
    case 2:
        AddressBookData.CreateTables();
        break;
    case 3:
        Console.WriteLine("Welcome to Address Book");
        addressbook.First_Name = "sunil";
        addressbook.Last_Name = "kamble";
        addressbook.Address = "Mumbai";
        addressbook.City = "Mumbai";
        addressbook.State = "Maharashtra";
        addressbook.Zip = "400005";
        addressbook.Phone_Number = "7410741141";
        addressbook.Email = "kundan@gmail.com";
        ad.AddContact(addressbook);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Record Inserted successfully");
        Console.ResetColor();
        break;
    case 4:
        Console.WriteLine("Welcome to Address Book");
        addressbook.First_Name = "";
        addressbook.Last_Name = "Kadam";
        addressbook.Address = "colaba";
        addressbook.City = "mumbai";
        addressbook.State = "Mahgarashtra";
        addressbook.Zip = "400005";
        addressbook.Phone_Number = "9844335566";
        addressbook.Email = "sunil@gmail.com";
        
        ad.UpdateContact
            (addressbook);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Record Updated successfully");
        Console.ResetColor();
        break;
    case 5:
        ad.GetAllContact();
        break;
    default:
        Console.WriteLine("Wrong Choice");
        break;
}


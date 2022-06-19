using AddressBook;

Console.WriteLine("AddressBook System");
Console.WriteLine("Select option\n1)Create AddrssBookServiceDatabase\n2)Create Table\n3)Insert Contact\n4)Fetch COntacts");
int op = Convert.ToInt16(Console.ReadLine());
AddressBookData ad = new AddressBookData();

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
        AddressBookModel addressbook = new AddressBookModel();
        addressbook.First_Name = "Kundan";
        addressbook.Last_Name = "kamble";
        addressbook.Address = "Mumbai";
        addressbook.City = "Mumbai";
        addressbook.State = "Maharashtra";
        addressbook.Zip = "400005";
        addressbook.Phone_Number = "7410741141";
        addressbook.Email = "kundan@gmail.com";
        ad.AddContact(addressbook);
        Console.WriteLine("Record Inserted successfully");
        Console.ResetColor();
        break;
    case 4:
        ad.GetAllContact();
        break;
    default:
        Console.WriteLine("Wrong Choice");
        break;
}


// See https://aka.ms/new-console-template for more information
using KC2;
using static KC2.Hardware;
using static KC2.Register;

Console.WriteLine("Hello, World!");
Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<Register>();
for (int i = 0; i < numberOfRecords; i++)
{
	// In this loop, populate the object's properties using Console.ReadLine()
	var register = new Register();

	Console.WriteLine("Enter the value for Name");
	Register.Name = Console.ReadLine();

	Console.WriteLine("Enter the Register's for model");
    Register.Registermodel = Console.ReadLine();

	Console.WriteLine("Enter the register's IP address");
	Register.IpAdress = Console.ReadLine();

	Console.WriteLine("Enter the MAC Address");
	Register.MacAdress = Console.ReadLine();


	recordList.Add(register);
}


// Print out the list of records using Console.WriteLine()
Console.WriteLine(recordList.FindAll);
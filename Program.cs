using Classes;

string firstName;
string lastName;
string adress;


Console.WriteLine("Hello! Welcome to the Bank. Please enter your data to setup an account.\n");

Console.Write("First name: ");
firstName = Console.ReadLine();
Console.Write("Last name: ");
lastName = Console.ReadLine();
Console.Write("Adress: ");
adress = Console.ReadLine();
Console.Clear();

Client client1 = new Client(firstName, lastName, adress);

BankAccount account = new BankAccount(client1.FirstName, 1000);
client1.BankAccount = account;


Console.WriteLine($"Client setup with \n\nFirst name: {client1.FirstName}\nLast name: {client1.LastName}\nAdress: {client1.Adress}\n\n");


Console.WriteLine($"Account {client1.BankAccount.Number} was created for {client1.BankAccount.Owner} with {client1.BankAccount.Balance} initial balance.\n");

account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
account.MakeDeposit(100, DateTime.Now, "Friend paid me back");

Console.WriteLine(account.GetAccountHistory());

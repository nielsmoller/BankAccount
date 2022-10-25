using Classes;
using System;

public class Client
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string Adress { get; set; }
	public BankAccount BankAccount { get; set; }

	public Client(string firstName, string lastName, string adress)
	{
		FirstName = firstName;
		LastName = lastName;
		Adress = adress;

	}
}

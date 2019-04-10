using System;
using System.Linq;					
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
		
		Dictionary<int,Person> dic = new Dictionary<int,Person>();
		dic.Add(1, new Person{
			Id = 101,
			FirstName = "Sandeep",
			LastName = "Multani",
			Active = true,
			Role = Role.Admin
		});
		
		dic.Add(2, new Person{
			Id = 102,
			FirstName = "Navdeep",
			LastName = "Kaur",
			Active = true,
			Role = Role.Manager
		});
		
		dic.Add(3, new Person{
			Id = 103,
			FirstName = "Staff 1",
			LastName = "Staff 1",
			Active = true,
			Role = Role.Staff
		});
		
		dic.Add(4, new Person{
			Id = 104,
			FirstName = "Staff 4",
			LastName = "Staff 4",
			Active = true,
			Role = Role.Staff
		});
		
		dic.Add(5, new Person{
			Id = 105,
			FirstName = "Staff 5",
			LastName = "Staff 5",
			Active = true,
			Role = Role.Staff
		});
		
		var dic1 = dic.Where(p => p.Value.Role == Role.Staff && p.Value.Id == 105)
         .ToDictionary(p => p.Key, p => p.Value);
		
		foreach(KeyValuePair<int, Person> entry in dic1)
		{
			Console.WriteLine("entry.key= " + entry.Key);
			Console.WriteLine("entry.value =>>>>>>>>>>>>>>>>>>> ");
			Console.WriteLine("entry.value.Id= " + entry.Value.Id);
			Console.WriteLine("entry.value.FirstName= " + entry.Value.FirstName);
			Console.WriteLine("entry.value.LastName= " + entry.Value.LastName);
			Console.WriteLine("entry.value.Active= " + entry.Value.Active);
			Console.WriteLine("entry.value.Role= " + entry.Value.Role);

			Console.WriteLine("======================");
			Console.WriteLine("======================");

		}
	}
	
	class Person{
		public int Id {get;set;}
		public string FirstName {get;set;}
		public string LastName {get;set;}
		public bool Active {get;set;}
		public Role Role {get;set;}

	}
	
	enum Role{
		Admin = 1,
		Manager,
		Staff
	}
}

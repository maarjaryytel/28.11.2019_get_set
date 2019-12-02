using System;

namespace _28._11._19_get_set
{
	class Program
	{
		//loome uue klassi- person
		class Person
		{
			string name; //need ei ole public kui ei ole kirjas public, main ei saa kätte
			string gender;
            int age;
			string idCode;

			//loome konstruktori

			public Person (string _name, string _gender, int _age, string _idCode)
			{
				Name = _name; //selleks et saaks nime muuta, tuleb panna suure algustähega
				Gender = _gender;
				Age = _age;
				IdCode = _idCode;
			}

			//loome konstruktori, et main saaks kätte

			public string Name //name tuleb kirj suure algustähega
			{
				get { return name;  } //see on eraldi meetod
				set
				{
					name = value; //value on see, mida ma talle iga kord pakun
				}
			}

			public string Gender
			{
				get { return gender;  }

				set
				{
					if(value == "male" || value == "female") //alt gr + II
					{
						gender = value;
					}
					else
					{
						gender = "unicorn";
					}
				}
			}

			public string IdCode //string, kuna ei kontrolli sisu, vaid kontrollime 
								//selle sisestatava väärtuse vastavust ehk pikkust

			{
				get { return idCode; }

				set
				{
					if (value.Length == 11)
					{
						idCode = value;
					}
					
					else 
					{
						idCode = "underfined";
				    }
				
				}
				
			}

			public int Age

			{
				get { return age; }
				set
				{
					if(value >= 0)
					{
						age = value;
					}
					else
					{
						age = 0;
					}
				}
			}
		}
		static void Main(string[] args)
		{
			//loome uue objekti
			Person newPerson = new Person("John", "male", 34, "4780811222"); //siin siis muudan oma ik, pikemaks, lühemaks

			//mul ei ole meetodit et kuvada väärtusi
			//tahaks vaadata mis seal toimub
			//Console.Wr võtan objekti ja püüan kätte saada nende omaduste väärtused
			Console.WriteLine($"A new person {newPerson.Name}");

			//kas john saaks nime muuta
			//nime muutmist võimaldab set
		
			newPerson.Name = "Joanna";
			Console.WriteLine($"A new person {newPerson.Name}");
			newPerson.Gender = "Fairy";

			//sugu
			Console.WriteLine($"Gender: {newPerson.Gender}");
			newPerson.Gender = "Fairy";

			Console.WriteLine($"idCode: {newPerson.IdCode}");
			Console.WriteLine($"Age: {newPerson.Age}");
			Console.ReadLine();
		}
	}
}

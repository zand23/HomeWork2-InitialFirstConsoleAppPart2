using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork2.Task1
{
	using System;

	class Student
	{
		private string name;
		private int age;

		public Student(string name, int age)
		{
			this.name = name;
			this.age = age;
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public int Age
		{
			get { return age; }
			set { age = value; }
		}

		public void Introduce()
		{
			Console.WriteLine($"Hello, my name is {name} and I am {age} years old");
		}
	}


}


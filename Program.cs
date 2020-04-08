using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
	class Person
	{
		public static int id = 0;
		public string surname { get; set; }
		public string name { get; set; }
		public string fathername { get; set; }

		public Person(string surname, string name, string fathername)
		{
			++id;
			this.surname = surname;
			this.name = name;
			this.fathername = fathername;
		}

		// ИНДЕКСАТОР

		public string this[string propname]
		{
			get {
				switch (propname)
				{
					case "surname": return surname;
					case "name": return name;
					default: return "Doesn't FIND";
				}
			}
			set {
				switch (propname)
				{
					case "surname":
						surname = value;
						break;
					case "name":
						name = value;
						break;
					default:
						break;
				}
			}
		}

		public void print()
		{
			Console.WriteLine("Код:{0}",id);
			Console.WriteLine("Фамилия:{0}", surname);
			Console.WriteLine("Имя:{0}", name);
			Console.WriteLine("Отчество:{0}",fathername);
		}

		public void add(string str)
		{
			print();
			Console.WriteLine(str);	
		}
	}

	class Student : Person
	{
		public string name_university { get; set; }
		public Student(string surname, string name, string fathername, string name_university) :base( surname, name, fathername)
		{
			this.name_university = name_university;
		}

		public void print()
		{
			Console.WriteLine("Код:{0}", id);
			Console.WriteLine("Фамилия:{0}", surname);
			Console.WriteLine("Имя:{0}", name);
			Console.WriteLine("Отчество:{0}", fathername);
			Console.WriteLine("Наименование заведения:{0}",name_university);
		}

		public void add(string str)
		{
			print();
			Console.WriteLine(str);
		}
	}

	class Student_Speciality: Student
	{
		public string faculty { get; set; }
		public string group { get; set; }

		public Student_Speciality(string surname, string name, string fathername, string name_university, string faculty, string group):
			base(surname, name, fathername, name_university)
		{
			this.faculty = faculty;
			this.group = group;
		}

		public void print()
		{
			Console.WriteLine("Код:{0}", id);
			Console.WriteLine("Фамилия:{0}", surname);
			Console.WriteLine("Имя:{0}", name);
			Console.WriteLine("Отчество:{0}", fathername);
			Console.WriteLine("Наименование заведения:{0}", name_university);
			Console.WriteLine("Факультет:{0}",faculty);
			Console.WriteLine("Группа:{0}",group);
		}

		public void add(string str)
		{
			print();
			Console.WriteLine(str);
		}


	} 

	class Program
	{
		static void Main(string[] args)
		{
			Person p = new Person("Иванов","Иван","Иванович");
			p.print();
			Console.WriteLine();
			Console.WriteLine("ПОСЛЕ ДОБАВЛЕНИЯ");
			p.add("ИНФА");
			Console.WriteLine();
			Student s = new Student("Иванов", "Иван", "Иванович","БГУИР");
			s.print();
			Console.WriteLine();
			Console.WriteLine("ПОСЛЕ ДОБАВЛЕНИЯ");
			s.add("ИНФА");
			Console.WriteLine();
			Student_Speciality st = new Student_Speciality("Иванов", "Иван", "Иванович", "БГУИР", "ФРЭ", "944691");
			st.print();
			Console.WriteLine();
			Console.WriteLine("ПОСЛЕ ДОБАВЛЕНИЯ");
			st.add("ИНФА");
			Console.WriteLine();
			Console.WriteLine(st["name"]);
			Console.WriteLine();
			Console.ReadKey();
		}
	}
}

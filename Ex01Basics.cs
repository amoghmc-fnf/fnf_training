using System;
namespace SampleConApp
{
	class SampleExample {
		static void display() {
			Console.WriteLine("Hello world!");
			Console.WriteLine("My name is Amogh");
			Console.WriteLine("I am from Bangalore");
			Console.WriteLine("I work on .NET");
			Console.ReadLine();
		}
		static void inputDisplay() {
			Console.WriteLine("Enter your name");
			string name = Console.ReadLine();

			Console.WriteLine("Enter your age");
			int age = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter your phone");
			string phone = Console.ReadLine();

			Console.WriteLine("The name is {0} with contact no {1} and aged {2}", name, phone, age);
			//Console.WriteLine("{0}'s age will be ({1} + 15) after 15 years", name, age);
			Console.WriteLine("{0}'s age will be {1} after 15 years", name, age + 15);
			
		}

		static void convertExample() {
			int x = 32;
			long y = x;
			Console.WriteLine(y);
			y = 2323333333292992;


			// Convert example
			try {
				x = Convert.ToInt32(y);
			}
			catch (Exception ex) {
				Console.WriteLine(ex.Message);
			}
			Console.WriteLine(x);

			// checked example
			try {
				checked {
					x = (int) y;
				}
			}
			catch (Exception ex) {
				Console.WriteLine(ex.Message);
			}
			Console.WriteLine(x);

		}

		static void Main() {
			// inputDisplay();
			convertExample();
		}
	}
}

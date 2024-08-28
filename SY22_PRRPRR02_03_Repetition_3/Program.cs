using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_03_Repetition_3 {
	internal class Program {
		static void HelloWorld() {
			Console.WriteLine("Hello world");
		}

		static void Greet(string name) {
			string greeting = GetGreeting(name);

			Console.WriteLine(greeting);
		}

		static int Add(int a, int b, int c) {
			return a + b + c;
		}

		static string GetGreeting(string name) {
			return "Hello " + name;
		}

		static void Main(string[] args) {
			HelloWorld();

			Greet("Greta");

			string greeting = GetGreeting("Hugo");

			Console.WriteLine(greeting);

			Console.WriteLine(Add(1, 2, 3));
		}
	}
}

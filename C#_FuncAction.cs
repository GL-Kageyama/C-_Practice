using System;

namespace FuncActionSample
{
	class FuncAction
	{
		static void Main(string[] args)
		{
			FuncAction fa = new FuncAction();
			fa.exec();

			Console.Read();
		}

		public void exec()
		{
			// Func have a Return value.
			Func<string, string, int> Debug1 = delegate (string str1, string str2)
			{
				Console.Write(str1);
				return str2.Length;
			};

			Debug1("Func is good.", "I'm fine.");

			Console.WriteLine();

			// Action haven't Return value.
			Action <string, string> Debug2 = delegate (string str1, string str2)
			{
				Console.Write(str1);
			};

			Debug2("Action is good.", "How are you?");

			Console.WriteLine();
		}
	}
}


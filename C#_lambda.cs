using System;

namespace lambdaSample
{
	class Lam_Sample
	{
		static void Main(string[] args)
		{
			Lam_Sample lam = new Lam_Sample();
			lam.exec();

			Console.Read();
		}

		public void exec()
		{
			Func<string, string, int> Debug1 = (string str1, string str2) =>
			{
				Console.Write(str1);
				return str2.Length;
			};

			Debug1("Hello lambda! ", "feel good ");

			Console.WriteLine();

			// {} & return is Omit.
			Func<string, string, int> Debug2 = (string str1, string str2) => str1.Length + str2.Length;

			int count = Debug2("abcdefghijk", "Count");

			Console.Write(count);
		}
	}
}















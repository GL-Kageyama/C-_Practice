using System;

namespace delegateSample
{
	class Sample
	{
		public delegate int Debug(String str1, String str2);

		static void Main(string[] args)
		{
			Sample sm = new Sample();
			sm.exec();
		
			Console.Read();
		}

		public void exec()
		{
			// plus execute()
			Debug m_Debug1 = new Debug(execute);

			// "C#! " is none.
			m_Debug1("Hello! ", "C#! ");

			Console.WriteLine();

			Debug m_Debug2 = execute;

			// plus execute2()
			m_Debug2 += new Debug(execute2);
			m_Debug2("Dance with ", "world!");

		}

		public int execute(String str1, String str2)
		{
			Console.Write(str1);
			return str2.Length;
		}

		public int execute2(String str1, String str2)
		{
			Console.Write(str2);
			return str1.Length;
		}
	}
}



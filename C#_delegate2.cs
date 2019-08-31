using System;

namespace delegate2
{
	class D_Sample
	{
		public delegate int Debug(String str1, String str2);

		static void Main(string[] args)
		{
			D_Sample d_sam = new D_Sample();
			d_sam.exec();

			Console.Read();
		}

		public void exec()
		{
			Debug Debug1 = new Debug(delegate (String str1, String str2)
			{
				Console.Write(str1);
				Console.Write(str2);
				return str2.Length;				
			});

			Debug1("Hello! ", "C# ");

			Debug Debug2 = delegate (String str1, String str2)
			{
				Console.Write(str1);
				return str2.Length;
			};

			// "!!!" is none.
			Debug2("Dance with me!", "!!!");
		}
	}
}


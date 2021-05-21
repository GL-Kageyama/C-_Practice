using System;

namespace delegate2
{
    class DelegateClass
    {
        public delegate int Debug(String str1, String str2);

        static void Main(string[] args)
        {
            DelegateClass delegateClass = new DelegateClass();

            delegateClass.exec();
        }

        public void exec()
        {
            Debug debug1 = new Debug(delegate (String str1, String str2)
            {
                Console.Write(str1);
                Console.Write(str2);
                return str2.Length;
            });

            debug1("Hello! ", "C# ");
            Console.WriteLine();

            Debug debug2 = delegate (String str1, String str2)
            {
                Console.Write(str1);
                return str2.Length;
            };

            // "!!!" is none.
            debug2("Dance with me!", "!!!");
            Console.WriteLine();
        }
    }
}


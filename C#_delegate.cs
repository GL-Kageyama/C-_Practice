using System;

namespace delegateSample
{
    class Sample
    {
        public delegate int Debug(String str1, String str2);

        static void Main(string[] args)
        {
            Sample sample = new Sample();

            sample.exec();
        }

        public void exec()
        {
            // plus execute()
            Debug debug1 = new Debug(execute);

            // "C#! " is none.
            debug1("Hello! ", "C#! ");

            Console.WriteLine();

            Debug debug2 = execute;

            // plus execute2()
            debug2 += new Debug(execute2);
            debug2("Dance with ", "world!");

            Console.WriteLine();
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
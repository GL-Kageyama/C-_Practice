using System;

namespace lambdaSample
{
    class LambdaClass
    {
        static void Main(string[] args)
        {
            LambdaClass lambdaClass = new LambdaClass();

            lambdaClass.exec();
        }

        public void exec()
        {
            Func<string, string, int> debug1 = (string str1, string str2) =>
            {
                Console.Write(str1);
                return str2.Length;
            };

            debug1("Hello lambda !", "Feel so good !");
            Console.WriteLine();

            Func<string, string, int> debug2 = (string str1, string str2) => str1.Length + str2.Length;

            int count = debug2("Hello lambda !", "Feel so good !");
            Console.Write(count);
            Console.WriteLine();
        }
    }
}
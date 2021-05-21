using System;

namespace FuncActionSample
{
    class FuncAction
    {
        static void Main(string[] args)
        {
            FuncAction funcAction = new FuncAction();

            funcAction.exec();
        }

        public void exec()
        {
            // Func have a Return value.
            Func<string, string, int> debug1 = delegate(string str1, string str2)
            {
                Console.Write(str1);
                return str2.Length;
            };

            debug1("Func is good.", "I'm fine.");
            Console.WriteLine();

            // Action haven't Return value.
            Action <string, string> debug2 = delegate(string str1, string str2)
            {
                Console.Write(str1);
            };

            debug2("Action is good.", "How are you?");
            Console.WriteLine();
        }
    }
}
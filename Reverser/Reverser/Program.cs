using System;
using System.IO;

namespace Reverser
{
    class Program
    {
        static void Main(string[] args)
        {
            var reverser = new Reverser();

            if (args.Length < 2)
                throw new ArgumentException("Must Have 2 Arguments");

            if (!File.Exists(args[0]))
                throw new ArgumentException("Source Must Exist");

            var source = File.ReadAllText(args[0]);
            File.WriteAllText(args[1], reverser.Reverse(source));
        }
    }
}

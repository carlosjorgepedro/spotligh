using System;

namespace WordSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(args[0]);
            var word = args[1];

            var wordSearcher = new WordSearcher(new WordListReader());

            var searchTask = wordSearcher.SearchAsync(size, word);

            searchTask.Wait();

            var result = searchTask.Result;

            foreach (var w in result)
            {
                Console.WriteLine(w);
            }

        }
    }
}

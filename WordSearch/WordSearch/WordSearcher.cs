using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearch
{
    public class WordSearcher
    {
        private IWordListReader wordListReader;

        public WordSearcher(IWordListReader wordListReader)
        {
            this.wordListReader = wordListReader;
        }

        public async Task<IEnumerable<string>> SearchAsync(int size, string word)
        {
            var words = await wordListReader.GetWords();
            var match = words
                .Where(x => x.Length == size)
                .Where(x => x.Select(c => word.Contains(c)).All(b => b == true))
                .OrderBy(x => x);

            return match;
        }
    }
}

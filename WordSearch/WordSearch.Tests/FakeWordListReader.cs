using System.Threading.Tasks;

namespace WordSearch.Tests
{
    class FakeWordListReader : IWordListReader
    {
        public Task<string[]> GetWords()
        {
            return Task.FromResult(new[] { "ababababrrr" ,
                "mnrealsss\r\n",
                "html", "mlht", "xHtml", "zzaa" });
        }
    }
}

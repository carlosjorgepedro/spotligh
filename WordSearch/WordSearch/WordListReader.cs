using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace WordSearch
{
    public class WordListReader : IWordListReader
    {
        private readonly string url = "https://s3-eu-west-1.amazonaws.com/spotlight-tech-test/wordlist.txt";

        public async Task<string[]> GetWords()
        {
            using (var httpClient = new HttpClient())
            {
                var httpResult = await httpClient.GetAsync(new Uri(url));
                var result = await httpResult.Content.ReadAsStringAsync();
                return result.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            }

        }
    }
}

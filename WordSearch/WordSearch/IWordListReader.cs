using System.Threading.Tasks;

namespace WordSearch
{
    public interface IWordListReader
    {
        Task<string[]> GetWords();
    }
}

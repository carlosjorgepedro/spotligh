using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordSearch.Tests
{
    [TestClass]
    public class WordListReaderTest
    {
        IWordListReader suject = new WordListReader();
        [TestMethod, TestCategory("Integration")]
        public async Task GetWordsTest()
        {
            var words = await suject.GetWords();
            Assert.IsTrue(words.Count() > 0);
        }
    }
}

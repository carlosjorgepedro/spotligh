using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordSearch.Tests
{ 
    [TestClass]
    public class WordSearcherTest
    {
        WordSearcher subject = new WordSearcher(new FakeWordListReader());
        [TestMethod]
        public async Task NoWordsReturnLargeLength()
        {
            var result = await subject.SearchAsync(20, "real");

            Assert.AreEqual(0, result.Count());
        }
        [TestMethod]
        public async Task IfNotAllLetterInWordFound()
        {
            var result = await subject.SearchAsync(3, "xml");

            Assert.AreEqual(0, result.Count());
        }

        [TestMethod]
        public async Task IfLettersFoundLenthNotMatch()
        {
            var result = await subject.SearchAsync(2, "html");

            Assert.AreEqual(0, result.Count());
        }

        [TestMethod]
        public async Task MatchLettersRightSize()
        {
            var result = await subject.SearchAsync(4, "html");

            Assert.AreEqual(2, result.Count());
        }
    }
}

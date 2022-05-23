using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using UtilityLibrary;

namespace UtilityLibraryTests
{
    [TestClass]
    public class TextExaminerTests
    {
        [TestMethod]
        public void HappyPathTestForExamineClassifiedString()
        {
            KeyValuePair<bool, string> result = TextExaminer.ExamineClassifiedString("I went to the school the other day.", "went, other");
            Assert.AreEqual(true, result.Key);
            Assert.AreEqual("I *** to the school the *** day.", result.Value);
        }

        [TestMethod]
        public void EmptyEmailAndNoNoWordsTestForExamineClassifiedString()
        {
            KeyValuePair<bool, string> result = TextExaminer.ExamineClassifiedString(string.Empty, string.Empty);
            Assert.AreEqual(false, result.Key);
            Assert.AreEqual(string.Empty, result.Value);
        }

        [TestMethod]
        public void NullEmailAndNoNoWordsTestForExamineClassifiedString()
        {
            KeyValuePair<bool, string> result = TextExaminer.ExamineClassifiedString(null, null);
            Assert.AreEqual(false, result.Key);
            Assert.AreEqual(null, result.Value);
        }

        [TestMethod]
        public void EmptyEmailTestForExamineClassifiedString()
        {
            KeyValuePair<bool, string> result = TextExaminer.ExamineClassifiedString(string.Empty, "went, other");
            Assert.AreEqual(false, result.Key);
            Assert.AreEqual(string.Empty, result.Value);
        }

        [TestMethod]
        public void EmptyNoNoWordsTestForExamineClassifiedString()
        {
            KeyValuePair<bool, string> result = TextExaminer.ExamineClassifiedString("I went to the school the other day.", string.Empty);
            Assert.AreEqual(false, result.Key);
            Assert.AreEqual("I went to the school the other day.", result.Value);
        }

        [TestMethod]
        public void NullEmailTestForExamineClassifiedString()
        {
            KeyValuePair<bool, string> result = TextExaminer.ExamineClassifiedString(null, "went, other");
            Assert.AreEqual(false, result.Key);
            Assert.AreEqual(null, result.Value);
        }

        [TestMethod]
        public void NullNoNoWordsTestForExamineClassifiedString()
        {
            KeyValuePair<bool, string> result = TextExaminer.ExamineClassifiedString("I went to the school the other day.", null);
            Assert.AreEqual(false, result.Key);
            Assert.AreEqual("I went to the school the other day.", result.Value);
        }

        [TestMethod]
        public void PhraseTestForExamineClassifiedString()
        {
            KeyValuePair<bool, string> result = TextExaminer.ExamineClassifiedString("I went to the school the other day.", "went to the, other");
            Assert.AreEqual(true, result.Key);
            Assert.AreEqual("I *** school the *** day.", result.Value);
        }
    }
}
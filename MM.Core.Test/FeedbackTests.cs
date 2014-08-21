using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MM.Core.Test
{
    [TestClass]
    public class FeedbackTests
    {
        private Feedback _fb;

        [TestInitialize]
        public void Setup()
        {
            _fb = new Feedback();
        }

        [TestMethod]
        public void GivesBlankFeedback()
        {
            Assert.AreEqual("", _fb.getFeedback("1111", "5478"));
        }

        [TestMethod]
        public void GivesFeedbackOfW()
        {
            Assert.AreEqual("W", _fb.getFeedback("1234", "5478"));
        }

        [TestMethod]
        public void GivesFeedbackOfB()
        {
            Assert.AreEqual("B", _fb.getFeedback("5231", "5478"));
        }

        [TestMethod]
        public void GivesFeedbackOfWW()
        {
            Assert.AreEqual("WW", _fb.getFeedback("1254", "5478"));
        }

        [TestMethod]
        public void GivesFeedbackOfBB()
        {
            Assert.AreEqual("BB", _fb.getFeedback("5431", "5478"));
        }

        [TestMethod]
        public void GivesFeedbackOfWWW()
        {
            Assert.AreEqual("WWW", _fb.getFeedback("4759", "5478"));
        }

        [TestMethod]
        public void GivesFeedbackOfBBB()
        {
            Assert.AreEqual("BBB", _fb.getFeedback("5479", "5478"));
        }

        [TestMethod]
        public void GivesFeedbackOfWWWW()
        {
            Assert.AreEqual("WWWW", _fb.getFeedback("8547", "5478"));
        }

        [TestMethod]
        public void GivesFeedbackOfBWWW()
        {
            Assert.AreEqual("BWWW", _fb.getFeedback("5847", "5478"));
        }

        [TestMethod]
        public void GivesFeedbackOfBBWW()
        {
            Assert.AreEqual("BBWW", _fb.getFeedback("5487", "5478"));
        }
    }
}

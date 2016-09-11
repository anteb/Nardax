using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Nardax.UnitTests
{
    [TestClass]
    public class QueueExtensionsTests
    {
        Queue<string> _queue;

        public QueueExtensionsTests()
        {
            _queue = new Queue<string>();
            _queue.Enqueue("aa");
            _queue.Enqueue("bb");
            _queue.Enqueue("cc");
        }

        [TestMethod]
        public void EnqueueRangeTest()
        {
            _queue.EnqueueRange(new[] { "dd", "ee" });

            Assert.AreEqual("aa", _queue.Dequeue());
        
    }
}

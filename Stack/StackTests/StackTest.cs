using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Stack;

namespace StackTests
{
    [TestFixture]
    public class StackTest
    {
        // Create a new object and check that initial size is zero
        [Test]
        public void Creation()
        {
            Stack<int> s = new Stack<int>(3);
            Assert.AreEqual(0, s.Size);
        }
    }
}

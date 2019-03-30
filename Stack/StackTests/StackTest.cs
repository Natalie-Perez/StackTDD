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

        [Test]
        public void Push_Pop()
        {
            Stack<int> s = new Stack<int>(3);

            s.Push(1);
            s.Push(2);
            s.Push(3);
            int value = s.Pop();

            Assert.AreEqual(3, value);
            Assert.AreEqual(2, s.Size);
        }

        // Throw exception when you try to pop an element when there's none in the stack
        [Test]
        public void Too_Much_Pop()
        {
            Stack<int> s = new Stack<int>(3);
            Assert.Throws<ExpenditureProhibitedException>(() => s.Pop());
        }

        // Throw exception when trying to push new element on a full stack
        [Test]
        public void Too_Much_Push()
        {
            Stack<int> s = new Stack<int>(3);
            s.Push(1);
            s.Push(2);
            s.Push(3);
            Assert.Throws<ExceededSizeException>(() => s.Push(4));
        }

        // Peek the last element to see if stack is empty
        [Test]
        public void Peek_Exception()
        {
            Stack<int> s = new Stack<int>(3);
            Assert.Throws<ExpenditureProhibitedException>(() => s.Peek());
        }

        [Test]
        public void Peek_Element()
        {
            Stack<int> s = new Stack<int>(3);

            s.Push(1);
            s.Push(2);
            int value = s.Peek();

            Assert.AreEqual(2, value);
            Assert.AreEqual(2, s.Size);
        }
    }
}

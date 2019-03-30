using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    #region CustomExceptions
    public class ExceededSizeException : Exception { }
    public class ExpenditureProhibitedException : Exception { };
    #endregion

    public class Stack<T>
    {
        #region Members
        private T[] stackArray;
        private int maximumLength;
        #endregion

        #region Properties
        public int Size { get; private set; }
        #endregion

        #region Constructor
        public Stack(int length)
        {
            maximumLength = length;
            stackArray = new T[length];
        }
        #endregion

        #region Public Methods
        public void Push(T value)
        {
            if (Size == maximumLength)
            {
                throw new ExceededSizeException();
            }

            stackArray[Size++] = value;
        }

        public T Pop()
        {
            if (Size == 0)
            {
                throw new ExpenditureProhibitedException();
            }

            return stackArray[--Size];
        }
        #endregion
    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PrintInOrder
{
    public class Foo
    {
        class Lock
        {
            public int Step;
        }

        static Lock _Lock = new Lock() { Step = 0 };

        public Foo()
        {

        }

        public void First(Action printFirst)
        {
            lock (_Lock)
            {
                // printFirst() outputs "first". Do not change or remove this line.
                printFirst();
                _Lock.Step = 1;
                Monitor.PulseAll(_Lock);
            }
        }

        public void Second(Action printSecond)
        {
            lock (_Lock)
            {
                while (_Lock.Step != 1)
                {
                    Monitor.Wait(_Lock);
                }
                // printSecond() outputs "second". Do not change or remove this line.
                printSecond();
                _Lock.Step = 2;
                Monitor.PulseAll(_Lock);
            }
        }

        public void Third(Action printThird)
        {
            lock (_Lock)
            {
                while (_Lock.Step != 2)
                {
                    Monitor.Wait(_Lock);
                }
                // printThird() outputs "third". Do not change or remove this line.                
                printThird();
                _Lock.Step = 3;
                Monitor.PulseAll(_Lock);
            }
        }
    }
}

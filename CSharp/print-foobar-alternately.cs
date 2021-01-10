using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSharp
{
    public class FooBar
    {

        class Lock
        {
            public int step = 0;
        }

        private Lock _lock = new Lock();

        private int n;

        public FooBar(int n)
        {
            this.n = n;
        }

        public void Foo(Action printFoo)
        {

            for (int i = 0; i < n; i++)
            {
                lock (_lock)
                {
                    while (_lock.step != 0)
                    {
                        Monitor.Wait(_lock);
                    }
                    // printFoo() outputs "foo". Do not change or remove this line.
                    printFoo();
                    _lock.step = 1;
                    Monitor.Pulse(_lock);
                }
            }
        }

        public void Bar(Action printBar)
        {

            for (int i = 0; i < n; i++)
            {
                lock (_lock)
                {
                    while (_lock.step != 1)
                    {
                        Monitor.Wait(_lock);
                    }
                    // printBar() outputs "bar". Do not change or remove this line.
                    printBar();
                    _lock.step = 0;
                    Monitor.Pulse(_lock);
                }
            }
        }
    }
}

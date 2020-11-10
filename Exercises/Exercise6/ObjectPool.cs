using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Exercise6
{
    public class ObjectPool<T> where T : IExportingProcess, new()
    {
        private static object _lock = new object();
        private ConcurrentQueue<T> Pool;
        private Thread thread;
        private System.Timers.Timer timer;
        //private CancellationTokenSource cts = new CancellationTokenSource();

        public ObjectPool(int minObjects)
        {
            initialize(minObjects);
        }

        public ObjectPool(int minObjects, int maxObjects, long validationInterval)
        {
            initialize(minObjects);

            timer = new System.Timers.Timer();
            timer.Elapsed += new ElapsedEventHandler(Shutdown);
            timer.Interval = (100 * validationInterval);
            timer.Enabled = true;

            Task.Factory.StartNew(() => {
                thread = Thread.CurrentThread;

                while (true) {
                    int size = Pool.Count;

                    if (size < minObjects)
                    {
                        int sizeToBeAdded = minObjects + size;
                        for (int i = 0; i < sizeToBeAdded; i++)
                        {
                            Pool.Enqueue(CreateObject());
                        }
                    }
                    else if (size > maxObjects)
                    {
                        int sizeToBeRemoved = size - maxObjects;
                        for (int i = 0; i < sizeToBeRemoved; i++)
                        {
                            Pool.TryDequeue(out T item);
                        }
                    }
                }
            });
        }

        protected T CreateObject()
        {
            return (T)new T().Setup(GetNewProccessNo());
        }

        public T BorrowObject()
        {
            T @object;

            if(Pool.TryDequeue(out @object) == false)
            {
                @object = CreateObject();
            }

            return @object;
        }

        public void ReturnObject(T @object)
        {
            if (@object == null)
                return;

            this.Pool.Enqueue(@object);
        }

        public void Shutdown(object source, ElapsedEventArgs e)
        {
            if(thread != null)
            {
                if(timer!=null && timer.Enabled)
                {
                    timer.Stop();
                }

                thread.Interrupt();
            }
        }

        private void initialize(int minObjects)
        {
            Pool = new ConcurrentQueue<T>();

            for (int i = 0; i < minObjects; i++)
            {
                Pool.Enqueue(CreateObject());
            }
        }

        private long GetNewProccessNo()
        {
            T biggest;

            lock (_lock)
            {
                biggest = this.Pool.OrderByDescending(a => a.ProcessNo).FirstOrDefault();
            }

            if(biggest != null)
            {
                var num = biggest.ProcessNo;
                Interlocked.Increment(ref num);
                return num;
            }
            else
            {
                return 1;
            }
        }
    }
}

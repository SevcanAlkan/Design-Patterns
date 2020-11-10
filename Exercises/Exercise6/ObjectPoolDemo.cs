using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Timers;

namespace Exercise6
{
    public class ObjectPoolDemo
    {
        private ObjectPool<ExportingProcess> pool;
        private long processNo = new long();
        private System.Timers.Timer timer;
        private List<Thread> threads = new List<Thread>();
        private int threadNum = 0;

        public void setup()
        {
            pool = new ObjectPool<ExportingProcess>(4, 10, 5);
        }

        public void StartThread()
        {
            Thread t = new Thread(() => { new ExportingTask(pool, threadNum + 1); });
            threads.Add(t);
        }


        public void testOjectPool()
        {
            timer = new System.Timers.Timer();
            timer.Elapsed += new ElapsedEventHandler(Shutdown);
            timer.Interval = (300);

            for (int i = 0; i < 8; i++)
            {
                StartThread();
            }

            foreach (var t in threads)
            {
                t.Start();
            }

            timer.Enabled = true;

        }

        public void tearDown()
        {
            pool.Shutdown(null, null);
        }

        public void Shutdown(object source, ElapsedEventArgs e)
        {
            if (threads != null)
            {
                if (timer != null && timer.Enabled)
                {
                    timer.Stop();
                }

                foreach (var item in threads)
                {
                    item.Interrupt();
                }                
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise6
{
    public class ExportingTask
    {
        private ObjectPool<ExportingProcess> pool;
        private int threadNo;

        public ExportingTask(ObjectPool<ExportingProcess> pool, int threadNo)
        {
            this.pool = pool;
            this.threadNo = threadNo;
        }

        public void Run()
        {
           var exportingProcess = pool.BorrowObject();

            Console.WriteLine($"Thread {threadNo} process no {exportingProcess.ProcessNo} was borred");

            pool.ReturnObject(exportingProcess);

            Console.WriteLine($"Thread {threadNo} process no {exportingProcess.ProcessNo} was returned");
        }
    }
}

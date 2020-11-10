using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise6
{
    public class ExportingProcess : IExportingProcess
    {
        public long ProcessNo { get; private set; }

        public ExportingProcess()
        {
        }

        public IExportingProcess Setup(long proccessNo)
        {
            if(this.ProcessNo == 0 || this.ProcessNo == null)
            {
                this.ProcessNo = proccessNo;            

                Console.WriteLine($"Object with process no: {ProcessNo} was created.");
            }

            return this;
        }
    }

    public interface IExportingProcess
    {
        public long ProcessNo { get; }

        public IExportingProcess Setup(long proccessNo);
    }
}

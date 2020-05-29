using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Simafor.Model
{
    public class ModelSimafor: IModelSimafor
    {
        private List<NewThread> myThreads;
        private List<NewThread> waitThreads;
        private static Semaphore semaphore;

        const string SemaphoreGuid = "99BEDCAF-DB63-42CC-A92E-0FF83D9CC23E";
        public ModelSimafor()
        {
            myThreads = new List<NewThread>();
            waitThreads = new List<NewThread>();
            semaphore = new Semaphore(3, 3, SemaphoreGuid);
            CountWork = 0;
            SimFull = false;
            ThreadNum = 1;
        }
        public bool SimFull { get; set; }
        public int CountWork { get; set; }
        public int ThreadNum { get; set; }
        public List<NewThread> MyThreads { get => myThreads; set => myThreads = value; }
        public List<NewThread> WaitThreads { get => waitThreads; set => waitThreads = value; }
        public void CreateThread()
        {
            MyThreads.Add(new NewThread(ThreadNum, semaphore));
            ThreadNum++;
        }
        public void NewDoubleClick(int select)
        {
            IsHavePlase();
            WaitThreads.Add(MyThreads[select]);
            CountWork++;
            MyThreads.RemoveAt(select);
        }

        public void IsHavePlase()
        {
            if(!semaphore.WaitOne(0))
                SimFull = true;
            else
                SimFull = false;

        }
    }
}

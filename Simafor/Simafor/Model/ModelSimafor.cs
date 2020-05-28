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

        }
        public List<NewThread> MyThreads { get => myThreads; set => myThreads = value; }
        public List<NewThread> WaitThreads { get => waitThreads; set => waitThreads = value; }
        public void CreateThread()
        {
            if (MyThreads.Count > 0)
                MyThreads.Add(new NewThread(MyThreads.Count + 1, semaphore));
            else
                MyThreads.Add(new NewThread(1, semaphore));
        }
        public void NewDoubleClick(int select)
        {
             WaitThreads.Add(MyThreads[select]);
             MyThreads.RemoveAt(select);
        }
    }
}

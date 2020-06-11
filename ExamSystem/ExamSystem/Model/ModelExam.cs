using ExamSystem.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamSystem.Model
{
    public class ModelExam : IModelExam
    {
        private List<string> words;
        private static Mutex _mutex;
        private readonly BackgroundWorker worker = new BackgroundWorker();
        public event EventHandler<ProgressChangedEventArgs> Progress;

        public string NewWord { get; set; }
        public List<string> Words { get => words; set => words = value; }
        public bool Pause { get; set; }
        public bool Continium { get; set; }


        public ModelExam()
        {
            NewWord = string.Empty;
            words = new List<string>();

            _mutex = new Mutex(true, "EE347C87-C857-435B-ADEB-2CF1252DEFC5", out bool createdNew);
            if (createdNew == false)
            {
                IntPtr handle = WinApi.FindWindow(null, "Change World");
                if (handle != IntPtr.Zero)
                {
                    if (WinApi.IsIconic(handle))
                        WinApi.ShowWindow(handle, WinApi.SW_RESTORE);
                    WinApi.SetForegroundWindow(handle);
                }
                _mutex.ReleaseMutex();
                Environment.Exit(0);
            }

            Pause = false;
            Continium = false;
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            // Обработчик, позволяющий работать с UI (т.е., взаимодействующий с формой и ее контролам)
            worker.ProgressChanged += new ProgressChangedEventHandler(worker_ProgressChanged);
            // Обработчик, вызываемый по окончанию фоновой работы
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);

            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
        }

        public void AddFromFile()
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            var word = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\Users\\MOB_master\\Desktop";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }

                    foreach (var item in fileContent)
                    {
                        if (item != ' ' && item != '\r')
                            word += item;
                        else
                        {
                            if (word != string.Empty)
                            {
                                Words.Add(word);
                                word = string.Empty;
                            }
                            continue;
                        }
                    }
                }
            }
        }
        public void CloseForm()
        {
           _mutex.ReleaseMutex();
        }

        public  void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            // ВАЖНО: Здесь никогда не обращайтесь к UI (т.е., к форме и ее контролам)

            // Выполняем длительную операцию...
            for (int i = 1; i <= 100; i++)
            {
                // Здесь в боевых проектах мы будем делать какую-то полезную работу
                Thread.Sleep(100);

                // Сообщаем о проценте выполненной работы (необходимо для реализации
                // взаимодействия с GUI — обновления текста и состояния полосы прогресса)
                worker.ReportProgress(i);

                // Если была нажата кнопка Cancel, то сообщаем о необходимости обновить текст
                // и состояние полосы прогресса и заканчиваем асинхронную операцию
                if (worker.CancellationPending)
                {
                    worker.ReportProgress(0);

                    e.Cancel = true;
                    return;
                }
                if (Pause)
                {
                    for (; ; )
                    {
                        Thread.Sleep(100);
                        if (worker.CancellationPending)
                        {
                            Pause = false;
                            btnCancel_Click(sender, EventArgs.Empty);
                            break;
                        }
                        if(Continium)
                        {
                            Pause = false;
                            Continium = false;
                            break;
                        }
                    }
                }
            }

            // Сообщаем о необходимости обновить текст и состояние полосы
            // прогресса с информацией о 100% завершении работы
            worker.ReportProgress(100);
        }

        // Обработчик, работающий с UI (т.е., взаимодействующий с формой и ее контролам)
        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Progress(sender, e);
        }

        // Обработчик, вызываемый по окончанию фоновой работы
        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            /*if (e.Cancelled)
                labelStatus.Text = "Task Canceled.";
            else if (e.Error != null)
                labelStatus.Text = "Error while performing background operation.";
            else
                labelStatus.Text = "Task Completed.";

            btnStartAsyncOperation.Enabled = true;
            btnCancel.Enabled = false;*/
        }

        public void btnStartAsyncOperation_Click(object sender, EventArgs e)
        {
            //btnStartAsyncOperation.Enabled = false;
            //btnCancel.Enabled = true;
            // Запускаем асинхронную операцию
            worker.RunWorkerAsync();
        }

        public void btnCancel_Click(object sender, EventArgs e)
        {
            if (worker.IsBusy)
                // Останавливаем асинхронную операцию
                worker.CancelAsync();
        }
        public void btnPause_Click(object sender, EventArgs e)
        {
            if (worker.IsBusy)
            {
                Pause = true;
            }    
        }
        public void btnContinue_Click(object sender, EventArgs e)
        {
            if (worker.IsBusy)
            {
                Continium = true;
            }
        }

    }
}

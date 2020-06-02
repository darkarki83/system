using ExamSystem.Model;
using ExamSystem.Presenter;
using System;
using System.Windows.Forms;

namespace ExamSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            PresenterExam presenter = new PresenterExam(new ModelExam(), new FormExam());
            Application.Run((Form)presenter.View);
        }
    }
}

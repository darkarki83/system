using ExamSystem.Common;
using ExamSystem.Model;
using ExamSystem.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamSystem.Presenter
{
    public class PresenterExam : BasePresenter<IFormExam>
    {
        public IModelExam Model { get; set; }
        public PresenterExam(IModelExam model, IFormExam view)
        {
            Model = model;
            this.View = view;
            View.AddWord += AddWords;
            View.AddFromFile += AddFromFile;
            View.StartSearch += StartSearch;

            View.CloseForm += CloseForm;
            Model.Progress += OurProgress;
        }
        public void AddWords(object sender, EventArgs e)
        {
            var presenterAdd = new PresenterAddWord(Model, new FormAddWord());
            ((Form)presenterAdd.View).ShowDialog();
            if(Model.NewWord.Length > 0)
            {
                Model.Words.Add(Model.NewWord);
                Model.NewWord = string.Empty;
                View.ListBoxWord.Items.Add(Model.Words[Model.Words.Count - 1]);
            }
        }

        public void AddFromFile(object sender, EventArgs e)
        {
            Model.AddFromFile();
            if (View.ListBoxWord.Items.Count > 0)
            {
                for (int i = View.ListBoxWord.Items.Count; i < Model.Words.Count; i++)
                {
                    View.ListBoxWord.Items.Add(Model.Words[i]);
                }
            }
            else
            {
                for (int i = 0; i < Model.Words.Count; i++)
                {
                    View.ListBoxWord.Items.Add(Model.Words[i]);
                }
            }
        }
        public void StartSearch(object sender, EventArgs e)
        {
            Model.btnStartAsyncOperation_Click(sender, e);
        }


        public void CloseForm(object sender, EventArgs e)
        {
            Model.CloseForm();
        }
        public void OurProgress(object sender, ProgressChangedEventArgs e)
        {
            View.Progress.Value = e.ProgressPercentage;
            View.LabelProgres.Text = $"Processing... {View.Progress.Value}%";
        }
    }
}

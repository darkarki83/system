using ExamSystem.Common;
using ExamSystem.Model;
using ExamSystem.Views;
using System;
using System.Collections.Generic;
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
            //View.NewWord += AddWord;
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
    }
}

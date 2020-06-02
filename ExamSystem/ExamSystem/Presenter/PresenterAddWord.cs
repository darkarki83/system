using ExamSystem.Common;
using ExamSystem.Model;
using ExamSystem.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Presenter
{
    public class PresenterAddWord : BasePresenter<IFormAddWord>
    {
        public IModelExam Model { get; set; }
        public PresenterAddWord(IModelExam model, IFormAddWord view)
        {
            Model = model;
            View = view;
            View.AddNewW += AddNewW;
        }

        public void AddNewW(object sender, EventArgs e)
        {
            Model.NewWord = View.NewWord;
        }
    }
}

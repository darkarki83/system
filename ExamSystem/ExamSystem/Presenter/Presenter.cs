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
    public class Presenter : BasePresenter<IFormExam>
    {
        public IModelExam Model { get; set; }
        public Presenter(IModelExam model, IFormExam view)
        {
            Model = model;
            View = view;

        }
    }
}

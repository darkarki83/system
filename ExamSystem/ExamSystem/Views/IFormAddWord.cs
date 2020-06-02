using ExamSystem.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Views
{
    public interface IFormAddWord : IView
    {
        string NewWord { get ; set; }
        event EventHandler AddNewW;
    }
}

using ExamSystem.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamSystem.Views
{
    public interface IFormExam : IView
    {
        event EventHandler AddWord;
        event EventHandler AddFromFile;
        event EventHandler CloseForm;
        event EventHandler StartSearch;

        ListBox ListBoxWord { get; set; }
        ProgressBar Progress { get; set; }
        System.Windows.Forms.Label LabelProgres { get; set; }

    }
}

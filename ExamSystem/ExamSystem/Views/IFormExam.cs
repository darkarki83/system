﻿using ExamSystem.Common;
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
        ListBox ListBoxWord { get; set; }

    }
}
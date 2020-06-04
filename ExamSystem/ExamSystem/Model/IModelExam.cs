﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Model
{
    public interface IModelExam
    {
        event EventHandler<ProgressChangedEventArgs> Progress;

        string NewWord { get; set; }
        List<string> Words { get; set; }
        void AddFromFile();
        void worker_DoWork(object sender, DoWorkEventArgs e);
        void btnStartAsyncOperation_Click(object sender, EventArgs e);
        void CloseForm();
    }
}

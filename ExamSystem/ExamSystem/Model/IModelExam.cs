﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Model
{
    public interface IModelExam
    {
        string NewWord { get; set; }
        List<string> Words { get; set; }
    }
}
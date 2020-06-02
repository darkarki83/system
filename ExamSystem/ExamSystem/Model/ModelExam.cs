using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.Model
{
    public class ModelExam : IModelExam
    {
        private List<string> words;
        public string NewWord { get; set; }
        public List<string> Words { get => words; set => words = value; }

        public ModelExam()
        {
            NewWord = string.Empty;
            words = new List<string>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Maker.Model
{
    public class Report
    {
        public string Text { get; set; }
        public List<string> Options { get; set; }


        public int RightAnswersCount{ get; set; }
        public int WrongAnswersCount{ get; set; }
        public int UnansweredQuestionsCount{ get; set; }
        public int TotalQuestionsCount{ get; set; }

        public string GetResult()
        {
            return $"Right Answers Count: {RightAnswersCount}\nWrong Answers Count:{WrongAnswersCount}\nUnanswered Questions Count:{UnansweredQuestionsCount}\nTotal Questions Count:{TotalQuestionsCount}";
        }
        public string ToStringObject()
        {
            string options = string.Empty;

            for (int i = 0; i < Options.Count; i++)
            {
                options += Options[i];
                if (i != Options.Count - 2)
                {
                   options += "\n";
                }
            }
            return $"{Text}{options}";
        }
    }


}

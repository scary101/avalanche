using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whooooo
{
    internal class Test
    {
        public string nameQuest { get; set; }
        public string discruption { get; set; }
        public string answerFirst {  get; set; }
        public string answerSecond { get; set; }
        public string answerThird { get; set; }
        public TrueAnswer trueAnswer { get; set;}
    }

    public enum TrueAnswer
    {
        First,
        Second,
        Third
    }


}

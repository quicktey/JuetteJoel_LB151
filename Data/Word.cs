using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuetteJoel_LB151.Data
{
    public class Word
    {
        public string word { get; set; }
        public string category { get; set; }

        public Word() { }
        public Word(string word, string category)
        {
            this.word = word;
            this.category = category;
        }
    }
}
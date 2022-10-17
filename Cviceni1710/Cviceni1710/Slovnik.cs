using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni1710
{
    internal class Slovnik
    {

        private string czech;
        private string english;
        Dictionary<string, string> dic;


        public Slovnik(string czech, string english)
        {
            this.czech = czech;
            this.english = english;
        }

        public void addWord(Slovnik word)
        {
            dic.Add(word.czech, word.english);
        }

        public string Czech
        {
            get { return czech; }
            set { czech = value; }
        }
        public string English
        {
            get { return english; }
            set { english = value; }
        }
    }
}

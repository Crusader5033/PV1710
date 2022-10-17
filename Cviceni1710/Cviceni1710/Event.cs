using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni1710
{
    public enum Typ
        {
            System,
            Hardware,
            Aplikace
        }
        public enum Uroven
        {
            Informace,
            Varovani,
            Chyba
        }
    internal class Event
    {
       

        private string popis;
        private Typ typ;
        private Uroven uroven;


        public void SetUroven(Uroven value)
        {
            uroven = value;
        }

       
        public void SetTyp(Typ value)
        {
            typ = value;
        }

        


        public Event(string popis, Typ typ, Uroven uroven)
        {
            this.popis = popis;
            this.typ = typ;
            this.uroven = uroven;

        }
        public string Popis
        {
            get { return popis; }   
            set { popis = value; } 
        }


        public Event FindSamer(List<Event> list, Typ typ1, Uroven uroven1)
        {
            List<Event> list1 = new List<Event>();
            for (var i = 0; i < list.Count; i++)
            {
                if (this.typ.Equals( typ1) && this.uroven.Equals(uroven1))
                {
                    list1.Add(this);

                }
            }
            return list1;




        }



    }
}

namespace Cviceni1710
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Event e1 = new Event("Nějaka chyba", Typ.Hardware, Uroven.Informace);
            Event e2 = new Event("Nějaka další chyba", Typ.Hardware, Uroven.Informace);
            Event e3 = new Event("Nějaka super chyba", Typ.Hardware, Uroven.Informace);
            Event e4 = new Event("Nějaka chyba", Typ.Aplikace, Uroven.Chyba);

            List<Event> list = new List<Event>();
            list.Add(e1);
            list.Add(e2);
            list.Add(e3);
            list.Add(e4);

            





        }
        public static void FindSame(List<Event> list, Typ typ1, Uroven uroven1)
        {

            foreach (Event e in list)
            {
                if (e.)
                {


                }
            }








        }
    }
}
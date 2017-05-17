using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overerven_van_een_lijst
{
    class NamenLijst : List<string> { }
    //class klasse : String { } //je kan niet overerven van een SEALED class zoals String.
    public static class MyExtensions
    {
        public static int WordCount(this String str) //extensionmethod (WordCount) als aanvulling op een sealed class (String)
        {
            return str.Split(new char[] { ' ', '.', '?' },
                             StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string huppekee = "joske is awesome";
            Console.WriteLine(huppekee.WordCount());

            NamenLijst namen = new NamenLijst() {"Liam","Loes","Tom","Karam","Wout","Michiel","Timour", "Mathias", "Eline", "Billy" };
            foreach (var naam in namen)
            {
                Console.WriteLine(naam);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Material Empty = new Material();
            Empty.SetName("Empty");
            Material Steal = new Material();
            Steal.SetName("Steal");
            Material Stick = new Material();
            Stick.SetName("Stick");

            Material NewObject = new Material();
            NewObject = Steal + Steal + Empty + Steal + Stick + Empty + Empty + Stick + Empty;
            //Steal + Steal + Empty
            //Steal + Stick + Empty
            //Empty + Stick + Empty
            Console.WriteLine("Steal + Steal + Empty\nSteal + Stick + Empty\nEmpty + Stick + Empty\n  Object - {0}", NewObject.GetName());
            Console.ReadLine();

            NewObject = Steal + Steal + Steal + Empty + Stick + Empty + Empty + Stick + Empty;
            //Steal + Steal + Steal
            //Empty + Stick + Empty
            //Empty + Stick + Empty
            Console.WriteLine("Steal + Steal + Steal\nEmpty + Stick + Empty\nEmpty + Stick + Empty\n  Object - {0}", NewObject.GetName());
            Console.ReadLine();

            NewObject = Empty + Steal + Empty + Empty + Stick + Empty + Empty + Stick + Empty;
            //Empty + Steal + Steal
            //Empty + Stick + Empty
            //Empty + Stick + Empty
            Console.WriteLine("Empty + Steal + Empty\nEmpty + Stick + Empty\nEmpty + Stick + Empty\n  Object - {0}", NewObject.GetName());
            Console.ReadLine();
           
        }
    }
}

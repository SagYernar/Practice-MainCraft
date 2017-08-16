using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Material
    {
        private string name;
        private int hardness;
        private int weight;

        void Vaterial() { }
        public string GetName()
        {
            return name;
        }
        public void SetName(string str)
        {
            name = str;
        }
        public static Material operator +(Material fop, Material sop)
        {
            if (fop.name == "Empty" && sop.name == "Steal")
            {
                Material nop = new Material();
                nop.SetName("ES");
                return nop;
            }
            else if (fop.name == "ES" && sop.name == "Empty")
            {
                Material nop = new Material();
                nop.SetName("ESE");
                return nop;
            }
            else if (fop.name == "ESE" && sop.name == "Empty")
            {
                Material nop = new Material();
                nop.SetName("ESEE");
                return nop;
            }
            else if (fop.name == "ESEE" && sop.name == "Stick")
            {
                Material nop = new Material();
                nop.SetName("ESEESt");
                return nop;
            }
            else if (fop.name == "ESEESt" && sop.name == "Empty")
            {
                Material nop = new Material();
                nop.SetName("ESEEStE");
                return nop;
            }
            else if (fop.name == "ESEEStE" && sop.name == "Empty")
            {
                Material nop = new Material();
                nop.SetName("ESEEStEE");
                return nop;
            }
            else if (fop.name == "ESEEStEE" && sop.name == "Stick")
            {
                Material nop = new Material();
                nop.SetName("ESEEStEESt");
                return nop;
            }
            else if (fop.name == "ESEEStEESt" && sop.name == "Empty")
            {
                Material nop = new Material();
                nop.SetName("StealShovel");
                nop.hardness = 10;
                nop.weight = 3;
                return nop;
            }

            else if (fop.name == "Steal" && sop.name == "Steal")
            {
                Material nop = new Material();
                nop.SetName("SS");
                return nop;
            }
            else if (fop.name == "SS" && sop.name == "Steal")
            {
                Material nop = new Material();
                nop.SetName("SSS");
                return nop;
            }
            else if (fop.name == "SSS" && sop.name == "Empty")
            {
                Material nop = new Material();
                nop.SetName("SSSE");
                return nop;
            }
            else if (fop.name == "SSSE" && sop.name == "Stick")
            {
                Material nop = new Material();
                nop.SetName("SSSESt");
                return nop;
            }
            else if (fop.name == "SSSESt" && sop.name == "Empty")
            {
                Material nop = new Material();
                nop.SetName("SSSEStE");
                return nop;
            }
            else if (fop.name == "SSSEStE" && sop.name == "Empty")
            {
                Material nop = new Material();
                nop.SetName("SSSEStEE");
                return nop;
            }
            else if (fop.name == "SSSEStEE" && sop.name == "Stick")
            {
                Material nop = new Material();
                nop.SetName("SSSEStEESt");
                return nop;
            }
            else if (fop.name == "SSSEStEESt" && sop.name == "Empty")
            {
                Material nop = new Material();
                nop.SetName("StealPick");
                nop.hardness = 10;
                nop.weight = 5;
                return nop;
            }
            else if (fop.name == "SS" && sop.name == "Empty")
            {
                Material nop = new Material();
                nop.SetName("SSE");
                return nop;
            }
            else if (fop.name == "SSE" && sop.name == "Steal")
            {
                Material nop = new Material();
                nop.SetName("SSES");
                return nop;
            }
            else if (fop.name == "SSES" && sop.name == "Stick")
            {
                Material nop = new Material();
                nop.SetName("SSESSt");
                return nop;
            }
            else if (fop.name == "SSESSt" && sop.name == "Empty")
            {
                Material nop = new Material();
                nop.SetName("SSESStE");
                return nop;
            }
            else if (fop.name == "SSESStE" && sop.name == "Empty")
            {
                Material nop = new Material();
                nop.SetName("SSESStEE");
                return nop;
            }
            else if (fop.name == "SSESStEE" && sop.name == "Stick")
            {
                Material nop = new Material();
                nop.SetName("SSESStEESt");
                return nop;
            }
            else if (fop.name == "SSESStEESt" && sop.name == "Empty")
            {
                Material nop = new Material();
                nop.SetName("StealAxe");
                nop.hardness = 10;
                nop.weight = 5;
                return nop;
            }
            else { return null; }
            
        }
    }
}

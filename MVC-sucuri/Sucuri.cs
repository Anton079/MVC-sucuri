using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_sucuri
{
    public class Sucuri
    {
        public string brand;
        public int cantitate;
        public int pret;

        public string InfoSucuri()
        {
            string text = " ";
            text += "Brand" + brand + "\n";
            text += "Cantitate" + cantitate + "\n";
            text += "Pret" + pret + "\n";
            return text;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_sucuri
{
    public class Sucuri
    {
        public string _brand;
        public int _cantitate;
        public int _pret;

        public string brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public int cantitate
        {
            get { return _cantitate; }
            set { _cantitate = value; }
        }

        public int pret
        {
            get { return _pret; }
            set { _pret = value; }
        }

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

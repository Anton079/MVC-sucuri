using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_sucuri
{
    public class View
    {

        SucuriService sucuriService = new SucuriService();

        public void Meniu()
        {
            Console.WriteLine("Apasati tasta 1 pentru a afisa toate sucurile");
            Console.WriteLine("Apsasati tasta 2 ca sa se afiseze toate sucurile de o anumita cantitate");
            Console.WriteLine("Apasati tasta 3 si introduceti un suc pe care il doriti");
            Console.WriteLine("Apasati tasta 4 pentru a adauga un suc");          
        }

        public void play()
        {
            bool running = true;

            sucuriService.LoadData();
            while (running)
            {
                Meniu();
                string alegere = Console.ReadLine();

                switch(alegere)
                {
                    case "1":
                        sucuriService.AfisareSucuri();
                            break;
                }
            }
        }
    }
}

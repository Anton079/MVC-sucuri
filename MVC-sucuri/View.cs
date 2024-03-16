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
            Console.WriteLine("Apasati tasta 2 pentru a cauta un suc dupa brand"); //
            Console.WriteLine("Apsasati tasta 3 ca sa se afiseze toate sucurile de o anumita cantitate"); //
            Console.WriteLine("Apasati tasta 4 pentru a adauga un suc");
            Console.WriteLine("Apasati tasta 5 pentru a edita brandul unui suc");
            Console.WriteLine("Apasati tasta 6 pentru a edita pretul unui suc");
            Console.WriteLine("Apasati tasta 7 pentru a edita cantitatea unui suc");
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

                    //case "2":
                    //    AfisareSucuriDupaBrand();
                    //    break;

                    //case "3":
                    //    AfisareSucuriCantitate();
                    //    break;

                    case "4":
                        AddJuice();
                        break;

                    case "5":
                        EditSucuriBrand();
                        break;

                    case "6":
                        EditSucuriPret();
                        break;

                    case "7":
                        EditSucuriCantitate();
                        break;
                }
            }
        }
        //public void AfisareSucuriDupaBrand()
        //{
        //    Console.WriteLine("Ce suc doresti");
        //    string alegere = Console.ReadLine();

        //    if (sucuriService.AfisareaSucurilorByBrand(alegere))
        //    {
        //        Console.WriteLine("Nu stiu");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Nu avem acest brand");
        //    }
        //}

        //public void AfisareSucuriCantitate()
        //{
        //    Console.WriteLine("Ce cantitate cauti?");
        //    string alegere = Console.ReadLine();

        //    if (sucuriService.AfisareSucuriByCantitate(alegere))
        //    {
        //        Console.WriteLine("Nu stiu");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Nu avem acest brand");
        //    }
        //}

        public void AddJuice()
        {
            Console.WriteLine("ce brand de suc doriti sa adaugati?");
            string alegere = Console.ReadLine();

            Console.WriteLine("Ce cantiate are sucul");
            int cantitate = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ce pret o sa aiba sucul");
            int pret = Int32.Parse(Console.ReadLine());

            Sucuri Produs6 = new Sucuri();
            Produs6.brand = alegere;
            Produs6.cantitate = cantitate;
            Produs6.pret = pret;

            Console.WriteLine("Produsul a fost adaugat cu succes");
        }

        public void EditSucuriBrand()
        {
            Console.WriteLine("Ce suc doriti sa editati?");
            string alegere = Console.ReadLine();

            Console.WriteLine("Cu ce brand vreti sa-l editati");
            string newSuc = Console.ReadLine();

            if (sucuriService.EditSucuriBrand(alegere, newSuc))
            {
                Console.WriteLine("Brandul de suc a fost modificat");
            }
            else
            {
                Console.WriteLine("Brandul de suc nu a fost modificat");
            }
        }

        public void EditSucuriPret()
        {
            Console.WriteLine("Ce suc doriti sa editati?");
            string alegere = Console.ReadLine();

            Console.WriteLine("Cu ce pret vreti sa-l editati?");
            int newPrice = Int32.Parse(Console.ReadLine());

            if (sucuriService.EditSucuriPret(alegere, newPrice))
            {
                Console.WriteLine("Brandul de suc a fost modificat");
            }
            else
            {
                Console.WriteLine("Brandul de suc nu a fost modificat");
            }
        }

        public void EditSucuriCantitate()
        {
            Console.WriteLine("Ce suc vrei sa editezi?");
            string alegere = Console.ReadLine();

            Console.WriteLine("Cu ce inaltime doriti sa modificati animalul");
            int newCantitate = Int32.Parse(Console.ReadLine());

            if (sucuriService.EditSucuriCantitate(alegere, newCantitate))
            {
                Console.WriteLine("Animalul a fost editat cu succes");
            }
            else
            {
                Console.WriteLine("Animalul nu a putut fi editat");
            }
        }
    }
}

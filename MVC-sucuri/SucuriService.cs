using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_sucuri
{
    public class SucuriService
    {
        public List <Sucuri> SucuriList = new List<Sucuri>();

        public void LoadData()
        {
            Sucuri Produs1 = new Sucuri();
            Produs1.brand = "Coca Cola";
            Produs1.cantitate = 2;
            Produs1.pret = 12;

            Sucuri Produs2 = new Sucuri();
            Produs2.brand = "Fanta Lamaie";
            Produs2.cantitate = 1;
            Produs2.pret = 6;

            Sucuri Produs3 = new Sucuri();
            Produs3.brand = "Pepsi Zero";
            Produs3.cantitate = 2;
            Produs3.pret = 11;

            Sucuri Produs4 = new Sucuri();
            Produs4.brand = "Tymbark Visine";
            Produs4.cantitate = 1;
            Produs4.pret = 4;

            Sucuri Produs5 = new Sucuri();
            Produs5.brand = "Fuzetea lamaie";
            Produs5.cantitate = 05;
            Produs5.pret = 10;

            this.SucuriList.Add(Produs1);
            this.SucuriList.Add(Produs2);
            this.SucuriList.Add(Produs3);
            this.SucuriList.Add(Produs4);
            this.SucuriList.Add(Produs5);
        }


        //functie ce adauga intr o lista toate obiectele cu aceasi cantitate
        public List<Sucuri> FilterSucuriDupaCantiate(int cantitate)
        {
            List<Sucuri> sucursiCuCantitateData = new List<Sucuri>();

            foreach (Sucuri x in SucuriList)
            {
                if (x.cantitate == cantitate)
                {
                    sucursiCuCantitateData.Add(x);
                }
            }

            return sucursiCuCantitateData;
        }

        //functie ce adauga intr o lista toate obiecte sub pretul de 11 lei
        public List<Sucuri> FilterSucuriSubPret(int pret)
        {
            List<Sucuri> sucursiSubPretMaxim = new List<Sucuri>();

            foreach (Sucuri x in SucuriList)
            {
                if (x.pret < pret)
                {
                    sucursiSubPretMaxim.Add(x);
                }
            }

            return sucursiSubPretMaxim;
        }



        //CRUD
        public void AfisareSucuri()
        {
            foreach(Sucuri x in SucuriList)
            {
                Console.WriteLine(x.InfoSucuri());
            }
        }

        public int FindSucuriByBrand(string brand)
        {
            for (int i = 0; i < SucuriList.Count; i++)
            {
                if (SucuriList[i].brand == brand)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool AddSucuriInList(Sucuri ProdusNou)
        {
            if (FindSucuriByBrand(ProdusNou.brand) == -1)
            {
                this.SucuriList.Add(ProdusNou);
                return true;
            }
            return false;
        }

        public bool RemoveSucuriByBrand(string ProdusCautat)
        {
            int ProdusulCautatIndex = FindSucuriByBrand(ProdusCautat);
            if (ProdusulCautatIndex != -1)
            {
                SucuriList.RemoveAt(ProdusulCautatIndex);
                return true;
            }
            return false;
        }

        //View

    }
}

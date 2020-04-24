using System;
using System.Collections.Generic;
using System.Text;

namespace LV1
{
    class Zabiljeska                           //ovo dolje je 2. zadatak(za 1. nema smisla pisati ista 
                                               //posebno jer je potrebno samo kreirati novu c# aplikaciju
    {                                          //i pokrenuti je sto cu uciniti u cijelom LV-u vise puta
        private String tekstZabiljeske;
        private String autorZabiljeske;
        private int razinaVaznosti;

       public string getTekstZabiljeske()
        {
            return tekstZabiljeske;
        }
       public void setTekstZabiljeske(string tekstZabiljeske)
        {
            this.tekstZabiljeske = tekstZabiljeske;
        }

        public int getRazinaVaznosti()
        {
            return razinaVaznosti;
        }
       public  void setRazinaVaznosti(int razinaVaznosti)
        {
            this.razinaVaznosti = razinaVaznosti;
        }
       public string getAutorZabiljeske()//stavljamo privatan setter jer zadatak nalaze kako nije dozvoljena
        {                               //izmjena izvana(da sam stavio public mogao bi ga mijenjati svatko)
            return autorZabiljeske;
        }
        private void setAutorZabiljeske(string autorZabiljeske)
        {
            this.autorZabiljeske = autorZabiljeske;
        }

        //treci zadatak
        public Zabiljeska()
        {
            this.tekstZabiljeske = "test zabiljeska";
            this.autorZabiljeske = "Ivan Miskulin";
            this.razinaVaznosti = 2;
        }
        public Zabiljeska(string tekstZabiljeske,string autorZabiljeske,int razinaVaznosti)
        {
            this.tekstZabiljeske = tekstZabiljeske;
            this.autorZabiljeske = autorZabiljeske;
            this.razinaVaznosti = razinaVaznosti;
        }
        public Zabiljeska(string tekstZabiljeske,string autorZabiljeske)
        {
            this.tekstZabiljeske = tekstZabiljeske;
            this.autorZabiljeske = autorZabiljeske;
            this.razinaVaznosti = 0;
        }

        //4. zadatak (properties)
/*
        public string TekstZabiljeske
        {
            get { return this.tekstZabiljeske; }
            set { this.tekstZabiljeske = tekstZabiljeske; }
        }
        public string AutorZabiljeske
        {
            get { return this.autorZabiljeske; }
            
        }
        public int RazinaVaznosti
        {
            get { return this.razinaVaznosti; }
            set { this.razinaVaznosti = razinaVaznosti; }
        }
        */

        //5.zadatak

        public override string ToString()
        {
            return this.tekstZabiljeske + "," + this.autorZabiljeske;
        }
    }
}

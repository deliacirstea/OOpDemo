using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOpDemo
{
   public class House
    {
        public House(int year, string adress/*,string color*/)
        {
            if (year < 1900 || year > DateTime.Now.Year)
            {
                throw new ArgumentException("Ange ett bra år ");
            }
            this.year = year;
            this.adress = adress;
            //spentOnRenovations = 0;
            //Color = color;
        }

        public  void Repaint(string color)
        {
            this.color = color;
            spentOnRenovations += 10000;
        }

        private int spentOnRenovations = 0;

        private int year;

        private string adress = "";

        private string color = "";
        public int TotalRenovations()
        {
            return spentOnRenovations;
        }

        public string GetAdress()
        {
            return adress;
        }
    }
}

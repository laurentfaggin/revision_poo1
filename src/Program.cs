using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace revision_poo1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Liquide cafe = new Cafe(25);
            // Liquide creme = new Creme(10);
            // Liquide lait = new Lait(20);
            // Liquide chocolat = new Chocolat(50);

            Contenant bol = new Bol();
            Contenant tasse = new Tasse();

            bol.AjouterLiquide(cafe);
            // bol.AjouterLiquide(creme);
            // bol.AjouterLiquide(lait);
            // tasse.AjouterLiquide(chocolat);

            Console.WriteLine(bol.ToString());
        }
    }
}
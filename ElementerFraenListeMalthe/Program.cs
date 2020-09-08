using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementerFraenListeMalthe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opgave A
            List<int> liste1 = new List<int>() { 4, 7, 12, 17, -3, 8, 0, -45, 101 };
            List<int> liste2 = liste1.Where(tal => tal <= 0).ToList();
            List<int> liste3 = liste1.Where(tal => tal == 7).ToList();
            List<int> liste4 = liste1.Where(tal => tal > 4).ToList();
            UdskrivListe(liste1);
            UdskrivListe(liste2);
            UdskrivListe(liste3);
            UdskrivListe(liste4);

            Console.ReadKey(true);

            //Opgave B
            Car car1 = new Car() { Id = 1, Model = "Rio", Brand = "Kia", Year = 2006, Price = 250000, Color = "Red" };
            Car car2 = new Car() { Id = 2, Model = "Rio", Brand = "Kia", Year = 2007, Price = 265000, Color = "Black" };
            Car car3 = new Car() { Id = 3, Model = "Panda", Brand = "Fiat", Year = 2017, Price = 265000, Color = "Black" };
            Car car4 = new Car() { Id = 4, Model = "Panda", Brand = "Fiat", Year = 2017, Price = 365000, Color = "Yellow" };
            Car car5 = new Car() { Id = 5, Model = "S40", Brand = "Volvo", Year = 2018, Price = 665000, Color = "White" };
            Car car6 = new Car() { Id = 6, Model = "S65", Brand = "Volvo", Year = 2018, Price = 600000, Color = "White" };
            Car car7 = new Car() { Id = 7, Model = "Gorm", Brand = "Ferrari", Year = 2000, Price = 4665000, Color = "White" };
            Car car8 = new Car() { Id = 8, Model = "Gorm", Brand = "Ferrari", Year = 2018, Price = 4665000, Color = "White" };

            List<Car> listcar = new List<Car>() { car1, car2, car3, car4, car5, car6, car7, car8 };
            List<Car> listrio = listcar.Where(car => car.Model == "Rio").ToList();
            List<Car> listferrari = listcar.Where(car => car.Brand == "Ferrari").ToList();
            List<Car> list2010 = listcar.Where(car => car.Year >= 2010).ToList();
            List<Car> listhvid = listcar.Where(car => car.Color == "White").ToList();
            List<Car> listnr8 = listcar.Where(car => car.Id == 8).ToList();
            UdskrivListe(listcar);
            UdskrivListe(listrio);
            UdskrivListe(listferrari);
            UdskrivListe(list2010);
            UdskrivListe(listhvid);
            UdskrivListe(listnr8);

            Console.ReadKey();
        }
        static void UdskrivListe(List<int> liste5)
            {
                foreach(int item in liste5)
            {
                Console.WriteLine(item);
            }
            }
        static void UdskrivListe(List<Car> liste5)
        {
            foreach(Car bil in liste5)
            {
                Console.WriteLine(bil.ToString());
            }
        }
}
}
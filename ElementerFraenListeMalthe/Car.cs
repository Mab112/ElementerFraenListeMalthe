using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementerFraenListeMalthe
{
    class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public string Color { get; set; }
        public override string ToString()
        {
            return $"{Id} {Model} {Brand} {Year} {Price} {Color}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver.Garage
{
    internal class Car
    {
        public int id {  get; set; }
        public string name { get; set; }
        public Car(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}

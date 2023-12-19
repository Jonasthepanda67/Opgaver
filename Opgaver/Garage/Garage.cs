using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver.Garage
{
    class Garage
    {
        public string TilføjBil(string name, List<Car> cars)
        {
            int id;
            if (cars.Count() == 0)
            {
                id = 1;
            }
            else
            {
                id = cars.Count() + 1;
            }
            Car car = new Car(id, name);
            cars.Add(car);
            return $"\nBilen med id'et: {car.id} og bilnavnet: {car.name} er nu blevet oprettet";
        }
        public StringBuilder UdlæsBiler(List<Car> cars)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Car car in cars)
            {
                sb.AppendLine($"BilId: {car.id} Bilnavn: {car.name}" + Environment.NewLine);
            }
            return sb;
        }
        public string FindBil(int id, List<Car> cars)
        {
            Car car = cars.FirstOrDefault(i => i.id == id);
            return $"\nBilId: {car.id} Bilnavn: {car.name}";
        }
        public string FjernBil(int id, List<Car> cars)
        {
            Car car;
            cars.Remove(car = cars.Where(i => i.id == id).FirstOrDefault());
            return $"\nBilen med BilId'et: {car.id} og bilnavnet: {car.name} er nu blevet fjernet";
        }
    }
}

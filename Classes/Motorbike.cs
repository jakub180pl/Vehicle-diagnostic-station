using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubZajac_Stacjadiag_.Classes
{
    internal class Motorbike : Vehicle
    {
        protected string bike_category; 
        protected string frame_type; 
        protected string cooling_type; 
        protected string drive_type;


        public Motorbike(string category, string frame, string cooling, string drive, string vin, string brand, string model, string registration, string fuel, int power, int capacity, int year, int nr_mileage, int weight, DateTime data) : base(vin, brand, model, registration, fuel, power, capacity, year, nr_mileage, weight, data)
        {
            number_of_vehicle += 1;
            bike_category = category;
            frame_type = frame;
            cooling_type = cooling;
            drive_type = drive;

        }

        public Motorbike(Motorbike k) : base(k)
        {
            bike_category = k.bike_category;
            frame_type = k.frame_type;
            cooling_type = k.cooling_type;
            drive_type = k.drive_type;

        }

        public override string[] Wypisz()
        {
            string[] zmienna = base.Wypisz();
            string[] Motorbike = new string[]
            {
             "Rodzaj motocyklu: " + bike_category,
             "Typ ramy: " + frame_type,
             "Typ chłodzenia silnika: " + cooling_type,
             "Typ napędu: " + drive_type,
              "------------------------------------"
            };
            string[] Motorbikeinfo = zmienna.Concat(Motorbike).ToArray();
            return Motorbikeinfo;
        }


    }


}

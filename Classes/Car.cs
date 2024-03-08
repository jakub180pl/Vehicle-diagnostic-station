namespace JakubZajac_Stacjadiag_.Classes
{
    public class Car : Vehicle
    {
        protected int number_of_doors;
        protected int number_of_seats;
        protected string transmission_type; 
        protected string body_type; 

        public static bool operator ==(Car car1, Car car2)
        {

            return car1.number_of_doors == car2.number_of_doors && car1.number_of_seats == car2.number_of_seats && car1.transmission_type == car2.transmission_type && car1.body_type == car2.body_type;
        }
        public static bool operator !=(Car car1, Car car2)
        {
            return car1.number_of_doors != car2.number_of_doors || car1.number_of_seats != car2.number_of_seats || car1.transmission_type != car2.transmission_type || car1.body_type != car2.body_type;

        }



        public Car(int doors, int seats, string transmission, string body, string vin, string brand, string model, string registration, string fuel, int power, int capacity, int year, int nr_mileage, int weight, DateTime data) : base(vin, brand, model, registration, fuel, power, capacity, year, nr_mileage, weight, data)
        {
            number_of_vehicle += 1;
            number_of_doors = doors;
            number_of_seats = seats;
            transmission_type = transmission;
            body_type = body;
        }
        public Car(Car k) : base(k)
        {
            number_of_doors = k.number_of_doors;
            number_of_seats = k.number_of_seats;
            transmission_type = k.transmission_type;
            body_type = k.body_type;
        }
        public override string[] Wypisz()
        {

            string[] zmienna = base.Wypisz();


            string[] car = new string[]

            {
             "Liczba drzwi: " + number_of_doors,
             "Liczba miejsc: " + number_of_seats,
             "Rodzaj skrzyni biegów: " + transmission_type,
             "Rodzaj karoserii: " + body_type,
             "------------------------------------"
            };
            string[] carinfo = zmienna.Concat(car).ToArray();
            return carinfo;
        }


    }

}

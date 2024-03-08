namespace JakubZajac_Stacjadiag_.Classes
{
    public abstract class Vehicle
    {
        protected string _brand;
        protected string vehicle_model;
        protected string nr_vin;
        protected string registration_number;
        protected int year_of_production;
        protected int engine_capacity;
        public int engine_power;
        protected string fuel_type;
        protected int mileage;
        protected int vehicle_weight;
        static protected int number_of_vehicle = 1;
        protected int id_vehicle;
        protected DateTime date_time;
        protected Bitmap _picture = new Bitmap("C:\\Users\\Jakub\\Desktop\\Studia 1 rok\\Semestr letni 2022 2023\\Programowanie 2\\Listy\\Projekt Stacja diagnostyczna\\JakubZajac_Stacjadiag\\mini-mini-cooper-au-spec-wallpaper-preview.jpg");

        public Bitmap picture
        {
            get { return _picture; }

            set { _picture = value; }
        }



        public Vehicle(string vin, string brand, string model, string registration, string fuel, int power, int capacity, int year, int nr_mileage, int weight, DateTime data)
        {

            date_time = data;
            id_vehicle = number_of_vehicle;
            _brand = brand;
            vehicle_model = model;
            registration_number = registration;
            nr_vin = vin;
            fuel_type = fuel;
            engine_power = power;
            engine_capacity = capacity;
            year_of_production = year;
            mileage = nr_mileage;
            vehicle_weight = weight;

        }

        public Vehicle(Vehicle k)
        {

            id_vehicle = number_of_vehicle;
            _brand = k._brand;
            vehicle_model = k.vehicle_model;
            registration_number = k.registration_number;
            nr_vin = k.nr_vin;
            fuel_type = k.fuel_type;
            engine_power = k.engine_power;
            engine_capacity = k.engine_capacity;
            year_of_production = k.year_of_production;
            mileage = k.mileage;
            vehicle_weight = k.vehicle_weight;
        }

        public virtual string[] Wypisz()
        {


            string[] Vehicleinfo = new string[]
           {
             "Data: " + date_time,
             "ID pojazdu: " + id_vehicle,
             "Marka: " + _brand,
             "Model: " + vehicle_model,
             "Numer rejestracyjny: " + registration_number,
             "Numer VIN: " + nr_vin,
             "Rodzaj paliwa: " + fuel_type,
             "Moc silnika: "+ engine_power + " KM",
             "Pojemność silnika: " + engine_capacity+ " cm",
             "Rok produkcji: " + year_of_production,
             "Przebieg: " + mileage + " km",
             "Masa pojazdu: " + vehicle_weight+ " kg",


            };


            return Vehicleinfo;

        }

    }
}

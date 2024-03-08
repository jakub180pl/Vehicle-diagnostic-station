using JakubZajac_Stacjadiag_.Classes;

namespace JakubZajac_Stacjadiag_
{
    public partial class Formcar : Form
    {
        List<Vehicle> vehicles = new List<Vehicle>();
        List<Bitmap> photo = new List<Bitmap>();
       
       
        public Formcar()
        {
            InitializeComponent();
        }

        public List<Bitmap> my_photo
        {
            get { return photo; }
        }
        public List<Vehicle> moja_lista
        {
            get { return vehicles; }
        }
       
        
        private void Btnwprowadz_Click(object sender, EventArgs e)
        {

            try
            {
                if (!Int32.TryParse(txt_doors.Text, out _) || !Int32.TryParse(txt_engine_power.Text, out _)
                 || !Int32.TryParse(txt_engine_capacity.Text, out _) || !Int32.TryParse(txt_year.Text, out _)
                 || !Int32.TryParse(txt_mileage.Text, out _) || !Int32.TryParse(txt_weight.Text, out _)
                || pb_image.Image == null)
                {
                    throw new Exception("Podano nieprawidłowe dane!" );
                }
                lbdane.Items.Clear();
                pb2.Image = null;
                Car c2a = new Car(Convert.ToInt32(txt_doors.Text), Convert.ToInt32(txt_seats.Text), txt_transmission.Text, txt_body.Text, txt_vin.Text, txt_brand.Text, txt_model.Text, txt_registration.Text, txt_fuel.Text, Convert.ToInt32(txt_engine_power.Text), Convert.ToInt32(txt_engine_capacity.Text), Convert.ToInt32(txt_year.Text), Convert.ToInt32(txt_mileage.Text), Convert.ToInt32(txt_weight.Text), dtp_data.Value);
                lbdane.Items.AddRange(c2a.Wypisz());
                pb2.SizeMode = PictureBoxSizeMode.Zoom;
                pb2.Image = pb_image.Image;
                vehicles.Add(c2a);
                var bmp = (Bitmap)pb2.Image;
                photo.Add(bmp);
                Usun();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Coś poszło nie tak" +" "+ ex.Message);
            }
           
        }
        private void Btn_uzupelnij_Click(object sender, EventArgs e)
        {
            txt_body.Text = "coupe";
            txt_brand.Text = "MINI";
            txt_doors.Text = "3";
            txt_engine_capacity.Text = "1986";
            txt_engine_power.Text = "100";
            txt_fuel.Text = "Benzyna";
            txt_mileage.Text = "50000";
            txt_model.Text = "ONE";
            txt_registration.Text = "SK423S";
            txt_seats.Text = "4";
            txt_transmission.Text = "Manualna";
            txt_weight.Text = "1000";
            txt_year.Text = "2015";
            txt_vin.Text = "4eds432da3das";



        }
        void Usun()
        {
            txt_body.Clear();
            txt_brand.Clear();
            txt_doors.Clear();
            txt_engine_capacity.Clear();
            txt_engine_power.Clear();
            txt_fuel.Clear();
            txt_mileage.Clear();
            txt_model.Clear();
            txt_registration.Clear();
            txt_seats.Clear();
            txt_transmission.Clear();
            txt_weight.Clear();
            txt_year.Clear();
            txt_vin.Clear();
            pb_image.Image = null;
        }

        private void Btnshow_Click(object sender, EventArgs e)
        {
            
            pb_image.SizeMode = PictureBoxSizeMode.Zoom;
            pb_image.Image = new Bitmap("D:\\JakubZajac_Stacjadiag\\JakubZajac_Stacjadiag\\Windows\\Choice.cs");
        }
    }
}

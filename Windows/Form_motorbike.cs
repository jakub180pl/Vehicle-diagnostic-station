using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JakubZajac_Stacjadiag_.Classes;

namespace JakubZajac_Stacjadiag_
{
    public partial class Form_motorbike : Form
    {
        List<Vehicle> vehicles2 = new List<Vehicle>();
        List<Bitmap> photo = new List<Bitmap>();

        public Form_motorbike()
        {
            InitializeComponent();
        }
        public List<Bitmap> my_photo2
        {
            get { return photo; }
        }
        public List<Vehicle> moja_lista2
        {
            get { return vehicles2; }
        }

        private void Btnwprowadz_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(txt_engine_power.Text, out _) && Int32.TryParse(txt_engine_capacity.Text, out _)
                && Int32.TryParse(txt_year.Text, out _) && Int32.TryParse(txt_mileage.Text, out _)
                && Int32.TryParse(txt_weight.Text, out _) && pb_image.Image != null)
            {
                lbdane.Items.Clear();
                pb2.Image = null;
                Motorbike v1a = new Motorbike(txt_bike_category.Text, txt_frame_type.Text, txt_cooling_type.Text, txt_drive_type.Text, txt_vin.Text, txt_brand.Text, txt_model.Text, txt_registration.Text, txt_fuel.Text, Convert.ToInt32(txt_engine_power.Text), Convert.ToInt32(txt_engine_capacity.Text), Convert.ToInt32(txt_year.Text), Convert.ToInt32(txt_mileage.Text), Convert.ToInt32(txt_weight.Text), dtp_data.Value);
                lbdane.Items.AddRange(v1a.Wypisz());
                pb2.SizeMode = PictureBoxSizeMode.Zoom;
                pb2.Image = pb_image.Image;
                vehicles2.Add(v1a);
                var btm = (Bitmap)pb2.Image;
                photo.Add(btm);
            }
            else
            {
                MessageBox.Show("Podano nieprawidłowe dane!");
            }
            Usun();
        }

        private void Btn_uzupelnij_Click(object sender, EventArgs e)
        {


            txt_bike_category.Text = "d";
            txt_brand.Text = "r";
            txt_frame_type.Text = "3";
            txt_engine_capacity.Text = "12";
            txt_engine_power.Text = "13";
            txt_fuel.Text = "petrol";
            txt_mileage.Text = "50000";
            txt_model.Text = "Cooper";
            txt_registration.Text = "SK423s";
            txt_cooling_type.Text = "t";
            txt_drive_type.Text = "s";
            txt_weight.Text = "1000";
            txt_year.Text = "2315";
            txt_vin.Text = "4eds432da3das";
        }
        void Usun()
        {
            txt_bike_category.Clear();
            txt_brand.Clear();
            txt_frame_type.Clear();
            txt_engine_capacity.Clear();
            txt_engine_power.Clear();
            txt_fuel.Clear();
            txt_mileage.Clear();
            txt_model.Clear();
            txt_registration.Clear();
            txt_cooling_type.Clear();
            txt_drive_type.Clear();
            txt_weight.Clear();
            txt_year.Clear();
            txt_vin.Clear();
            pb_image.Image = null;
        }

        private void Btnshow_Click(object sender, EventArgs e)
        {
            pb_image.SizeMode = PictureBoxSizeMode.Zoom;
            pb_image.Image = new Bitmap("D:\\JakubZajac_Stacjadiag\\JakubZajac_Stacjadiag\\moto.jpg");
        }
    }
}

using JakubZajac_Stacjadiag_.Classes;

namespace JakubZajac_Stacjadiag_
{
    public partial class Choice : Form
    {
        List<Vehicle> list = new List<Vehicle>();
        List<Bitmap> locations = new List<Bitmap>();
        
       

        public Choice()
        {
            InitializeComponent();
        }
        private List<string> mylist = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {
        
            Formcar samochod = new Formcar();
            samochod.ShowDialog();
            list.AddRange(samochod.moja_lista);
            locations.AddRange(samochod.my_photo);
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_motorbike motocykl = new Form_motorbike();
            motocykl.ShowDialog();
            list.AddRange(motocykl.moja_lista2);
            locations.AddRange(motocykl.my_photo2);
        }

        private void Btn_lista_aut_motocykli_Click(object sender, EventArgs e)
        {

            ListForm a = new ListForm(list, locations);
            a.ShowDialog();

        }

        private void btn_oper_Click(object sender, EventArgs e)
        {
            Form_Operators A = new Form_Operators();
            A.ShowDialog();


        }
    }
}
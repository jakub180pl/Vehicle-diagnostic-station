using JakubZajac_Stacjadiag_.Classes;

namespace JakubZajac_Stacjadiag_
{
    public partial class Form_Operators : Form
    {

        public Form_Operators()
        {
            InitializeComponent();
        }



        Car car1 = new Car(6, 5, "manual", "hatchback", "9876w4321", "Ford", "Focus", "ABC5678", "diesel", 120, 2000, 2010, 80000, 1200, DateTime.Now);
        Car car2 = new Car(6, 5, "manual", "hatchback", "9876w4321", "Ford", "Focus", "ABC5678", "diesel", 120, 2000, 2010, 80000, 1200, DateTime.Now);
            
             private void btn_check_Click(object sender, EventArgs e)
             {
                 if (car1 == car2)
                 {
                   txt_zgodnosc.Text = (" są identyczne.");
                 }
                 else if (car1 != car2)
                 {
                   txt_zgodnosc.Text = (" nie są identyczne.");
                 }
             }

       






        
    }
}

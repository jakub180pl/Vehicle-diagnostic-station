using System.Xml;
using JakubZajac_Stacjadiag_.Classes;

namespace JakubZajac_Stacjadiag_
{

    public partial class ListForm : Form
    {
        private List<Vehicle> vehicles = new List<Vehicle>();
        private int index = 0;
        private List<Bitmap> location = new List<Bitmap>();
       
        

        public ListForm(List<Vehicle> vehicles, List<Bitmap> location)
        {
            InitializeComponent();
            this.vehicles = vehicles;
            this.location = location;
        }

        private void Btn_prev_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                lb_list.Items.Clear();
                lb_list.Items.AddRange(vehicles[index].Wypisz());
                pb_list.SizeMode = PictureBoxSizeMode.Zoom;
                pb_list.Image = new Bitmap(location[index]);
            }
            //else
            //{
            //    index++;
            //}
        }

        private void Btn_next_Click(object sender, EventArgs e)
        {
            index++;
            if (index < vehicles.Count && index < location.Count)
            {
               
                lb_list.Items.Clear();
                lb_list.Items.AddRange(vehicles[index].Wypisz());
                pb_list.SizeMode = PictureBoxSizeMode.Zoom;
                pb_list.Image = new Bitmap(location[index]);


            }
            else
            {
                MessageBox.Show("Nie ma więcej pojazdów!");
                index--;
            }
        }

        private void SavePictureBoxToImage(string filePath)
        {
            pb_list.Image.Save(filePath, System.Drawing.Imaging.ImageFormat.Jpeg);
        }
        private void LoadImageToPictureBox(string filePath)
        {
            if (System.IO.File.Exists(filePath))
            {
                Image loadedImage = Image.FromFile(filePath);
                pb_list.SizeMode = PictureBoxSizeMode.Zoom;
                pb_list.Image = loadedImage;
            }
        }
        private void SaveListBoxToXml(string filePath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlElement rootElement = xmlDoc.CreateElement("ListBoxItems");
            xmlDoc.AppendChild(rootElement);

            foreach (string item in lb_list.Items)
            {
                XmlElement itemElement = xmlDoc.CreateElement("Item");
                itemElement.InnerText = item;
                rootElement.AppendChild(itemElement);
            }
            xmlDoc.Save(filePath);

        }
        private void LoadXml(string path)
        {

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);

            lb_list.Items.Clear();
            pb_list.Image = null;

            foreach (XmlNode itemNode in xmlDoc.SelectNodes("ListBoxItems/Item"))
            {
                string item = itemNode.InnerText;
                lb_list.Items.Add(item);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML Files (*.xml)|*.xml";
            saveFileDialog.Title = "Save ListBox as XML";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                SaveListBoxToXml(filePath);
                string imageFilePath = System.IO.Path.ChangeExtension(filePath, "png");
                SavePictureBoxToImage(imageFilePath);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files (*.xml)|*.xml";
            openFileDialog.Title = "Load List from XML";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                LoadXml(filePath);
                string imageFilePath = System.IO.Path.ChangeExtension(filePath, "png");
                LoadImageToPictureBox(imageFilePath);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (index >= 0 && index <= vehicles.Count-1)
            {
                vehicles.RemoveAt(index);
                lb_list.Items.Clear();
                location.RemoveAt(index);
                pb_list.Image = null;
                if (index > 0)
                    index--;
                lb_list.Items.Clear();
                if (vehicles.Count != 0)
                {
                    lb_list.Items.AddRange(vehicles[index].Wypisz());
                    pb_list.SizeMode = PictureBoxSizeMode.Zoom;
                    pb_list.Image = new Bitmap(location[index]);
                }
                

            }
            else if(vehicles.Count ==0 && lb_list.Items != null)
            {
                pb_list.Image = null; 
                lb_list.Items.Clear();

            }
            else
            {
                MessageBox.Show("Nie ma pojazdów na liście");
            }
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {

            List<int> kmValues = ((List<Vehicle>)vehicles)
         .Where(v => v.engine_power > 100)
         .Select(v => v.engine_power)
         .ToList();

            if (kmValues.Count > 0 && vehicles.Count > 0) 
             {
                 double averageKM = Convert.ToDouble(kmValues.Count/vehicles.Count); 
                 MessageBox.Show("Średnia arytmetyczna KM dla pojazdów, gdzie KM > 100: " + averageKM);
             }
             else
             {
                 MessageBox.Show("Brak pojazdów spełniających warunek (KM > 100).");
             }
         }
        }
    }





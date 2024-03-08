namespace JakubZajac_Stacjadiag_
{
    partial class Formcar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbdane = new ListBox();
            btnwprowadz = new Button();
            lblpojazd = new Label();
            txt_brand = new TextBox();
            txt_fuel = new TextBox();
            txt_engine_capacity = new TextBox();
            txt_vin = new TextBox();
            txt_mileage = new TextBox();
            txt_seats = new TextBox();
            txt_engine_power = new TextBox();
            txt_registration = new TextBox();
            txt_weight = new TextBox();
            txt_transmission = new TextBox();
            txt_year = new TextBox();
            txt_doors = new TextBox();
            txt_body = new TextBox();
            txt_model = new TextBox();
            l_marka = new Label();
            label_model = new Label();
            label_nrrejst = new Label();
            label_vin = new Label();
            label_paliwo = new Label();
            label_moc = new Label();
            label_pojemnosc = new Label();
            label_przebieg = new Label();
            label_rok = new Label();
            label_masa = new Label();
            label_drzwi = new Label();
            label_miejsca = new Label();
            label_skrzynia = new Label();
            label_karoseria = new Label();
            btn_uzupelnij = new Button();
            dtp_data = new DateTimePicker();
            pb_image = new PictureBox();
            btnshow = new Button();
            pb2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pb_image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb2).BeginInit();
            SuspendLayout();
            // 
            // lbdane
            // 
            lbdane.FormattingEnabled = true;
            lbdane.ItemHeight = 20;
            lbdane.Location = new Point(323, 57);
            lbdane.Name = "lbdane";
            lbdane.Size = new Size(420, 444);
            lbdane.TabIndex = 2;
            // 
            // btnwprowadz
            // 
            btnwprowadz.Location = new Point(194, 12);
            btnwprowadz.Name = "btnwprowadz";
            btnwprowadz.Size = new Size(95, 32);
            btnwprowadz.TabIndex = 3;
            btnwprowadz.Text = "Wprowadź";
            btnwprowadz.UseVisualStyleBackColor = true;
            btnwprowadz.Click += Btnwprowadz_Click;
            // 
            // lblpojazd
            // 
            lblpojazd.AutoSize = true;
            lblpojazd.Location = new Point(21, 18);
            lblpojazd.Name = "lblpojazd";
            lblpojazd.Size = new Size(109, 20);
            lblpojazd.TabIndex = 4;
            lblpojazd.Text = "Dane pojazdu: ";
            // 
            // txt_brand
            // 
            txt_brand.Location = new Point(173, 57);
            txt_brand.Name = "txt_brand";
            txt_brand.Size = new Size(125, 27);
            txt_brand.TabIndex = 5;
            // 
            // txt_fuel
            // 
            txt_fuel.Location = new Point(173, 189);
            txt_fuel.Name = "txt_fuel";
            txt_fuel.Size = new Size(125, 27);
            txt_fuel.TabIndex = 6;
            // 
            // txt_engine_capacity
            // 
            txt_engine_capacity.Location = new Point(173, 255);
            txt_engine_capacity.Name = "txt_engine_capacity";
            txt_engine_capacity.Size = new Size(125, 27);
            txt_engine_capacity.TabIndex = 7;
            // 
            // txt_vin
            // 
            txt_vin.Location = new Point(173, 156);
            txt_vin.Name = "txt_vin";
            txt_vin.Size = new Size(125, 27);
            txt_vin.TabIndex = 8;
            // 
            // txt_mileage
            // 
            txt_mileage.Location = new Point(173, 321);
            txt_mileage.Name = "txt_mileage";
            txt_mileage.Size = new Size(125, 27);
            txt_mileage.TabIndex = 9;
            // 
            // txt_seats
            // 
            txt_seats.Location = new Point(173, 420);
            txt_seats.Name = "txt_seats";
            txt_seats.Size = new Size(125, 27);
            txt_seats.TabIndex = 10;
            // 
            // txt_engine_power
            // 
            txt_engine_power.Location = new Point(173, 222);
            txt_engine_power.Name = "txt_engine_power";
            txt_engine_power.Size = new Size(125, 27);
            txt_engine_power.TabIndex = 10;
            // 
            // txt_registration
            // 
            txt_registration.Location = new Point(173, 123);
            txt_registration.Name = "txt_registration";
            txt_registration.Size = new Size(125, 27);
            txt_registration.TabIndex = 11;
            // 
            // txt_weight
            // 
            txt_weight.Location = new Point(173, 354);
            txt_weight.Name = "txt_weight";
            txt_weight.Size = new Size(125, 27);
            txt_weight.TabIndex = 11;
            // 
            // txt_transmission
            // 
            txt_transmission.Location = new Point(173, 453);
            txt_transmission.Name = "txt_transmission";
            txt_transmission.Size = new Size(125, 27);
            txt_transmission.TabIndex = 12;
            // 
            // txt_year
            // 
            txt_year.Location = new Point(173, 288);
            txt_year.Name = "txt_year";
            txt_year.Size = new Size(125, 27);
            txt_year.TabIndex = 13;
            // 
            // txt_doors
            // 
            txt_doors.Location = new Point(173, 387);
            txt_doors.Name = "txt_doors";
            txt_doors.Size = new Size(125, 27);
            txt_doors.TabIndex = 14;
            // 
            // txt_body
            // 
            txt_body.Location = new Point(173, 486);
            txt_body.Name = "txt_body";
            txt_body.Size = new Size(125, 27);
            txt_body.TabIndex = 15;
            // 
            // txt_model
            // 
            txt_model.Location = new Point(173, 90);
            txt_model.Name = "txt_model";
            txt_model.Size = new Size(125, 27);
            txt_model.TabIndex = 17;
            // 
            // l_marka
            // 
            l_marka.AutoSize = true;
            l_marka.Location = new Point(114, 57);
            l_marka.Name = "l_marka";
            l_marka.Size = new Size(53, 20);
            l_marka.TabIndex = 19;
            l_marka.Text = "Marka:";
            // 
            // label_model
            // 
            label_model.AutoSize = true;
            label_model.Location = new Point(112, 90);
            label_model.Name = "label_model";
            label_model.Size = new Size(55, 20);
            label_model.TabIndex = 19;
            label_model.Text = "Model:";
            // 
            // label_nrrejst
            // 
            label_nrrejst.AutoSize = true;
            label_nrrejst.Location = new Point(32, 123);
            label_nrrejst.Name = "label_nrrejst";
            label_nrrejst.Size = new Size(135, 20);
            label_nrrejst.TabIndex = 19;
            label_nrrejst.Text = "Numer rejstracyjny:";
            // 
            // label_vin
            // 
            label_vin.AutoSize = true;
            label_vin.Location = new Point(82, 156);
            label_vin.Name = "label_vin";
            label_vin.Size = new Size(85, 20);
            label_vin.TabIndex = 19;
            label_vin.Text = "Numer VIN:";
            // 
            // label_paliwo
            // 
            label_paliwo.AutoSize = true;
            label_paliwo.Location = new Point(61, 189);
            label_paliwo.Name = "label_paliwo";
            label_paliwo.Size = new Size(106, 20);
            label_paliwo.TabIndex = 19;
            label_paliwo.Text = "Rodzaj paliwa:";
            // 
            // label_moc
            // 
            label_moc.AutoSize = true;
            label_moc.Location = new Point(81, 222);
            label_moc.Name = "label_moc";
            label_moc.Size = new Size(86, 20);
            label_moc.TabIndex = 19;
            label_moc.Text = "Moc silnika:";
            // 
            // label_pojemnosc
            // 
            label_pojemnosc.AutoSize = true;
            label_pojemnosc.Location = new Point(39, 255);
            label_pojemnosc.Name = "label_pojemnosc";
            label_pojemnosc.Size = new Size(128, 20);
            label_pojemnosc.TabIndex = 19;
            label_pojemnosc.Text = "Pojemność silnika:";
            // 
            // label_przebieg
            // 
            label_przebieg.AutoSize = true;
            label_przebieg.Location = new Point(97, 321);
            label_przebieg.Name = "label_przebieg";
            label_przebieg.Size = new Size(70, 20);
            label_przebieg.TabIndex = 19;
            label_przebieg.Text = "Przebieg:";
            // 
            // label_rok
            // 
            label_rok.AutoSize = true;
            label_rok.Location = new Point(64, 288);
            label_rok.Name = "label_rok";
            label_rok.Size = new Size(103, 20);
            label_rok.TabIndex = 19;
            label_rok.Text = "Rok produkcji:";
            // 
            // label_masa
            // 
            label_masa.AutoSize = true;
            label_masa.Location = new Point(62, 354);
            label_masa.Name = "label_masa";
            label_masa.Size = new Size(105, 20);
            label_masa.TabIndex = 19;
            label_masa.Text = "Masa pojazdu:";
            // 
            // label_drzwi
            // 
            label_drzwi.AutoSize = true;
            label_drzwi.Location = new Point(73, 387);
            label_drzwi.Name = "label_drzwi";
            label_drzwi.Size = new Size(94, 20);
            label_drzwi.TabIndex = 19;
            label_drzwi.Text = "Liczba drzwi:";
            // 
            // label_miejsca
            // 
            label_miejsca.AutoSize = true;
            label_miejsca.Location = new Point(67, 420);
            label_miejsca.Name = "label_miejsca";
            label_miejsca.Size = new Size(100, 20);
            label_miejsca.TabIndex = 19;
            label_miejsca.Text = "Liczba miejsc:";
            // 
            // label_skrzynia
            // 
            label_skrzynia.AutoSize = true;
            label_skrzynia.Location = new Point(7, 453);
            label_skrzynia.Name = "label_skrzynia";
            label_skrzynia.Size = new Size(160, 20);
            label_skrzynia.TabIndex = 19;
            label_skrzynia.Text = "Rodzaj skrzyni biegów:";
            // 
            // label_karoseria
            // 
            label_karoseria.AutoSize = true;
            label_karoseria.Location = new Point(49, 486);
            label_karoseria.Name = "label_karoseria";
            label_karoseria.Size = new Size(118, 20);
            label_karoseria.TabIndex = 19;
            label_karoseria.Text = "Rodzaj karoserii:";
            // 
            // btn_uzupelnij
            // 
            btn_uzupelnij.Location = new Point(295, 14);
            btn_uzupelnij.Name = "btn_uzupelnij";
            btn_uzupelnij.Size = new Size(94, 29);
            btn_uzupelnij.TabIndex = 20;
            btn_uzupelnij.Text = "Uzupełnij";
            btn_uzupelnij.UseVisualStyleBackColor = true;
            btn_uzupelnij.Click += Btn_uzupelnij_Click;
            // 
            // dtp_data
            // 
            dtp_data.Format = DateTimePickerFormat.Custom;
            dtp_data.Location = new Point(450, 18);
            dtp_data.MinDate = new DateTime(1886, 1, 1, 0, 0, 0, 0);
            dtp_data.Name = "dtp_data";
            dtp_data.Size = new Size(199, 27);
            dtp_data.TabIndex = 21;
            dtp_data.Value = new DateTime(2023, 4, 19, 0, 0, 0, 0);
            // 
            // pb_image
            // 
            pb_image.Location = new Point(752, 12);
            pb_image.Name = "pb_image";
            pb_image.Size = new Size(179, 194);
            pb_image.TabIndex = 22;
            pb_image.TabStop = false;
            // 
            // btnshow
            // 
            btnshow.Location = new Point(796, 222);
            btnshow.Name = "btnshow";
            btnshow.Size = new Size(94, 29);
            btnshow.TabIndex = 23;
            btnshow.Text = "Dodaj";
            btnshow.UseVisualStyleBackColor = true;
            btnshow.Click += Btnshow_Click;
            // 
            // pb2
            // 
            pb2.BackColor = SystemColors.ButtonHighlight;
            pb2.Location = new Point(600, 81);
            pb2.Name = "pb2";
            pb2.Size = new Size(124, 110);
            pb2.TabIndex = 24;
            pb2.TabStop = false;
            // 
            // Formcar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 522);
            Controls.Add(pb2);
            Controls.Add(btnshow);
            Controls.Add(pb_image);
            Controls.Add(dtp_data);
            Controls.Add(btn_uzupelnij);
            Controls.Add(label_karoseria);
            Controls.Add(label_skrzynia);
            Controls.Add(label_miejsca);
            Controls.Add(label_drzwi);
            Controls.Add(label_masa);
            Controls.Add(label_rok);
            Controls.Add(label_przebieg);
            Controls.Add(label_pojemnosc);
            Controls.Add(label_moc);
            Controls.Add(label_paliwo);
            Controls.Add(label_vin);
            Controls.Add(label_nrrejst);
            Controls.Add(label_model);
            Controls.Add(l_marka);
            Controls.Add(txt_model);
            Controls.Add(txt_body);
            Controls.Add(txt_doors);
            Controls.Add(txt_year);
            Controls.Add(txt_transmission);
            Controls.Add(txt_weight);
            Controls.Add(txt_registration);
            Controls.Add(txt_engine_power);
            Controls.Add(txt_seats);
            Controls.Add(txt_mileage);
            Controls.Add(txt_vin);
            Controls.Add(txt_engine_capacity);
            Controls.Add(txt_fuel);
            Controls.Add(txt_brand);
            Controls.Add(lblpojazd);
            Controls.Add(btnwprowadz);
            Controls.Add(lbdane);
            Name = "Formcar";
            Text = "Samochody.exe";
            ((System.ComponentModel.ISupportInitialize)pb_image).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbdane;
        private Button btnwprowadz;
        private Label lblpojazd;
        private TextBox txt_brand;
        private TextBox txt_fuel;
        private TextBox txt_engine_capacity;
        private TextBox txt_vin;
        private TextBox txt_mileage;
        private TextBox txt_seats;
        private TextBox txt_engine_power;
        private TextBox txt_registration;
        private TextBox txt_weight;
        private TextBox txt_transmission;
        private TextBox txt_year;
        private TextBox txt_doors;
        private TextBox txt_body;
        private TextBox txt_model;
        private Label l_marka;
        private Label label_model;
        private Label label_nrrejst;
        private Label label_vin;
        private Label label_paliwo;
        private Label label_moc;
        private Label label_pojemnosc;
        private Label label_przebieg;
        private Label label_rok;
        private Label label_masa;
        private Label label_drzwi;
        private Label label_miejsca;
        private Label label_skrzynia;
        private Label label_karoseria;
        private Button btn_uzupelnij;
        private DateTimePicker dtp_data;
        private PictureBox pb_image;
        private Button btnshow;
        private PictureBox pb2;
    }
}
namespace JakubZajac_Stacjadiag_
{
    partial class Form_motorbike
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
            btn_uzupelnij = new Button();
            lb_naped = new Label();
            lb_chlodzenie = new Label();
            lb_rama = new Label();
            lb_rodzaj = new Label();
            lb_masa = new Label();
            lb_rok = new Label();
            lb_przebieg = new Label();
            lb_pojemnosc = new Label();
            lb_moc = new Label();
            lb_paliwo = new Label();
            lb_vin = new Label();
            lb_nrrejst = new Label();
            lb_model = new Label();
            lb_marka = new Label();
            txt_model = new TextBox();
            txt_drive_type = new TextBox();
            txt_bike_category = new TextBox();
            txt_year = new TextBox();
            txt_cooling_type = new TextBox();
            txt_weight = new TextBox();
            txt_registration = new TextBox();
            txt_engine_power = new TextBox();
            txt_frame_type = new TextBox();
            txt_mileage = new TextBox();
            txt_vin = new TextBox();
            txt_engine_capacity = new TextBox();
            txt_fuel = new TextBox();
            txt_brand = new TextBox();
            lblpojazd = new Label();
            btnwprowadz = new Button();
            lbdane = new ListBox();
            dtp_data = new DateTimePicker();
            pb_image = new PictureBox();
            btnshow = new Button();
            pb2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pb_image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb2).BeginInit();
            SuspendLayout();
            // 
            // btn_uzupelnij
            // 
            btn_uzupelnij.Location = new Point(228, 5);
            btn_uzupelnij.Name = "btn_uzupelnij";
            btn_uzupelnij.Size = new Size(94, 29);
            btn_uzupelnij.TabIndex = 52;
            btn_uzupelnij.Text = "Uzupełnij";
            btn_uzupelnij.UseVisualStyleBackColor = true;
            btn_uzupelnij.Click += Btn_uzupelnij_Click;
            // 
            // lb_naped
            // 
            lb_naped.AutoSize = true;
            lb_naped.Location = new Point(103, 476);
            lb_naped.Name = "lb_naped";
            lb_naped.Size = new Size(89, 20);
            lb_naped.TabIndex = 50;
            lb_naped.Text = "Typ napędu:";
            // 
            // lb_chlodzenie
            // 
            lb_chlodzenie.AutoSize = true;
            lb_chlodzenie.Location = new Point(36, 443);
            lb_chlodzenie.Name = "lb_chlodzenie";
            lb_chlodzenie.Size = new Size(156, 20);
            lb_chlodzenie.TabIndex = 49;
            lb_chlodzenie.Text = "Typ chłodzenia silnika:";
            // 
            // lb_rama
            // 
            lb_rama.AutoSize = true;
            lb_rama.Location = new Point(120, 410);
            lb_rama.Name = "lb_rama";
            lb_rama.Size = new Size(72, 20);
            lb_rama.TabIndex = 48;
            lb_rama.Text = "Typ ramy:";
            // 
            // lb_rodzaj
            // 
            lb_rodzaj.AutoSize = true;
            lb_rodzaj.Location = new Point(61, 377);
            lb_rodzaj.Name = "lb_rodzaj";
            lb_rodzaj.Size = new Size(131, 20);
            lb_rodzaj.TabIndex = 47;
            lb_rodzaj.Text = "Rodzaj motocyklu:";
            // 
            // lb_masa
            // 
            lb_masa.AutoSize = true;
            lb_masa.Location = new Point(87, 343);
            lb_masa.Name = "lb_masa";
            lb_masa.Size = new Size(105, 20);
            lb_masa.TabIndex = 46;
            lb_masa.Text = "Masa pojazdu:";
            // 
            // lb_rok
            // 
            lb_rok.AutoSize = true;
            lb_rok.Location = new Point(92, 277);
            lb_rok.Name = "lb_rok";
            lb_rok.Size = new Size(103, 20);
            lb_rok.TabIndex = 45;
            lb_rok.Text = "Rok produkcji:";
            // 
            // lb_przebieg
            // 
            lb_przebieg.AutoSize = true;
            lb_przebieg.Location = new Point(122, 310);
            lb_przebieg.Name = "lb_przebieg";
            lb_przebieg.Size = new Size(70, 20);
            lb_przebieg.TabIndex = 44;
            lb_przebieg.Text = "Przebieg:";
            // 
            // lb_pojemnosc
            // 
            lb_pojemnosc.AutoSize = true;
            lb_pojemnosc.Location = new Point(64, 244);
            lb_pojemnosc.Name = "lb_pojemnosc";
            lb_pojemnosc.Size = new Size(128, 20);
            lb_pojemnosc.TabIndex = 43;
            lb_pojemnosc.Text = "Pojemność silnika:";
            // 
            // lb_moc
            // 
            lb_moc.AutoSize = true;
            lb_moc.Location = new Point(106, 211);
            lb_moc.Name = "lb_moc";
            lb_moc.Size = new Size(86, 20);
            lb_moc.TabIndex = 42;
            lb_moc.Text = "Moc silnika:";
            // 
            // lb_paliwo
            // 
            lb_paliwo.AutoSize = true;
            lb_paliwo.Location = new Point(86, 178);
            lb_paliwo.Name = "lb_paliwo";
            lb_paliwo.Size = new Size(106, 20);
            lb_paliwo.TabIndex = 41;
            lb_paliwo.Text = "Rodzaj paliwa:";
            // 
            // lb_vin
            // 
            lb_vin.AutoSize = true;
            lb_vin.Location = new Point(107, 145);
            lb_vin.Name = "lb_vin";
            lb_vin.Size = new Size(85, 20);
            lb_vin.TabIndex = 40;
            lb_vin.Text = "Numer VIN:";
            // 
            // lb_nrrejst
            // 
            lb_nrrejst.AutoSize = true;
            lb_nrrejst.Location = new Point(57, 112);
            lb_nrrejst.Name = "lb_nrrejst";
            lb_nrrejst.Size = new Size(135, 20);
            lb_nrrejst.TabIndex = 39;
            lb_nrrejst.Text = "Numer rejstracyjny:";
            // 
            // lb_model
            // 
            lb_model.AutoSize = true;
            lb_model.Location = new Point(137, 79);
            lb_model.Name = "lb_model";
            lb_model.Size = new Size(55, 20);
            lb_model.TabIndex = 38;
            lb_model.Text = "Model:";
            // 
            // lb_marka
            // 
            lb_marka.AutoSize = true;
            lb_marka.Location = new Point(139, 46);
            lb_marka.Name = "lb_marka";
            lb_marka.Size = new Size(53, 20);
            lb_marka.TabIndex = 51;
            lb_marka.Text = "Marka:";
            // 
            // txt_model
            // 
            txt_model.Location = new Point(198, 79);
            txt_model.Name = "txt_model";
            txt_model.Size = new Size(125, 27);
            txt_model.TabIndex = 37;
            // 
            // txt_drive_type
            // 
            txt_drive_type.Location = new Point(198, 476);
            txt_drive_type.Name = "txt_drive_type";
            txt_drive_type.Size = new Size(125, 27);
            txt_drive_type.TabIndex = 36;
            // 
            // txt_bike_category
            // 
            txt_bike_category.Location = new Point(198, 377);
            txt_bike_category.Name = "txt_bike_category";
            txt_bike_category.Size = new Size(125, 27);
            txt_bike_category.TabIndex = 35;
            // 
            // txt_year
            // 
            txt_year.Location = new Point(198, 277);
            txt_year.Name = "txt_year";
            txt_year.Size = new Size(125, 27);
            txt_year.TabIndex = 34;
            // 
            // txt_cooling_type
            // 
            txt_cooling_type.Location = new Point(198, 443);
            txt_cooling_type.Name = "txt_cooling_type";
            txt_cooling_type.Size = new Size(125, 27);
            txt_cooling_type.TabIndex = 33;
            // 
            // txt_weight
            // 
            txt_weight.Location = new Point(198, 343);
            txt_weight.Name = "txt_weight";
            txt_weight.Size = new Size(125, 27);
            txt_weight.TabIndex = 32;
            // 
            // txt_registration
            // 
            txt_registration.Location = new Point(198, 112);
            txt_registration.Name = "txt_registration";
            txt_registration.Size = new Size(125, 27);
            txt_registration.TabIndex = 31;
            // 
            // txt_engine_power
            // 
            txt_engine_power.Location = new Point(198, 211);
            txt_engine_power.Name = "txt_engine_power";
            txt_engine_power.Size = new Size(125, 27);
            txt_engine_power.TabIndex = 30;
            // 
            // txt_frame_type
            // 
            txt_frame_type.Location = new Point(198, 410);
            txt_frame_type.Name = "txt_frame_type";
            txt_frame_type.Size = new Size(125, 27);
            txt_frame_type.TabIndex = 29;
            // 
            // txt_mileage
            // 
            txt_mileage.Location = new Point(198, 310);
            txt_mileage.Name = "txt_mileage";
            txt_mileage.Size = new Size(125, 27);
            txt_mileage.TabIndex = 28;
            // 
            // txt_vin
            // 
            txt_vin.Location = new Point(198, 145);
            txt_vin.Name = "txt_vin";
            txt_vin.Size = new Size(125, 27);
            txt_vin.TabIndex = 27;
            // 
            // txt_engine_capacity
            // 
            txt_engine_capacity.Location = new Point(198, 244);
            txt_engine_capacity.Name = "txt_engine_capacity";
            txt_engine_capacity.Size = new Size(125, 27);
            txt_engine_capacity.TabIndex = 26;
            // 
            // txt_fuel
            // 
            txt_fuel.Location = new Point(198, 178);
            txt_fuel.Name = "txt_fuel";
            txt_fuel.Size = new Size(125, 27);
            txt_fuel.TabIndex = 25;
            // 
            // txt_brand
            // 
            txt_brand.Location = new Point(198, 46);
            txt_brand.Name = "txt_brand";
            txt_brand.Size = new Size(125, 27);
            txt_brand.TabIndex = 24;
            // 
            // lblpojazd
            // 
            lblpojazd.AutoSize = true;
            lblpojazd.Location = new Point(12, 9);
            lblpojazd.Name = "lblpojazd";
            lblpojazd.Size = new Size(109, 20);
            lblpojazd.TabIndex = 23;
            lblpojazd.Text = "Dane pojazdu: ";
            // 
            // btnwprowadz
            // 
            btnwprowadz.Location = new Point(127, 3);
            btnwprowadz.Name = "btnwprowadz";
            btnwprowadz.Size = new Size(95, 32);
            btnwprowadz.TabIndex = 22;
            btnwprowadz.Text = "Wprowadź";
            btnwprowadz.UseVisualStyleBackColor = true;
            btnwprowadz.Click += Btnwprowadz_Click;
            // 
            // lbdane
            // 
            lbdane.FormattingEnabled = true;
            lbdane.ItemHeight = 20;
            lbdane.Location = new Point(348, 60);
            lbdane.Name = "lbdane";
            lbdane.Size = new Size(420, 444);
            lbdane.TabIndex = 21;
            // 
            // dtp_data
            // 
            dtp_data.Format = DateTimePickerFormat.Custom;
            dtp_data.Location = new Point(348, 9);
            dtp_data.MinDate = new DateTime(1885, 8, 29, 0, 0, 0, 0);
            dtp_data.Name = "dtp_data";
            dtp_data.Size = new Size(263, 27);
            dtp_data.TabIndex = 53;
            dtp_data.Value = new DateTime(2023, 4, 19, 0, 0, 0, 0);
            // 
            // pb_image
            // 
            pb_image.Location = new Point(809, 23);
            pb_image.Name = "pb_image";
            pb_image.Size = new Size(179, 194);
            pb_image.TabIndex = 54;
            pb_image.TabStop = false;
            // 
            // btnshow
            // 
            btnshow.Location = new Point(854, 244);
            btnshow.Name = "btnshow";
            btnshow.Size = new Size(94, 29);
            btnshow.TabIndex = 55;
            btnshow.Text = "Dodaj";
            btnshow.UseVisualStyleBackColor = true;
            btnshow.Click += Btnshow_Click;
            // 
            // pb2
            // 
            pb2.BackColor = SystemColors.ButtonHighlight;
            pb2.Location = new Point(611, 79);
            pb2.Name = "pb2";
            pb2.Size = new Size(133, 126);
            pb2.TabIndex = 56;
            pb2.TabStop = false;
            // 
            // Form_motorbike
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 515);
            Controls.Add(pb2);
            Controls.Add(btnshow);
            Controls.Add(pb_image);
            Controls.Add(dtp_data);
            Controls.Add(btn_uzupelnij);
            Controls.Add(lb_naped);
            Controls.Add(lb_chlodzenie);
            Controls.Add(lb_rama);
            Controls.Add(lb_rodzaj);
            Controls.Add(lb_masa);
            Controls.Add(lb_rok);
            Controls.Add(lb_przebieg);
            Controls.Add(lb_pojemnosc);
            Controls.Add(lb_moc);
            Controls.Add(lb_paliwo);
            Controls.Add(lb_vin);
            Controls.Add(lb_nrrejst);
            Controls.Add(lb_model);
            Controls.Add(lb_marka);
            Controls.Add(txt_model);
            Controls.Add(txt_drive_type);
            Controls.Add(txt_bike_category);
            Controls.Add(txt_year);
            Controls.Add(txt_cooling_type);
            Controls.Add(txt_weight);
            Controls.Add(txt_registration);
            Controls.Add(txt_engine_power);
            Controls.Add(txt_frame_type);
            Controls.Add(txt_mileage);
            Controls.Add(txt_vin);
            Controls.Add(txt_engine_capacity);
            Controls.Add(txt_fuel);
            Controls.Add(txt_brand);
            Controls.Add(lblpojazd);
            Controls.Add(btnwprowadz);
            Controls.Add(lbdane);
            Name = "Form_motorbike";
            Text = "Motocykle.exe";
            ((System.ComponentModel.ISupportInitialize)pb_image).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_uzupelnij;
        private Label lb_naped;
        private Label lb_chlodzenie;
        private Label lb_rama;
        private Label lb_rodzaj;
        private Label lb_masa;
        private Label lb_rok;
        private Label lb_przebieg;
        private Label lb_pojemnosc;
        private Label lb_moc;
        private Label lb_paliwo;
        private Label lb_vin;
        private Label lb_nrrejst;
        private Label lb_model;
        private Label lb_marka;
        private TextBox txt_model;
        private TextBox txt_drive_type;
        private TextBox txt_bike_category;
        private TextBox txt_year;
        private TextBox txt_cooling_type;
        private TextBox txt_weight;
        private TextBox txt_registration;
        private TextBox txt_engine_power;
        private TextBox txt_frame_type;
        private TextBox txt_mileage;
        private TextBox txt_vin;
        private TextBox txt_engine_capacity;
        private TextBox txt_fuel;
        private TextBox txt_brand;
        private Label lblpojazd;
        private Button btnwprowadz;
        private ListBox lbdane;
        private DateTimePicker dtp_data;
        private PictureBox pb_image;
        private Button btnshow;
        private PictureBox pb2;
    }
}
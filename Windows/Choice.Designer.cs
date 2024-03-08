namespace JakubZajac_Stacjadiag_
{
    partial class Choice
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_samochod = new Button();
            btn_motocykl = new Button();
            lb_wybor = new Label();
            Btn_lista_aut_motocykli = new Button();
            btn_oper = new Button();
            SuspendLayout();
            // 
            // btn_samochod
            // 
            btn_samochod.Location = new Point(113, 107);
            btn_samochod.Name = "btn_samochod";
            btn_samochod.Size = new Size(94, 29);
            btn_samochod.TabIndex = 0;
            btn_samochod.Text = "Samochód";
            btn_samochod.UseVisualStyleBackColor = true;
            btn_samochod.Click += button1_Click;
            // 
            // btn_motocykl
            // 
            btn_motocykl.Location = new Point(264, 107);
            btn_motocykl.Name = "btn_motocykl";
            btn_motocykl.Size = new Size(94, 29);
            btn_motocykl.TabIndex = 1;
            btn_motocykl.Text = "Motocykl";
            btn_motocykl.UseVisualStyleBackColor = true;
            btn_motocykl.Click += button2_Click;
            // 
            // lb_wybor
            // 
            lb_wybor.AutoSize = true;
            lb_wybor.Location = new Point(147, 55);
            lb_wybor.Name = "lb_wybor";
            lb_wybor.Size = new Size(183, 20);
            lb_wybor.TabIndex = 2;
            lb_wybor.Text = "Jaki pojazd chcesz dodać?";
            // 
            // Btn_lista_aut_motocykli
            // 
            Btn_lista_aut_motocykli.Location = new Point(264, 152);
            Btn_lista_aut_motocykli.Name = "Btn_lista_aut_motocykli";
            Btn_lista_aut_motocykli.Size = new Size(94, 29);
            Btn_lista_aut_motocykli.TabIndex = 3;
            Btn_lista_aut_motocykli.Text = "Lista aut/motocykli";
            Btn_lista_aut_motocykli.UseVisualStyleBackColor = true;
            Btn_lista_aut_motocykli.Click += Btn_lista_aut_motocykli_Click;
            // 
            // btn_oper
            // 
            btn_oper.Location = new Point(113, 152);
            btn_oper.Name = "btn_oper";
            btn_oper.Size = new Size(94, 29);
            btn_oper.TabIndex = 4;
            btn_oper.Text = "Operatory";
            btn_oper.UseVisualStyleBackColor = true;
            btn_oper.Click += btn_oper_Click;
            // 
            // Wybor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 193);
            Controls.Add(btn_oper);
            Controls.Add(Btn_lista_aut_motocykli);
            Controls.Add(lb_wybor);
            Controls.Add(btn_motocykl);
            Controls.Add(btn_samochod);
            Name = "Wybor";
            Text = "Wybór";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_samochod;
        private Button btn_motocykl;
        private Label lb_wybor;
        private Button Btn_lista_aut_motocykli;
        private Button btn_oper;
    }
}
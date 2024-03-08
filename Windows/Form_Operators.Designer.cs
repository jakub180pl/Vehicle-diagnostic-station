namespace JakubZajac_Stacjadiag_
{
    partial class Form_Operators
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
            lb_Zgodnosc = new Label();
            btn_check = new Button();
            txt_zgodnosc = new TextBox();
            SuspendLayout();
            // 
            // lb_Zgodnosc
            // 
            lb_Zgodnosc.AutoSize = true;
            lb_Zgodnosc.Location = new Point(215, 78);
            lb_Zgodnosc.Name = "lb_Zgodnosc";
            lb_Zgodnosc.Size = new Size(82, 20);
            lb_Zgodnosc.TabIndex = 0;
            lb_Zgodnosc.Text = "Zgodnosc: ";
            // 
            // btn_check
            // 
            btn_check.Location = new Point(337, 229);
            btn_check.Name = "btn_check";
            btn_check.Size = new Size(94, 29);
            btn_check.TabIndex = 1;
            btn_check.Text = "Sprawdz";
            btn_check.UseVisualStyleBackColor = true;
            btn_check.Click += btn_check_Click;
            // 
            // txt_zgodnosc
            // 
            txt_zgodnosc.Location = new Point(306, 78);
            txt_zgodnosc.Name = "txt_zgodnosc";
            txt_zgodnosc.Size = new Size(213, 27);
            txt_zgodnosc.TabIndex = 2;
            // 
            // Form_Operatory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_zgodnosc);
            Controls.Add(btn_check);
            Controls.Add(lb_Zgodnosc);
            Name = "Form_Operatory";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_Zgodnosc;
        private Button btn_check;
        private TextBox txt_zgodnosc;
    }
}
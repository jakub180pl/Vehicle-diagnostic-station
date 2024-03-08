namespace JakubZajac_Stacjadiag_
{
    partial class ListForm
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
            lb_list = new ListBox();
            Btn_prev = new Button();
            Btn_next = new Button();
            pb_list = new PictureBox();
            btnSave = new Button();
            btnLoad = new Button();
            btnDelete = new Button();
            btnAverage = new Button();
            ((System.ComponentModel.ISupportInitialize)pb_list).BeginInit();
            SuspendLayout();
            // 
            // lb_list
            // 
            lb_list.FormattingEnabled = true;
            lb_list.ItemHeight = 20;
            lb_list.Location = new Point(170, 12);
            lb_list.Name = "lb_list";
            lb_list.Size = new Size(444, 284);
            lb_list.TabIndex = 0;
            // 
            // Btn_prev
            // 
            Btn_prev.Location = new Point(178, 383);
            Btn_prev.Name = "Btn_prev";
            Btn_prev.Size = new Size(94, 29);
            Btn_prev.TabIndex = 1;
            Btn_prev.Text = "prev";
            Btn_prev.UseVisualStyleBackColor = true;
            Btn_prev.Click += Btn_prev_Click;
            // 
            // Btn_next
            // 
            Btn_next.Location = new Point(489, 383);
            Btn_next.Name = "Btn_next";
            Btn_next.Size = new Size(94, 29);
            Btn_next.TabIndex = 2;
            Btn_next.Text = "next";
            Btn_next.UseVisualStyleBackColor = true;
            Btn_next.Click += Btn_next_Click;
            // 
            // pb_list
            // 
            pb_list.BackColor = SystemColors.ButtonHighlight;
            pb_list.Location = new Point(458, 28);
            pb_list.Name = "pb_list";
            pb_list.Size = new Size(125, 102);
            pb_list.TabIndex = 3;
            pb_list.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(278, 383);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(389, 383);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 5;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(334, 325);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAverage
            // 
            btnAverage.Location = new Point(458, 325);
            btnAverage.Name = "btnAverage";
            btnAverage.Size = new Size(94, 29);
            btnAverage.TabIndex = 7;
            btnAverage.Text = "Average";
            btnAverage.UseVisualStyleBackColor = true;
            btnAverage.Click += btnAverage_Click;
            // 
            // ListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAverage);
            Controls.Add(btnDelete);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(pb_list);
            Controls.Add(Btn_next);
            Controls.Add(Btn_prev);
            Controls.Add(lb_list);
            Name = "ListForm";
            Text = "ListaForm";
            ((System.ComponentModel.ISupportInitialize)pb_list).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lb_list;
        private Button Btn_prev;
        private Button Btn_next;
        private PictureBox pb_list;
        private Button btnSave;
        private Button btnLoad;
        private Button btnDelete;
        private Button btnAverage;
    }
}
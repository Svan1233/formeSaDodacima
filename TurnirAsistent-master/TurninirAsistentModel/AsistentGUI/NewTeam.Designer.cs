namespace AsistentGUI
{
    partial class NewTeam
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
            this.lblImeTima = new System.Windows.Forms.Label();
            this.lblNazivTima = new System.Windows.Forms.Label();
            this.lblIgrac = new System.Windows.Forms.Label();
            this.linkLblKreirajNovogIgraca = new System.Windows.Forms.LinkLabel();
            this.cmbBoxUcitajPrijasnjegIrgaca = new System.Windows.Forms.ComboBox();
            this.btnUcitajPrijasnjegIgraca = new System.Windows.Forms.Button();
            this.listBoxListaIgraca = new System.Windows.Forms.ListBox();
            this.btnKreirajNoviTim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblImeTima
            // 
            this.lblImeTima.AutoSize = true;
            this.lblImeTima.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImeTima.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblImeTima.Location = new System.Drawing.Point(84, 84);
            this.lblImeTima.Name = "lblImeTima";
            this.lblImeTima.Size = new System.Drawing.Size(153, 45);
            this.lblImeTima.TabIndex = 0;
            this.lblImeTima.Text = "Ime tima:";
            // 
            // lblNazivTima
            // 
            this.lblNazivTima.AutoSize = true;
            this.lblNazivTima.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivTima.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblNazivTima.Location = new System.Drawing.Point(243, 84);
            this.lblNazivTima.Name = "lblNazivTima";
            this.lblNazivTima.Size = new System.Drawing.Size(207, 45);
            this.lblNazivTima.TabIndex = 1;
            this.lblNazivTima.Text = "<naziv tima>";
            // 
            // lblIgrac
            // 
            this.lblIgrac.AutoSize = true;
            this.lblIgrac.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIgrac.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblIgrac.Location = new System.Drawing.Point(84, 153);
            this.lblIgrac.Name = "lblIgrac";
            this.lblIgrac.Size = new System.Drawing.Size(90, 45);
            this.lblIgrac.TabIndex = 2;
            this.lblIgrac.Text = "Igrac";
            // 
            // linkLblKreirajNovogIgraca
            // 
            this.linkLblKreirajNovogIgraca.AutoSize = true;
            this.linkLblKreirajNovogIgraca.Location = new System.Drawing.Point(180, 173);
            this.linkLblKreirajNovogIgraca.Name = "linkLblKreirajNovogIgraca";
            this.linkLblKreirajNovogIgraca.Size = new System.Drawing.Size(180, 25);
            this.linkLblKreirajNovogIgraca.TabIndex = 3;
            this.linkLblKreirajNovogIgraca.TabStop = true;
            this.linkLblKreirajNovogIgraca.Text = "kreiraj novog igraca";
            // 
            // cmbBoxUcitajPrijasnjegIrgaca
            // 
            this.cmbBoxUcitajPrijasnjegIrgaca.FormattingEnabled = true;
            this.cmbBoxUcitajPrijasnjegIrgaca.Location = new System.Drawing.Point(92, 213);
            this.cmbBoxUcitajPrijasnjegIrgaca.Name = "cmbBoxUcitajPrijasnjegIrgaca";
            this.cmbBoxUcitajPrijasnjegIrgaca.Size = new System.Drawing.Size(268, 33);
            this.cmbBoxUcitajPrijasnjegIrgaca.TabIndex = 4;
            // 
            // btnUcitajPrijasnjegIgraca
            // 
            this.btnUcitajPrijasnjegIgraca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUcitajPrijasnjegIgraca.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnUcitajPrijasnjegIgraca.Location = new System.Drawing.Point(92, 271);
            this.btnUcitajPrijasnjegIgraca.Name = "btnUcitajPrijasnjegIgraca";
            this.btnUcitajPrijasnjegIgraca.Size = new System.Drawing.Size(268, 36);
            this.btnUcitajPrijasnjegIgraca.TabIndex = 5;
            this.btnUcitajPrijasnjegIgraca.Text = "Ucitaj prijasnjeg";
            this.btnUcitajPrijasnjegIgraca.UseVisualStyleBackColor = true;
            // 
            // listBoxListaIgraca
            // 
            this.listBoxListaIgraca.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.listBoxListaIgraca.FormattingEnabled = true;
            this.listBoxListaIgraca.ItemHeight = 25;
            this.listBoxListaIgraca.Location = new System.Drawing.Point(92, 327);
            this.listBoxListaIgraca.Name = "listBoxListaIgraca";
            this.listBoxListaIgraca.Size = new System.Drawing.Size(268, 154);
            this.listBoxListaIgraca.TabIndex = 6;
            // 
            // btnKreirajNoviTim
            // 
            this.btnKreirajNoviTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKreirajNoviTim.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnKreirajNoviTim.Location = new System.Drawing.Point(793, 491);
            this.btnKreirajNoviTim.Name = "btnKreirajNoviTim";
            this.btnKreirajNoviTim.Size = new System.Drawing.Size(175, 77);
            this.btnKreirajNoviTim.TabIndex = 7;
            this.btnKreirajNoviTim.Text = "Kreiraj novi tim";
            this.btnKreirajNoviTim.UseVisualStyleBackColor = true;
            // 
            // NewTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(980, 580);
            this.Controls.Add(this.btnKreirajNoviTim);
            this.Controls.Add(this.listBoxListaIgraca);
            this.Controls.Add(this.btnUcitajPrijasnjegIgraca);
            this.Controls.Add(this.cmbBoxUcitajPrijasnjegIrgaca);
            this.Controls.Add(this.linkLblKreirajNovogIgraca);
            this.Controls.Add(this.lblIgrac);
            this.Controls.Add(this.lblNazivTima);
            this.Controls.Add(this.lblImeTima);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "NewTeam";
            this.Text = "Create new team";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImeTima;
        private System.Windows.Forms.Label lblNazivTima;
        private System.Windows.Forms.Label lblIgrac;
        private System.Windows.Forms.LinkLabel linkLblKreirajNovogIgraca;
        private System.Windows.Forms.ComboBox cmbBoxUcitajPrijasnjegIrgaca;
        private System.Windows.Forms.Button btnUcitajPrijasnjegIgraca;
        private System.Windows.Forms.ListBox listBoxListaIgraca;
        private System.Windows.Forms.Button btnKreirajNoviTim;
    }
}
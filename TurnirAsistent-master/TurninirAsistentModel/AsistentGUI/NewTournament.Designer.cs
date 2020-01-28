namespace AsistentGUI
{
    partial class NewTournament
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
            this.lblImeTurnira = new System.Windows.Forms.Label();
            this.lblNazivTurnira = new System.Windows.Forms.Label();
            this.lblKotizacija = new System.Windows.Forms.Label();
            this.lblKolicinaKotizacije = new System.Windows.Forms.Label();
            this.lblTimovi = new System.Windows.Forms.Label();
            this.linkLblKreirajNoviTim = new System.Windows.Forms.LinkLabel();
            this.cmbTimoviUcitajPrijasnji = new System.Windows.Forms.ComboBox();
            this.btnUcitajPrijasnji = new System.Windows.Forms.Button();
            this.lblNagrade = new System.Windows.Forms.Label();
            this.linkLblKreirajNovuNagradu = new System.Windows.Forms.LinkLabel();
            this.cmbUcitajPrijasnjuNagradu = new System.Windows.Forms.ComboBox();
            this.btnUcitajPrijasnjuNagradu = new System.Windows.Forms.Button();
            this.listBoxTimovi = new System.Windows.Forms.ListBox();
            this.listBoxNagrade = new System.Windows.Forms.ListBox();
            this.btnKreirajTurnir = new System.Windows.Forms.Button();
            this.btnIzbrisiNagradu = new System.Windows.Forms.Button();
            this.btnIzbrisiTim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblImeTurnira
            // 
            this.lblImeTurnira.AutoSize = true;
            this.lblImeTurnira.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImeTurnira.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblImeTurnira.Location = new System.Drawing.Point(12, 15);
            this.lblImeTurnira.Name = "lblImeTurnira";
            this.lblImeTurnira.Size = new System.Drawing.Size(183, 45);
            this.lblImeTurnira.TabIndex = 0;
            this.lblImeTurnira.Text = "Ime turnira:";
            // 
            // lblNazivTurnira
            // 
            this.lblNazivTurnira.AutoSize = true;
            this.lblNazivTurnira.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivTurnira.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblNazivTurnira.Location = new System.Drawing.Point(201, 15);
            this.lblNazivTurnira.Name = "lblNazivTurnira";
            this.lblNazivTurnira.Size = new System.Drawing.Size(135, 45);
            this.lblNazivTurnira.TabIndex = 1;
            this.lblNazivTurnira.Text = "<naziv>";
            // 
            // lblKotizacija
            // 
            this.lblKotizacija.AutoSize = true;
            this.lblKotizacija.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKotizacija.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblKotizacija.Location = new System.Drawing.Point(13, 75);
            this.lblKotizacija.Name = "lblKotizacija";
            this.lblKotizacija.Size = new System.Drawing.Size(160, 45);
            this.lblKotizacija.TabIndex = 2;
            this.lblKotizacija.Text = "Kotizacija:";
            // 
            // lblKolicinaKotizacije
            // 
            this.lblKolicinaKotizacije.AutoSize = true;
            this.lblKolicinaKotizacije.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKolicinaKotizacije.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblKolicinaKotizacije.Location = new System.Drawing.Point(179, 75);
            this.lblKolicinaKotizacije.Name = "lblKolicinaKotizacije";
            this.lblKolicinaKotizacije.Size = new System.Drawing.Size(172, 45);
            this.lblKolicinaKotizacije.TabIndex = 3;
            this.lblKolicinaKotizacije.Text = "<kolicina>";
            // 
            // lblTimovi
            // 
            this.lblTimovi.AutoSize = true;
            this.lblTimovi.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimovi.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTimovi.Location = new System.Drawing.Point(13, 150);
            this.lblTimovi.Name = "lblTimovi";
            this.lblTimovi.Size = new System.Drawing.Size(115, 45);
            this.lblTimovi.TabIndex = 4;
            this.lblTimovi.Text = "Timovi";
            // 
            // linkLblKreirajNoviTim
            // 
            this.linkLblKreirajNoviTim.AutoSize = true;
            this.linkLblKreirajNoviTim.Location = new System.Drawing.Point(134, 166);
            this.linkLblKreirajNoviTim.Name = "linkLblKreirajNoviTim";
            this.linkLblKreirajNoviTim.Size = new System.Drawing.Size(138, 25);
            this.linkLblKreirajNoviTim.TabIndex = 5;
            this.linkLblKreirajNoviTim.TabStop = true;
            this.linkLblKreirajNoviTim.Text = "kreiraj novi tim";
            // 
            // cmbTimoviUcitajPrijasnji
            // 
            this.cmbTimoviUcitajPrijasnji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTimoviUcitajPrijasnji.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cmbTimoviUcitajPrijasnji.FormattingEnabled = true;
            this.cmbTimoviUcitajPrijasnji.Location = new System.Drawing.Point(21, 198);
            this.cmbTimoviUcitajPrijasnji.Name = "cmbTimoviUcitajPrijasnji";
            this.cmbTimoviUcitajPrijasnji.Size = new System.Drawing.Size(251, 33);
            this.cmbTimoviUcitajPrijasnji.TabIndex = 6;
            // 
            // btnUcitajPrijasnji
            // 
            this.btnUcitajPrijasnji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUcitajPrijasnji.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnUcitajPrijasnji.Location = new System.Drawing.Point(20, 237);
            this.btnUcitajPrijasnji.Name = "btnUcitajPrijasnji";
            this.btnUcitajPrijasnji.Size = new System.Drawing.Size(153, 38);
            this.btnUcitajPrijasnji.TabIndex = 7;
            this.btnUcitajPrijasnji.Text = "Ucitaj prijasnji";
            this.btnUcitajPrijasnji.UseVisualStyleBackColor = true;
            // 
            // lblNagrade
            // 
            this.lblNagrade.AutoSize = true;
            this.lblNagrade.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNagrade.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblNagrade.Location = new System.Drawing.Point(420, 150);
            this.lblNagrade.Name = "lblNagrade";
            this.lblNagrade.Size = new System.Drawing.Size(142, 45);
            this.lblNagrade.TabIndex = 8;
            this.lblNagrade.Text = "Nagrade";
            // 
            // linkLblKreirajNovuNagradu
            // 
            this.linkLblKreirajNovuNagradu.AutoSize = true;
            this.linkLblKreirajNovuNagradu.Location = new System.Drawing.Point(568, 166);
            this.linkLblKreirajNovuNagradu.Name = "linkLblKreirajNovuNagradu";
            this.linkLblKreirajNovuNagradu.Size = new System.Drawing.Size(188, 25);
            this.linkLblKreirajNovuNagradu.TabIndex = 9;
            this.linkLblKreirajNovuNagradu.TabStop = true;
            this.linkLblKreirajNovuNagradu.Text = "kreiraj novu nagradu";
            // 
            // cmbUcitajPrijasnjuNagradu
            // 
            this.cmbUcitajPrijasnjuNagradu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUcitajPrijasnjuNagradu.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cmbUcitajPrijasnjuNagradu.FormattingEnabled = true;
            this.cmbUcitajPrijasnjuNagradu.Location = new System.Drawing.Point(428, 198);
            this.cmbUcitajPrijasnjuNagradu.Name = "cmbUcitajPrijasnjuNagradu";
            this.cmbUcitajPrijasnjuNagradu.Size = new System.Drawing.Size(328, 33);
            this.cmbUcitajPrijasnjuNagradu.TabIndex = 10;
            // 
            // btnUcitajPrijasnjuNagradu
            // 
            this.btnUcitajPrijasnjuNagradu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUcitajPrijasnjuNagradu.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnUcitajPrijasnjuNagradu.Location = new System.Drawing.Point(428, 237);
            this.btnUcitajPrijasnjuNagradu.Name = "btnUcitajPrijasnjuNagradu";
            this.btnUcitajPrijasnjuNagradu.Size = new System.Drawing.Size(153, 38);
            this.btnUcitajPrijasnjuNagradu.TabIndex = 11;
            this.btnUcitajPrijasnjuNagradu.Text = "Ucitaj prijasnju";
            this.btnUcitajPrijasnjuNagradu.UseVisualStyleBackColor = true;
            // 
            // listBoxTimovi
            // 
            this.listBoxTimovi.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.listBoxTimovi.FormattingEnabled = true;
            this.listBoxTimovi.ItemHeight = 25;
            this.listBoxTimovi.Location = new System.Drawing.Point(21, 292);
            this.listBoxTimovi.Name = "listBoxTimovi";
            this.listBoxTimovi.Size = new System.Drawing.Size(251, 129);
            this.listBoxTimovi.TabIndex = 12;
            // 
            // listBoxNagrade
            // 
            this.listBoxNagrade.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.listBoxNagrade.FormattingEnabled = true;
            this.listBoxNagrade.ItemHeight = 25;
            this.listBoxNagrade.Location = new System.Drawing.Point(428, 292);
            this.listBoxNagrade.Name = "listBoxNagrade";
            this.listBoxNagrade.Size = new System.Drawing.Size(328, 129);
            this.listBoxNagrade.TabIndex = 13;
            // 
            // btnKreirajTurnir
            // 
            this.btnKreirajTurnir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKreirajTurnir.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnKreirajTurnir.Location = new System.Drawing.Point(857, 426);
            this.btnKreirajTurnir.Name = "btnKreirajTurnir";
            this.btnKreirajTurnir.Size = new System.Drawing.Size(159, 71);
            this.btnKreirajTurnir.TabIndex = 14;
            this.btnKreirajTurnir.Text = "Kreiraj turnir";
            this.btnKreirajTurnir.UseVisualStyleBackColor = true;
            // 
            // btnIzbrisiNagradu
            // 
            this.btnIzbrisiNagradu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzbrisiNagradu.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnIzbrisiNagradu.Location = new System.Drawing.Point(762, 292);
            this.btnIzbrisiNagradu.Name = "btnIzbrisiNagradu";
            this.btnIzbrisiNagradu.Size = new System.Drawing.Size(90, 76);
            this.btnIzbrisiNagradu.TabIndex = 15;
            this.btnIzbrisiNagradu.Text = "Izbrisi";
            this.btnIzbrisiNagradu.UseVisualStyleBackColor = true;
            // 
            // btnIzbrisiTim
            // 
            this.btnIzbrisiTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzbrisiTim.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzbrisiTim.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnIzbrisiTim.Location = new System.Drawing.Point(278, 292);
            this.btnIzbrisiTim.Name = "btnIzbrisiTim";
            this.btnIzbrisiTim.Size = new System.Drawing.Size(90, 76);
            this.btnIzbrisiTim.TabIndex = 16;
            this.btnIzbrisiTim.Text = "Izbrisi";
            this.btnIzbrisiTim.UseVisualStyleBackColor = true;
            // 
            // NewTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1028, 509);
            this.Controls.Add(this.btnIzbrisiTim);
            this.Controls.Add(this.btnIzbrisiNagradu);
            this.Controls.Add(this.btnKreirajTurnir);
            this.Controls.Add(this.listBoxNagrade);
            this.Controls.Add(this.listBoxTimovi);
            this.Controls.Add(this.btnUcitajPrijasnjuNagradu);
            this.Controls.Add(this.cmbUcitajPrijasnjuNagradu);
            this.Controls.Add(this.linkLblKreirajNovuNagradu);
            this.Controls.Add(this.lblNagrade);
            this.Controls.Add(this.btnUcitajPrijasnji);
            this.Controls.Add(this.cmbTimoviUcitajPrijasnji);
            this.Controls.Add(this.linkLblKreirajNoviTim);
            this.Controls.Add(this.lblTimovi);
            this.Controls.Add(this.lblKolicinaKotizacije);
            this.Controls.Add(this.lblKotizacija);
            this.Controls.Add(this.lblNazivTurnira);
            this.Controls.Add(this.lblImeTurnira);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "NewTournament";
            this.Text = "Create new tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImeTurnira;
        private System.Windows.Forms.Label lblNazivTurnira;
        private System.Windows.Forms.Label lblKotizacija;
        private System.Windows.Forms.Label lblKolicinaKotizacije;
        private System.Windows.Forms.Label lblTimovi;
        private System.Windows.Forms.LinkLabel linkLblKreirajNoviTim;
        private System.Windows.Forms.ComboBox cmbTimoviUcitajPrijasnji;
        private System.Windows.Forms.Button btnUcitajPrijasnji;
        private System.Windows.Forms.Label lblNagrade;
        private System.Windows.Forms.LinkLabel linkLblKreirajNovuNagradu;
        private System.Windows.Forms.ComboBox cmbUcitajPrijasnjuNagradu;
        private System.Windows.Forms.Button btnUcitajPrijasnjuNagradu;
        private System.Windows.Forms.ListBox listBoxTimovi;
        private System.Windows.Forms.ListBox listBoxNagrade;
        private System.Windows.Forms.Button btnKreirajTurnir;
        private System.Windows.Forms.Button btnIzbrisiNagradu;
        private System.Windows.Forms.Button btnIzbrisiTim;
    }
}
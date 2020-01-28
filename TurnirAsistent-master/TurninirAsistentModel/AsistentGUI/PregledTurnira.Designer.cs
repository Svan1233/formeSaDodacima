namespace AsistentGUI
{
    partial class PregledTurnira
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
            this.lblTurnir = new System.Windows.Forms.Label();
            this.lblNazivTurnira = new System.Windows.Forms.Label();
            this.lblRunda = new System.Windows.Forms.Label();
            this.cmbRunde = new System.Windows.Forms.ComboBox();
            this.lstParovi = new System.Windows.Forms.ListBox();
            this.chk = new System.Windows.Forms.CheckBox();
            this.lblRezultatPrveEkipe = new System.Windows.Forms.Label();
            this.lblRezultat = new System.Windows.Forms.Label();
            this.txtRezultatPrveEkipe = new System.Windows.Forms.TextBox();
            this.txtDrugeEkipe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRezultatDrugeEkipe = new System.Windows.Forms.Label();
            this.lblVs = new System.Windows.Forms.Label();
            this.btnSpremiRezultat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTurnir
            // 
            this.lblTurnir.AutoSize = true;
            this.lblTurnir.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnir.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTurnir.Location = new System.Drawing.Point(18, 31);
            this.lblTurnir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurnir.Name = "lblTurnir";
            this.lblTurnir.Size = new System.Drawing.Size(110, 45);
            this.lblTurnir.TabIndex = 0;
            this.lblTurnir.Text = "Turnir:";
            // 
            // lblNazivTurnira
            // 
            this.lblNazivTurnira.AutoSize = true;
            this.lblNazivTurnira.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivTurnira.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblNazivTurnira.Location = new System.Drawing.Point(136, 31);
            this.lblNazivTurnira.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNazivTurnira.Name = "lblNazivTurnira";
            this.lblNazivTurnira.Size = new System.Drawing.Size(135, 45);
            this.lblNazivTurnira.TabIndex = 1;
            this.lblNazivTurnira.Text = "<naziv>";
            // 
            // lblRunda
            // 
            this.lblRunda.AutoSize = true;
            this.lblRunda.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblRunda.Location = new System.Drawing.Point(19, 110);
            this.lblRunda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRunda.Name = "lblRunda";
            this.lblRunda.Size = new System.Drawing.Size(99, 37);
            this.lblRunda.TabIndex = 2;
            this.lblRunda.Text = "Runda:";
            // 
            // cmbRunde
            // 
            this.cmbRunde.FormattingEnabled = true;
            this.cmbRunde.Location = new System.Drawing.Point(125, 107);
            this.cmbRunde.Name = "cmbRunde";
            this.cmbRunde.Size = new System.Drawing.Size(249, 45);
            this.cmbRunde.TabIndex = 3;
            // 
            // lstParovi
            // 
            this.lstParovi.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lstParovi.FormattingEnabled = true;
            this.lstParovi.ItemHeight = 37;
            this.lstParovi.Location = new System.Drawing.Point(26, 236);
            this.lstParovi.Name = "lstParovi";
            this.lstParovi.Size = new System.Drawing.Size(348, 263);
            this.lstParovi.TabIndex = 4;
            // 
            // chk
            // 
            this.chk.AutoSize = true;
            this.chk.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.chk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.chk.Location = new System.Drawing.Point(26, 175);
            this.chk.Name = "chk";
            this.chk.Size = new System.Drawing.Size(367, 41);
            this.chk.TabIndex = 5;
            this.chk.Text = "Prikazi neodigrane utakmice";
            this.chk.UseVisualStyleBackColor = true;
            // 
            // lblRezultatPrveEkipe
            // 
            this.lblRezultatPrveEkipe.AutoSize = true;
            this.lblRezultatPrveEkipe.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRezultatPrveEkipe.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblRezultatPrveEkipe.Location = new System.Drawing.Point(398, 263);
            this.lblRezultatPrveEkipe.Name = "lblRezultatPrveEkipe";
            this.lblRezultatPrveEkipe.Size = new System.Drawing.Size(130, 30);
            this.lblRezultatPrveEkipe.TabIndex = 6;
            this.lblRezultatPrveEkipe.Text = "<prvaEkipa>";
            // 
            // lblRezultat
            // 
            this.lblRezultat.AutoSize = true;
            this.lblRezultat.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRezultat.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblRezultat.Location = new System.Drawing.Point(398, 305);
            this.lblRezultat.Name = "lblRezultat";
            this.lblRezultat.Size = new System.Drawing.Size(93, 30);
            this.lblRezultat.TabIndex = 7;
            this.lblRezultat.Text = "Rezultat:";
            // 
            // txtRezultatPrveEkipe
            // 
            this.txtRezultatPrveEkipe.Location = new System.Drawing.Point(497, 296);
            this.txtRezultatPrveEkipe.Name = "txtRezultatPrveEkipe";
            this.txtRezultatPrveEkipe.Size = new System.Drawing.Size(158, 43);
            this.txtRezultatPrveEkipe.TabIndex = 8;
            // 
            // txtDrugeEkipe
            // 
            this.txtDrugeEkipe.Location = new System.Drawing.Point(497, 418);
            this.txtDrugeEkipe.Name = "txtDrugeEkipe";
            this.txtDrugeEkipe.Size = new System.Drawing.Size(158, 43);
            this.txtDrugeEkipe.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(398, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Rezultat:";
            // 
            // lblRezultatDrugeEkipe
            // 
            this.lblRezultatDrugeEkipe.AutoSize = true;
            this.lblRezultatDrugeEkipe.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRezultatDrugeEkipe.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblRezultatDrugeEkipe.Location = new System.Drawing.Point(398, 385);
            this.lblRezultatDrugeEkipe.Name = "lblRezultatDrugeEkipe";
            this.lblRezultatDrugeEkipe.Size = new System.Drawing.Size(130, 30);
            this.lblRezultatDrugeEkipe.TabIndex = 9;
            this.lblRezultatDrugeEkipe.Text = "<prvaEkipa>";
            // 
            // lblVs
            // 
            this.lblVs.AutoSize = true;
            this.lblVs.ForeColor = System.Drawing.Color.Maroon;
            this.lblVs.Location = new System.Drawing.Point(490, 348);
            this.lblVs.Name = "lblVs";
            this.lblVs.Size = new System.Drawing.Size(70, 37);
            this.lblVs.TabIndex = 12;
            this.lblVs.Text = "-VS-";
            // 
            // btnSpremiRezultat
            // 
            this.btnSpremiRezultat.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnSpremiRezultat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremiRezultat.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnSpremiRezultat.Location = new System.Drawing.Point(776, 447);
            this.btnSpremiRezultat.Name = "btnSpremiRezultat";
            this.btnSpremiRezultat.Size = new System.Drawing.Size(162, 67);
            this.btnSpremiRezultat.TabIndex = 13;
            this.btnSpremiRezultat.Text = "Spremi";
            this.btnSpremiRezultat.UseVisualStyleBackColor = true;
            // 
            // PregledTurnira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(950, 526);
            this.Controls.Add(this.btnSpremiRezultat);
            this.Controls.Add(this.lblVs);
            this.Controls.Add(this.txtDrugeEkipe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRezultatDrugeEkipe);
            this.Controls.Add(this.txtRezultatPrveEkipe);
            this.Controls.Add(this.lblRezultat);
            this.Controls.Add(this.lblRezultatPrveEkipe);
            this.Controls.Add(this.chk);
            this.Controls.Add(this.lstParovi);
            this.Controls.Add(this.cmbRunde);
            this.Controls.Add(this.lblRunda);
            this.Controls.Add(this.lblNazivTurnira);
            this.Controls.Add(this.lblTurnir);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "PregledTurnira";
            this.Text = "Pregled Turnira";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTurnir;
        private System.Windows.Forms.Label lblNazivTurnira;
        private System.Windows.Forms.Label lblRunda;
        private System.Windows.Forms.ComboBox cmbRunde;
        private System.Windows.Forms.ListBox lstParovi;
        private System.Windows.Forms.CheckBox chk;
        private System.Windows.Forms.Label lblRezultatPrveEkipe;
        private System.Windows.Forms.Label lblRezultat;
        private System.Windows.Forms.TextBox txtRezultatPrveEkipe;
        private System.Windows.Forms.TextBox txtDrugeEkipe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRezultatDrugeEkipe;
        private System.Windows.Forms.Label lblVs;
        private System.Windows.Forms.Button btnSpremiRezultat;
    }
}


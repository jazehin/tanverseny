namespace tanverseny
{
    partial class Form1
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
            this.dgvTablazat = new System.Windows.Forms.DataGridView();
            this.azonosito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versenynev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esemeny = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Azonosító = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbAdatkezeles = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.tbEsemeny = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbVtipus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVnev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFrissit = new System.Windows.Forms.Button();
            this.btnModosit = new System.Windows.Forms.Button();
            this.btnBeszur = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablazat)).BeginInit();
            this.gbAdatkezeles.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTablazat
            // 
            this.dgvTablazat.AllowUserToAddRows = false;
            this.dgvTablazat.AllowUserToDeleteRows = false;
            this.dgvTablazat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablazat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.azonosito,
            this.versenynev,
            this.tipus,
            this.esemeny,
            this.datum});
            this.dgvTablazat.Location = new System.Drawing.Point(191, 47);
            this.dgvTablazat.Name = "dgvTablazat";
            this.dgvTablazat.ReadOnly = true;
            this.dgvTablazat.RowTemplate.Height = 25;
            this.dgvTablazat.Size = new System.Drawing.Size(736, 183);
            this.dgvTablazat.TabIndex = 0;
            this.dgvTablazat.SelectionChanged += new System.EventHandler(this.KijelolesValtozott);
            // 
            // azonosito
            // 
            this.azonosito.HeaderText = "Azonosító";
            this.azonosito.Name = "azonosito";
            this.azonosito.ReadOnly = true;
            // 
            // versenynev
            // 
            this.versenynev.HeaderText = "Verseny neve";
            this.versenynev.Name = "versenynev";
            this.versenynev.ReadOnly = true;
            // 
            // tipus
            // 
            this.tipus.HeaderText = "Versenytípus";
            this.tipus.Name = "tipus";
            this.tipus.ReadOnly = true;
            // 
            // esemeny
            // 
            this.esemeny.HeaderText = "Esemény";
            this.esemeny.Name = "esemeny";
            this.esemeny.ReadOnly = true;
            // 
            // datum
            // 
            this.datum.HeaderText = "Dátum";
            this.datum.Name = "datum";
            this.datum.ReadOnly = true;
            // 
            // Azonosító
            // 
            this.Azonosító.HeaderText = "Azonosító";
            this.Azonosító.Name = "Azonosító";
            // 
            // gbAdatkezeles
            // 
            this.gbAdatkezeles.Controls.Add(this.label4);
            this.gbAdatkezeles.Controls.Add(this.dtp);
            this.gbAdatkezeles.Controls.Add(this.tbEsemeny);
            this.gbAdatkezeles.Controls.Add(this.label3);
            this.gbAdatkezeles.Controls.Add(this.tbVtipus);
            this.gbAdatkezeles.Controls.Add(this.label2);
            this.gbAdatkezeles.Controls.Add(this.tbVnev);
            this.gbAdatkezeles.Controls.Add(this.label1);
            this.gbAdatkezeles.Location = new System.Drawing.Point(191, 260);
            this.gbAdatkezeles.Name = "gbAdatkezeles";
            this.gbAdatkezeles.Size = new System.Drawing.Size(736, 162);
            this.gbAdatkezeles.TabIndex = 1;
            this.gbAdatkezeles.TabStop = false;
            this.gbAdatkezeles.Text = "Adatkezelés";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dátum:";
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(479, 33);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(236, 23);
            this.dtp.TabIndex = 6;
            // 
            // tbEsemeny
            // 
            this.tbEsemeny.Location = new System.Drawing.Point(107, 115);
            this.tbEsemeny.Name = "tbEsemeny";
            this.tbEsemeny.Size = new System.Drawing.Size(289, 23);
            this.tbEsemeny.TabIndex = 5;
            this.tbEsemeny.TextChanged += new System.EventHandler(this.TextBoxValtozott);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Esemény:";
            // 
            // tbVtipus
            // 
            this.tbVtipus.Location = new System.Drawing.Point(107, 75);
            this.tbVtipus.Name = "tbVtipus";
            this.tbVtipus.Size = new System.Drawing.Size(289, 23);
            this.tbVtipus.TabIndex = 3;
            this.tbVtipus.TextChanged += new System.EventHandler(this.TextBoxValtozott);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Verseny típusa:";
            // 
            // tbVnev
            // 
            this.tbVnev.Location = new System.Drawing.Point(107, 33);
            this.tbVnev.Name = "tbVnev";
            this.tbVnev.Size = new System.Drawing.Size(289, 23);
            this.tbVnev.TabIndex = 1;
            this.tbVnev.TextChanged += new System.EventHandler(this.TextBoxValtozott);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Verseny neve:";
            // 
            // btnFrissit
            // 
            this.btnFrissit.BackgroundImage = global::tanverseny.Properties.Resources.Update;
            this.btnFrissit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFrissit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFrissit.Location = new System.Drawing.Point(39, 47);
            this.btnFrissit.Name = "btnFrissit";
            this.btnFrissit.Size = new System.Drawing.Size(120, 120);
            this.btnFrissit.TabIndex = 2;
            this.btnFrissit.UseVisualStyleBackColor = true;
            this.btnFrissit.Click += new System.EventHandler(this.Frissites);
            // 
            // btnModosit
            // 
            this.btnModosit.BackgroundImage = global::tanverseny.Properties.Resources.Modify;
            this.btnModosit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModosit.Enabled = false;
            this.btnModosit.Location = new System.Drawing.Point(39, 173);
            this.btnModosit.Name = "btnModosit";
            this.btnModosit.Size = new System.Drawing.Size(120, 120);
            this.btnModosit.TabIndex = 3;
            this.btnModosit.UseVisualStyleBackColor = true;
            this.btnModosit.Click += new System.EventHandler(this.Modositas);
            // 
            // btnBeszur
            // 
            this.btnBeszur.BackgroundImage = global::tanverseny.Properties.Resources.Paste;
            this.btnBeszur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBeszur.Enabled = false;
            this.btnBeszur.Location = new System.Drawing.Point(39, 302);
            this.btnBeszur.Name = "btnBeszur";
            this.btnBeszur.Size = new System.Drawing.Size(120, 120);
            this.btnBeszur.TabIndex = 4;
            this.btnBeszur.UseVisualStyleBackColor = true;
            this.btnBeszur.Click += new System.EventHandler(this.Beszuras);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 456);
            this.Controls.Add(this.btnBeszur);
            this.Controls.Add(this.btnModosit);
            this.Controls.Add(this.btnFrissit);
            this.Controls.Add(this.gbAdatkezeles);
            this.Controls.Add(this.dgvTablazat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmClosing);
            this.Load += new System.EventHandler(this.FrmLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablazat)).EndInit();
            this.gbAdatkezeles.ResumeLayout(false);
            this.gbAdatkezeles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvTablazat;
        private DataGridViewTextBoxColumn Azonosító;
        private GroupBox gbAdatkezeles;
        private Button btnFrissit;
        private Button btnModosit;
        private Button btnBeszur;
        private Label label1;
        private Label label4;
        private DateTimePicker dtp;
        private TextBox tbEsemeny;
        private Label label3;
        private TextBox tbVtipus;
        private Label label2;
        private TextBox tbVnev;
        private DataGridViewTextBoxColumn azonosito;
        private DataGridViewTextBoxColumn versenynev;
        private DataGridViewTextBoxColumn tipus;
        private DataGridViewTextBoxColumn esemeny;
        private DataGridViewTextBoxColumn datum;
    }
}
namespace ProjektEkwipunek
{
    partial class Form1
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
            this.OpisPostaci = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ListaPostaci = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.TextBox();
            this.udzwig = new System.Windows.Forms.TextBox();
            this.moc = new System.Windows.Forms.TextBox();
            this.obrona = new System.Windows.Forms.TextBox();
            this.inteligencja = new System.Windows.Forms.TextBox();
            this.liczbaPrzedmiotow = new System.Windows.Forms.TextBox();
            this.Sklep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // OpisPostaci
            // 
            this.OpisPostaci.Enabled = false;
            this.OpisPostaci.Location = new System.Drawing.Point(271, 69);
            this.OpisPostaci.Multiline = true;
            this.OpisPostaci.Name = "OpisPostaci";
            this.OpisPostaci.Size = new System.Drawing.Size(380, 101);
            this.OpisPostaci.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Informacje o postaci ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(681, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Udźwig";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(703, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Moc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(681, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Obrona";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(652, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Inteligencja";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Przedmioty";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(960, 333);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ListaPostaci
            // 
            this.ListaPostaci.FormattingEnabled = true;
            this.ListaPostaci.Location = new System.Drawing.Point(91, 22);
            this.ListaPostaci.Name = "ListaPostaci";
            this.ListaPostaci.Size = new System.Drawing.Size(163, 28);
            this.ListaPostaci.TabIndex = 8;
            this.ListaPostaci.SelectedIndexChanged += new System.EventHandler(this.ListaPostaci_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Level";
            // 
            // level
            // 
            this.level.Enabled = false;
            this.level.Location = new System.Drawing.Point(119, 115);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(78, 26);
            this.level.TabIndex = 10;
            // 
            // udzwig
            // 
            this.udzwig.Enabled = false;
            this.udzwig.Location = new System.Drawing.Point(768, 53);
            this.udzwig.Name = "udzwig";
            this.udzwig.Size = new System.Drawing.Size(208, 26);
            this.udzwig.TabIndex = 11;
            // 
            // moc
            // 
            this.moc.Enabled = false;
            this.moc.Location = new System.Drawing.Point(768, 95);
            this.moc.Name = "moc";
            this.moc.Size = new System.Drawing.Size(208, 26);
            this.moc.TabIndex = 12;
            // 
            // obrona
            // 
            this.obrona.Enabled = false;
            this.obrona.Location = new System.Drawing.Point(768, 144);
            this.obrona.Name = "obrona";
            this.obrona.Size = new System.Drawing.Size(208, 26);
            this.obrona.TabIndex = 13;
            // 
            // inteligencja
            // 
            this.inteligencja.Enabled = false;
            this.inteligencja.Location = new System.Drawing.Point(768, 183);
            this.inteligencja.Name = "inteligencja";
            this.inteligencja.Size = new System.Drawing.Size(208, 26);
            this.inteligencja.TabIndex = 14;
            // 
            // liczbaPrzedmiotow
            // 
            this.liczbaPrzedmiotow.Enabled = false;
            this.liczbaPrzedmiotow.Location = new System.Drawing.Point(123, 187);
            this.liczbaPrzedmiotow.Name = "liczbaPrzedmiotow";
            this.liczbaPrzedmiotow.Size = new System.Drawing.Size(74, 26);
            this.liczbaPrzedmiotow.TabIndex = 15;
            // 
            // Sklep
            // 
            this.Sklep.Location = new System.Drawing.Point(667, 584);
            this.Sklep.Name = "Sklep";
            this.Sklep.Size = new System.Drawing.Size(75, 42);
            this.Sklep.TabIndex = 16;
            this.Sklep.Text = "Sklep";
            this.Sklep.UseVisualStyleBackColor = true;
            this.Sklep.Click += new System.EventHandler(this.Sklep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 638);
            this.Controls.Add(this.Sklep);
            this.Controls.Add(this.liczbaPrzedmiotow);
            this.Controls.Add(this.inteligencja);
            this.Controls.Add(this.obrona);
            this.Controls.Add(this.moc);
            this.Controls.Add(this.udzwig);
            this.Controls.Add(this.level);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ListaPostaci);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpisPostaci);
            this.Name = "Form1";
            this.Text = "EkwipunekGracza";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OpisPostaci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox ListaPostaci;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox level;
        private System.Windows.Forms.TextBox udzwig;
        private System.Windows.Forms.TextBox moc;
        private System.Windows.Forms.TextBox obrona;
        private System.Windows.Forms.TextBox inteligencja;
        private System.Windows.Forms.TextBox liczbaPrzedmiotow;
        private System.Windows.Forms.Button Sklep;
    }
}


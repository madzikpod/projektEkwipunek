namespace ProjektEkwipunek
{
    partial class OknoPostaciForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NazwaTextBox = new System.Windows.Forms.TextBox();
            this.OpisTextBox = new System.Windows.Forms.TextBox();
            this.LevelNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TypComboBox = new System.Windows.Forms.ComboBox();
            this.ZapiszPostacButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LevelNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Typ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Opis:";
            // 
            // NazwaTextBox
            // 
            this.NazwaTextBox.Location = new System.Drawing.Point(127, 22);
            this.NazwaTextBox.Name = "NazwaTextBox";
            this.NazwaTextBox.Size = new System.Drawing.Size(198, 26);
            this.NazwaTextBox.TabIndex = 4;
            // 
            // OpisTextBox
            // 
            this.OpisTextBox.Location = new System.Drawing.Point(408, 22);
            this.OpisTextBox.Multiline = true;
            this.OpisTextBox.Name = "OpisTextBox";
            this.OpisTextBox.Size = new System.Drawing.Size(242, 201);
            this.OpisTextBox.TabIndex = 5;
            // 
            // LevelNumericUpDown
            // 
            this.LevelNumericUpDown.Location = new System.Drawing.Point(127, 78);
            this.LevelNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LevelNumericUpDown.Name = "LevelNumericUpDown";
            this.LevelNumericUpDown.Size = new System.Drawing.Size(198, 26);
            this.LevelNumericUpDown.TabIndex = 6;
            this.LevelNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TypComboBox
            // 
            this.TypComboBox.FormattingEnabled = true;
            this.TypComboBox.Location = new System.Drawing.Point(126, 140);
            this.TypComboBox.Name = "TypComboBox";
            this.TypComboBox.Size = new System.Drawing.Size(199, 28);
            this.TypComboBox.TabIndex = 7;
            // 
            // ZapiszPostacButton
            // 
            this.ZapiszPostacButton.Location = new System.Drawing.Point(562, 237);
            this.ZapiszPostacButton.Name = "ZapiszPostacButton";
            this.ZapiszPostacButton.Size = new System.Drawing.Size(88, 46);
            this.ZapiszPostacButton.TabIndex = 8;
            this.ZapiszPostacButton.Text = "Zapisz";
            this.ZapiszPostacButton.UseVisualStyleBackColor = true;
            this.ZapiszPostacButton.Click += new System.EventHandler(this.ZapiszButton_onClic);
            // 
            // OknoPostaciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 295);
            this.Controls.Add(this.ZapiszPostacButton);
            this.Controls.Add(this.TypComboBox);
            this.Controls.Add(this.LevelNumericUpDown);
            this.Controls.Add(this.OpisTextBox);
            this.Controls.Add(this.NazwaTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OknoPostaciForm";
            this.Text = "OknoPostaciForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OknoPostaciForm_FormClosed);
            this.Load += new System.EventHandler(this.OknoPostaciForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LevelNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NazwaTextBox;
        private System.Windows.Forms.TextBox OpisTextBox;
        private System.Windows.Forms.NumericUpDown LevelNumericUpDown;
        private System.Windows.Forms.ComboBox TypComboBox;
        private System.Windows.Forms.Button ZapiszPostacButton;
    }
}
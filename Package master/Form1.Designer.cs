namespace Package_master
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Height_numeric_updown = new System.Windows.Forms.NumericUpDown();
            this.LHeight = new System.Windows.Forms.Label();
            this.Weight_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.BDelete_Package = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Height_numeric_updown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Rysuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.AccessibleName = "Dodaj paczkę";
            this.button2.Location = new System.Drawing.Point(417, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Dodaj paczkę";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(517, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(145, 225);
            this.listBox1.TabIndex = 3;
            // 
            // Height_numeric_updown
            // 
            this.Height_numeric_updown.AccessibleDescription = "Dlugosc_numeris";
            this.Height_numeric_updown.Location = new System.Drawing.Point(391, 171);
            this.Height_numeric_updown.Name = "Height_numeric_updown";
            this.Height_numeric_updown.Size = new System.Drawing.Size(120, 20);
            this.Height_numeric_updown.TabIndex = 4;
            this.Height_numeric_updown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // LHeight
            // 
            this.LHeight.AutoSize = true;
            this.LHeight.Location = new System.Drawing.Point(328, 173);
            this.LHeight.Name = "LHeight";
            this.LHeight.Size = new System.Drawing.Size(57, 13);
            this.LHeight.TabIndex = 5;
            this.LHeight.Text = "Wysokość";
            this.LHeight.Click += new System.EventHandler(this.LHeight_Click);
            // 
            // Weight_numericUpDown
            // 
            this.Weight_numericUpDown.AccessibleDescription = "Dlugosc_numeris";
            this.Weight_numericUpDown.Location = new System.Drawing.Point(391, 197);
            this.Weight_numericUpDown.Name = "Weight_numericUpDown";
            this.Weight_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.Weight_numericUpDown.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Szerokość";
            // 
            // BDelete_Package
            // 
            this.BDelete_Package.Location = new System.Drawing.Point(436, 41);
            this.BDelete_Package.Name = "BDelete_Package";
            this.BDelete_Package.Size = new System.Drawing.Size(75, 23);
            this.BDelete_Package.TabIndex = 8;
            this.BDelete_Package.Text = "Usuń";
            this.BDelete_Package.UseVisualStyleBackColor = true;
            this.BDelete_Package.Click += new System.EventHandler(this.BDelete_Package_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(436, 71);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 9;
            this.bSave.Text = "Zapisz";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bLoad
            // 
            this.bLoad.Location = new System.Drawing.Point(436, 101);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(75, 23);
            this.bLoad.TabIndex = 10;
            this.bLoad.Text = "Wczytaj";
            this.bLoad.UseVisualStyleBackColor = true;
            this.bLoad.Click += new System.EventHandler(this.bLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 304);
            this.Controls.Add(this.bLoad);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.BDelete_Package);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Weight_numericUpDown);
            this.Controls.Add(this.LHeight);
            this.Controls.Add(this.Height_numeric_updown);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "s";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Height_numeric_updown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown Height_numeric_updown;
        private System.Windows.Forms.Label LHeight;
        private System.Windows.Forms.NumericUpDown Weight_numericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BDelete_Package;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bLoad;
    }
}


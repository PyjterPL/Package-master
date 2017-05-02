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
            this.bRysuj = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lPackage_list = new System.Windows.Forms.ListBox();
            this.Height_numeric_updown = new System.Windows.Forms.NumericUpDown();
            this.LHeight = new System.Windows.Forms.Label();
            this.Weight_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.BDelete_Package = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bLoad = new System.Windows.Forms.Button();
            this.gDefined_Packages = new System.Windows.Forms.GroupBox();
            this.lContainer_packages = new System.Windows.Forms.ListBox();
            this.bContainerAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Height_numeric_updown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight_numericUpDown)).BeginInit();
            this.gDefined_Packages.SuspendLayout();
            this.SuspendLayout();
            // 
            // bRysuj
            // 
            this.bRysuj.Location = new System.Drawing.Point(12, 478);
            this.bRysuj.Name = "bRysuj";
            this.bRysuj.Size = new System.Drawing.Size(75, 23);
            this.bRysuj.TabIndex = 0;
            this.bRysuj.Text = "Rysuj";
            this.bRysuj.UseVisualStyleBackColor = true;
            this.bRysuj.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.AccessibleName = "Dodaj paczkę";
            this.button2.Location = new System.Drawing.Point(153, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Dodaj paczkę";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lPackage_list
            // 
            this.lPackage_list.FormattingEnabled = true;
            this.lPackage_list.Location = new System.Drawing.Point(253, 19);
            this.lPackage_list.Name = "lPackage_list";
            this.lPackage_list.Size = new System.Drawing.Size(145, 225);
            this.lPackage_list.TabIndex = 3;
            this.lPackage_list.SelectedIndexChanged += new System.EventHandler(this.lPackage_list_SelectedIndexChanged);
            // 
            // Height_numeric_updown
            // 
            this.Height_numeric_updown.AccessibleDescription = "Dlugosc_numeris";
            this.Height_numeric_updown.Location = new System.Drawing.Point(127, 178);
            this.Height_numeric_updown.Name = "Height_numeric_updown";
            this.Height_numeric_updown.Size = new System.Drawing.Size(120, 20);
            this.Height_numeric_updown.TabIndex = 4;
            this.Height_numeric_updown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // LHeight
            // 
            this.LHeight.AutoSize = true;
            this.LHeight.Location = new System.Drawing.Point(64, 185);
            this.LHeight.Name = "LHeight";
            this.LHeight.Size = new System.Drawing.Size(57, 13);
            this.LHeight.TabIndex = 5;
            this.LHeight.Text = "Wysokość";
            this.LHeight.Click += new System.EventHandler(this.LHeight_Click);
            // 
            // Weight_numericUpDown
            // 
            this.Weight_numericUpDown.AccessibleDescription = "Dlugosc_numeris";
            this.Weight_numericUpDown.Location = new System.Drawing.Point(127, 204);
            this.Weight_numericUpDown.Name = "Weight_numericUpDown";
            this.Weight_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.Weight_numericUpDown.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Szerokość";
            // 
            // BDelete_Package
            // 
            this.BDelete_Package.Location = new System.Drawing.Point(172, 48);
            this.BDelete_Package.Name = "BDelete_Package";
            this.BDelete_Package.Size = new System.Drawing.Size(75, 23);
            this.BDelete_Package.TabIndex = 8;
            this.BDelete_Package.Text = "Usuń";
            this.BDelete_Package.UseVisualStyleBackColor = true;
            this.BDelete_Package.Click += new System.EventHandler(this.BDelete_Package_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(172, 78);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 9;
            this.bSave.Text = "Zapisz";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bLoad
            // 
            this.bLoad.Location = new System.Drawing.Point(172, 108);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(75, 23);
            this.bLoad.TabIndex = 10;
            this.bLoad.Text = "Wczytaj";
            this.bLoad.UseVisualStyleBackColor = true;
            this.bLoad.Click += new System.EventHandler(this.bLoad_Click);
            // 
            // gDefined_Packages
            // 
            this.gDefined_Packages.Controls.Add(this.lPackage_list);
            this.gDefined_Packages.Controls.Add(this.bLoad);
            this.gDefined_Packages.Controls.Add(this.button2);
            this.gDefined_Packages.Controls.Add(this.bSave);
            this.gDefined_Packages.Controls.Add(this.Height_numeric_updown);
            this.gDefined_Packages.Controls.Add(this.BDelete_Package);
            this.gDefined_Packages.Controls.Add(this.LHeight);
            this.gDefined_Packages.Controls.Add(this.label1);
            this.gDefined_Packages.Controls.Add(this.Weight_numericUpDown);
            this.gDefined_Packages.Location = new System.Drawing.Point(12, 12);
            this.gDefined_Packages.Name = "gDefined_Packages";
            this.gDefined_Packages.Size = new System.Drawing.Size(420, 252);
            this.gDefined_Packages.TabIndex = 11;
            this.gDefined_Packages.TabStop = false;
            this.gDefined_Packages.Text = "Definiowanie paczek";
            // 
            // lContainer_packages
            // 
            this.lContainer_packages.FormattingEnabled = true;
            this.lContainer_packages.Location = new System.Drawing.Point(562, 31);
            this.lContainer_packages.Name = "lContainer_packages";
            this.lContainer_packages.Size = new System.Drawing.Size(120, 95);
            this.lContainer_packages.TabIndex = 12;
            // 
            // bContainerAdd
            // 
            this.bContainerAdd.Location = new System.Drawing.Point(438, 31);
            this.bContainerAdd.Name = "bContainerAdd";
            this.bContainerAdd.Size = new System.Drawing.Size(118, 23);
            this.bContainerAdd.TabIndex = 13;
            this.bContainerAdd.Text = "Dodaj do kontenera";
            this.bContainerAdd.UseVisualStyleBackColor = true;
            this.bContainerAdd.Click += new System.EventHandler(this.bContainerAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 513);
            this.Controls.Add(this.bContainerAdd);
            this.Controls.Add(this.lContainer_packages);
            this.Controls.Add(this.gDefined_Packages);
            this.Controls.Add(this.bRysuj);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Package master";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Height_numeric_updown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight_numericUpDown)).EndInit();
            this.gDefined_Packages.ResumeLayout(false);
            this.gDefined_Packages.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bRysuj;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown Height_numeric_updown;
        private System.Windows.Forms.Label LHeight;
        private System.Windows.Forms.NumericUpDown Weight_numericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BDelete_Package;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bLoad;
        private System.Windows.Forms.GroupBox gDefined_Packages;
        private System.Windows.Forms.Button bContainerAdd;
        public System.Windows.Forms.ListBox lContainer_packages;
        internal System.Windows.Forms.ListBox lPackage_list;
    }
}


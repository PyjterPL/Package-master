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
            this.button2 = new System.Windows.Forms.Button();
            this.lPackage_list = new System.Windows.Forms.ListBox();
            this.Height_numeric_updown = new System.Windows.Forms.NumericUpDown();
            this.LHeight = new System.Windows.Forms.Label();
            this.Width_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.BDelete_Package = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bLoad = new System.Windows.Forms.Button();
            this.gDefined_Packages = new System.Windows.Forms.GroupBox();
            this.lContainer_packages = new System.Windows.Forms.ListBox();
            this.bContainerAdd = new System.Windows.Forms.Button();
            this.bDelete__from_Container = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lContainer_size = new System.Windows.Forms.Label();
            this.bContainer_size_change = new System.Windows.Forms.Button();
            this.bArrange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Height_numeric_updown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Width_numericUpDown)).BeginInit();
            this.gDefined_Packages.SuspendLayout();
            this.SuspendLayout();
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
            this.Height_numeric_updown.DecimalPlaces = 2;
            this.Height_numeric_updown.Location = new System.Drawing.Point(127, 178);
            this.Height_numeric_updown.Name = "Height_numeric_updown";
            this.Height_numeric_updown.Size = new System.Drawing.Size(120, 20);
            this.Height_numeric_updown.TabIndex = 4;
            this.Height_numeric_updown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // LHeight
            // 
            this.LHeight.AutoSize = true;
            this.LHeight.Location = new System.Drawing.Point(41, 185);
            this.LHeight.Name = "LHeight";
            this.LHeight.Size = new System.Drawing.Size(80, 13);
            this.LHeight.TabIndex = 5;
            this.LHeight.Text = "Wysokość [cm]";
            this.LHeight.Click += new System.EventHandler(this.LHeight_Click);
            // 
            // Width_numericUpDown
            // 
            this.Width_numericUpDown.AccessibleDescription = "Dlugosc_numeris";
            this.Width_numericUpDown.DecimalPlaces = 2;
            this.Width_numericUpDown.Location = new System.Drawing.Point(127, 204);
            this.Width_numericUpDown.Name = "Width_numericUpDown";
            this.Width_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.Width_numericUpDown.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Szerokość [cm]";
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
            this.gDefined_Packages.Controls.Add(this.Width_numericUpDown);
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
            this.lContainer_packages.SelectedIndexChanged += new System.EventHandler(this.lContainer_packages_SelectedIndexChanged);
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
            // bDelete__from_Container
            // 
            this.bDelete__from_Container.Location = new System.Drawing.Point(481, 60);
            this.bDelete__from_Container.Name = "bDelete__from_Container";
            this.bDelete__from_Container.Size = new System.Drawing.Size(75, 23);
            this.bDelete__from_Container.TabIndex = 14;
            this.bDelete__from_Container.Text = "Usuń";
            this.bDelete__from_Container.UseVisualStyleBackColor = true;
            this.bDelete__from_Container.Click += new System.EventHandler(this.bDelete__from_Container_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Aktualny rozmiar kontenera [cm]";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lContainer_size
            // 
            this.lContainer_size.AutoSize = true;
            this.lContainer_size.Location = new System.Drawing.Point(593, 145);
            this.lContainer_size.Name = "lContainer_size";
            this.lContainer_size.Size = new System.Drawing.Size(0, 13);
            this.lContainer_size.TabIndex = 16;
            // 
            // bContainer_size_change
            // 
            this.bContainer_size_change.Location = new System.Drawing.Point(438, 170);
            this.bContainer_size_change.Name = "bContainer_size_change";
            this.bContainer_size_change.Size = new System.Drawing.Size(155, 23);
            this.bContainer_size_change.TabIndex = 17;
            this.bContainer_size_change.Text = "Zmień rozmiary kontenera";
            this.bContainer_size_change.UseVisualStyleBackColor = true;
            this.bContainer_size_change.Click += new System.EventHandler(this.bContainer_size_change_Click);
            // 
            // bArrange
            // 
            this.bArrange.Location = new System.Drawing.Point(543, 233);
            this.bArrange.Name = "bArrange";
            this.bArrange.Size = new System.Drawing.Size(75, 23);
            this.bArrange.TabIndex = 18;
            this.bArrange.Text = "Rozmieść";
            this.bArrange.UseVisualStyleBackColor = true;
            this.bArrange.Click += new System.EventHandler(this.bArrange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 285);
            this.Controls.Add(this.bArrange);
            this.Controls.Add(this.bContainer_size_change);
            this.Controls.Add(this.lContainer_size);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bDelete__from_Container);
            this.Controls.Add(this.bContainerAdd);
            this.Controls.Add(this.lContainer_packages);
            this.Controls.Add(this.gDefined_Packages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Package master";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Height_numeric_updown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Width_numericUpDown)).EndInit();
            this.gDefined_Packages.ResumeLayout(false);
            this.gDefined_Packages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown Height_numeric_updown;
        private System.Windows.Forms.Label LHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BDelete_Package;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bLoad;
        private System.Windows.Forms.GroupBox gDefined_Packages;
        private System.Windows.Forms.Button bContainerAdd;
        public System.Windows.Forms.ListBox lContainer_packages;
        internal System.Windows.Forms.ListBox lPackage_list;
        private System.Windows.Forms.Button bDelete__from_Container;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bContainer_size_change;
        private System.Windows.Forms.NumericUpDown Width_numericUpDown;
        internal System.Windows.Forms.Label lContainer_size;
        private System.Windows.Forms.Button bArrange;
    }
}


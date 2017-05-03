namespace Package_master
{
    partial class Add_Package_to_Container_Form
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
            this.Packages_to_container_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.bAdd_to_Container = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Packages_to_container_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Packages_to_container_numericUpDown
            // 
            this.Packages_to_container_numericUpDown.Location = new System.Drawing.Point(12, 12);
            this.Packages_to_container_numericUpDown.Name = "Packages_to_container_numericUpDown";
            this.Packages_to_container_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.Packages_to_container_numericUpDown.TabIndex = 0;
            this.Packages_to_container_numericUpDown.ValueChanged += new System.EventHandler(this.Packages_to_container_numericUpDown_ValueChanged);
            // 
            // bAdd_to_Container
            // 
            this.bAdd_to_Container.Location = new System.Drawing.Point(12, 39);
            this.bAdd_to_Container.Name = "bAdd_to_Container";
            this.bAdd_to_Container.Size = new System.Drawing.Size(75, 23);
            this.bAdd_to_Container.TabIndex = 1;
            this.bAdd_to_Container.Text = "Dodaj";
            this.bAdd_to_Container.UseVisualStyleBackColor = true;
            this.bAdd_to_Container.Click += new System.EventHandler(this.bAdd_to_Container_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(94, 39);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 2;
            this.bCancel.Text = "Anuluj";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // Add_Package_to_Container_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 81);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bAdd_to_Container);
            this.Controls.Add(this.Packages_to_container_numericUpDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_Package_to_Container_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj do kontenera";
            this.Load += new System.EventHandler(this.Add_Package_to_Container_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Packages_to_container_numericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Packages_to_container_numericUpDown;
        private System.Windows.Forms.Button bAdd_to_Container;
        private System.Windows.Forms.Button bCancel;
    }
}
namespace Package_master
{
    partial class Package_Input_Dialog
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
            this.BAdd_Package = new System.Windows.Forms.Button();
            this.B_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BAdd_Package
            // 
            this.BAdd_Package.Location = new System.Drawing.Point(13, 226);
            this.BAdd_Package.Name = "BAdd_Package";
            this.BAdd_Package.Size = new System.Drawing.Size(75, 23);
            this.BAdd_Package.TabIndex = 0;
            this.BAdd_Package.Text = "Dodaj";
            this.BAdd_Package.UseVisualStyleBackColor = true;
            this.BAdd_Package.Click += new System.EventHandler(this.BAdd_Package_Click);
            // 
            // B_Cancel
            // 
            this.B_Cancel.Location = new System.Drawing.Point(153, 226);
            this.B_Cancel.Name = "B_Cancel";
            this.B_Cancel.Size = new System.Drawing.Size(75, 23);
            this.B_Cancel.TabIndex = 1;
            this.B_Cancel.Text = "Anuluj";
            this.B_Cancel.UseVisualStyleBackColor = true;
            this.B_Cancel.Click += new System.EventHandler(this.B_Cancel_Click);
            // 
            // Package_Input_Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.B_Cancel);
            this.Controls.Add(this.BAdd_Package);
            this.Name = "Package_Input_Dialog";
            this.Text = "Package_Input_Dialog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BAdd_Package;
        private System.Windows.Forms.Button B_Cancel;
    }
}
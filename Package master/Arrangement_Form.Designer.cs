namespace Package_master
{
    partial class Arrangement_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lPackages_in_container_list = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lPackages_in_container_list
            // 
            this.lPackages_in_container_list.FormattingEnabled = true;
            this.lPackages_in_container_list.Location = new System.Drawing.Point(206, 0);
            this.lPackages_in_container_list.Name = "lPackages_in_container_list";
            this.lPackages_in_container_list.Size = new System.Drawing.Size(120, 95);
            this.lPackages_in_container_list.TabIndex = 2;
            // 
            // Arrangement_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 445);
            this.Controls.Add(this.lPackages_in_container_list);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Arrangement_Form";
            this.Text = "Kontener";
            this.Load += new System.EventHandler(this.Arrangement_Form_Load);
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Arrangement_Form_Scroll);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Arrangement_Form_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.ListBox lPackages_in_container_list;
    }
}
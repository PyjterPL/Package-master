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
            this.pDrawningPanel = new System.Windows.Forms.Panel();
            this.lPackages_in_container_list = new System.Windows.Forms.ListBox();
            this.l_all_packages = new System.Windows.Forms.Label();
            this.l_outside_packages = new System.Windows.Forms.Label();
            this.lUnpacked_packages_list = new System.Windows.Forms.ListBox();
            this.bDeploy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pDrawningPanel
            // 
            this.pDrawningPanel.Location = new System.Drawing.Point(0, 0);
            this.pDrawningPanel.Name = "pDrawningPanel";
            this.pDrawningPanel.Size = new System.Drawing.Size(200, 100);
            this.pDrawningPanel.TabIndex = 1;
            this.pDrawningPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.pDraw);
            // 
            // lPackages_in_container_list
            // 
            this.lPackages_in_container_list.FormattingEnabled = true;
            this.lPackages_in_container_list.Location = new System.Drawing.Point(206, 60);
            this.lPackages_in_container_list.Name = "lPackages_in_container_list";
            this.lPackages_in_container_list.Size = new System.Drawing.Size(120, 95);
            this.lPackages_in_container_list.TabIndex = 2;
            // 
            // l_all_packages
            // 
            this.l_all_packages.AutoSize = true;
            this.l_all_packages.Location = new System.Drawing.Point(206, 44);
            this.l_all_packages.Name = "l_all_packages";
            this.l_all_packages.Size = new System.Drawing.Size(89, 13);
            this.l_all_packages.TabIndex = 3;
            this.l_all_packages.Text = "Wszystkie paczki";
            // 
            // l_outside_packages
            // 
            this.l_outside_packages.AutoSize = true;
            this.l_outside_packages.Location = new System.Drawing.Point(201, 165);
            this.l_outside_packages.Name = "l_outside_packages";
            this.l_outside_packages.Size = new System.Drawing.Size(124, 13);
            this.l_outside_packages.TabIndex = 4;
            this.l_outside_packages.Text = "Paczki poza kontenerem";
            // 
            // lUnpacked_packages_list
            // 
            this.lUnpacked_packages_list.FormattingEnabled = true;
            this.lUnpacked_packages_list.Location = new System.Drawing.Point(205, 181);
            this.lUnpacked_packages_list.Name = "lUnpacked_packages_list";
            this.lUnpacked_packages_list.Size = new System.Drawing.Size(120, 95);
            this.lUnpacked_packages_list.TabIndex = 5;
            // 
            // bDeploy
            // 
            this.bDeploy.Location = new System.Drawing.Point(205, 13);
            this.bDeploy.Name = "bDeploy";
            this.bDeploy.Size = new System.Drawing.Size(75, 23);
            this.bDeploy.TabIndex = 6;
            this.bDeploy.Text = "Rozmieść";
            this.bDeploy.UseVisualStyleBackColor = true;
            this.bDeploy.Click += new System.EventHandler(this.bDeploy_Click);
            // 
            // Arrangement_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 445);
            this.Controls.Add(this.bDeploy);
            this.Controls.Add(this.lUnpacked_packages_list);
            this.Controls.Add(this.l_outside_packages);
            this.Controls.Add(this.l_all_packages);
            this.Controls.Add(this.lPackages_in_container_list);
            this.Controls.Add(this.pDrawningPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Arrangement_Form";
            this.Text = "Kontener";
            this.Load += new System.EventHandler(this.Arrangement_Form_Load);
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Arrangement_Form_Scroll);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Arrangement_Form_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel pDrawningPanel;
        internal System.Windows.Forms.ListBox lPackages_in_container_list;
        internal System.Windows.Forms.Label l_all_packages;
        internal System.Windows.Forms.Label l_outside_packages;
        internal System.Windows.Forms.ListBox lUnpacked_packages_list;
        internal System.Windows.Forms.Button bDeploy;
    }
}
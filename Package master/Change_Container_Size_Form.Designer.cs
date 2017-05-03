namespace Package_master
{
    partial class Change_Container_Size_Form
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
            this.Height_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Width_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.bChange = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Height_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Width_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Height_numericUpDown
            // 
            this.Height_numericUpDown.Location = new System.Drawing.Point(75, 12);
            this.Height_numericUpDown.Name = "Height_numericUpDown";
            this.Height_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.Height_numericUpDown.TabIndex = 0;
            // 
            // Width_numericUpDown
            // 
            this.Width_numericUpDown.Location = new System.Drawing.Point(75, 38);
            this.Width_numericUpDown.Name = "Width_numericUpDown";
            this.Width_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.Width_numericUpDown.TabIndex = 1;
            // 
            // bChange
            // 
            this.bChange.Location = new System.Drawing.Point(9, 64);
            this.bChange.Name = "bChange";
            this.bChange.Size = new System.Drawing.Size(75, 23);
            this.bChange.TabIndex = 2;
            this.bChange.Text = "Zmień";
            this.bChange.UseVisualStyleBackColor = true;
            this.bChange.Click += new System.EventHandler(this.bChange_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(120, 64);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 3;
            this.bCancel.Text = "Anuluj";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wysokość";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Szerokość";
            // 
            // Change_Container_Size_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 110);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bChange);
            this.Controls.Add(this.Width_numericUpDown);
            this.Controls.Add(this.Height_numericUpDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Change_Container_Size_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zmiana rozmiaru";
            this.Load += new System.EventHandler(this.Change_Container_Size_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Height_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Width_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Height_numericUpDown;
        private System.Windows.Forms.NumericUpDown Width_numericUpDown;
        private System.Windows.Forms.Button bChange;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
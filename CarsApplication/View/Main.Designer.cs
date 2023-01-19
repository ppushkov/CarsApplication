namespace CarsApplication
{
    partial class Main
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
            this.btnCarView = new System.Windows.Forms.Button();
            this.lblCars = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCarView
            // 
            this.btnCarView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarView.Location = new System.Drawing.Point(214, 158);
            this.btnCarView.Name = "btnCarView";
            this.btnCarView.Size = new System.Drawing.Size(142, 80);
            this.btnCarView.TabIndex = 0;
            this.btnCarView.Text = "CarView";
            this.btnCarView.UseVisualStyleBackColor = true;
            this.btnCarView.Click += new System.EventHandler(this.btnCarView_Click);
            // 
            // lblCars
            // 
            this.lblCars.AutoSize = true;
            this.lblCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCars.Location = new System.Drawing.Point(179, 28);
            this.lblCars.Name = "lblCars";
            this.lblCars.Size = new System.Drawing.Size(220, 33);
            this.lblCars.TabIndex = 1;
            this.lblCars.Text = "CarsApplication";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 284);
            this.Controls.Add(this.lblCars);
            this.Controls.Add(this.btnCarView);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCarView;
        private System.Windows.Forms.Label lblCars;
    }
}


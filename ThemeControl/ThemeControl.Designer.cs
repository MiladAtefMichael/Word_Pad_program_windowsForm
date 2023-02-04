namespace ThemeControl
{
    partial class ThemeControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbred = new System.Windows.Forms.TrackBar();
            this.tbblue = new System.Windows.Forms.TrackBar();
            this.tbgreen = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbred)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbblue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbgreen)).BeginInit();
            this.SuspendLayout();
            // 
            // tbred
            // 
            this.tbred.Location = new System.Drawing.Point(28, 38);
            this.tbred.Name = "tbred";
            this.tbred.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbred.Size = new System.Drawing.Size(56, 301);
            this.tbred.TabIndex = 0;
            // 
            // tbblue
            // 
            this.tbblue.Location = new System.Drawing.Point(211, 38);
            this.tbblue.Name = "tbblue";
            this.tbblue.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbblue.Size = new System.Drawing.Size(56, 301);
            this.tbblue.TabIndex = 1;
            // 
            // tbgreen
            // 
            this.tbgreen.Location = new System.Drawing.Point(109, 38);
            this.tbgreen.Name = "tbgreen";
            this.tbgreen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbgreen.Size = new System.Drawing.Size(56, 301);
            this.tbgreen.TabIndex = 2;
            this.tbgreen.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Red";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Green";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(206, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Blue";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbgreen);
            this.Controls.Add(this.tbblue);
            this.Controls.Add(this.tbred);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(275, 383);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbred)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbblue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbgreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbred;
        private System.Windows.Forms.TrackBar tbblue;
        private System.Windows.Forms.TrackBar tbgreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

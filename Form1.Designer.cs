namespace Berechnung
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxZ = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.trackBarZ = new System.Windows.Forms.TrackBar();
            this.trackBarY = new System.Windows.Forms.TrackBar();
            this.trackBarX = new System.Windows.Forms.TrackBar();
            this.labelY = new System.Windows.Forms.Label();
            this.labelZ = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxS3 = new System.Windows.Forms.TextBox();
            this.textBoxS2 = new System.Windows.Forms.TextBox();
            this.textBoxS1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxZ);
            this.groupBox1.Controls.Add(this.textBoxY);
            this.groupBox1.Controls.Add(this.textBoxX);
            this.groupBox1.Controls.Add(this.trackBarZ);
            this.groupBox1.Controls.Add(this.trackBarY);
            this.groupBox1.Controls.Add(this.trackBarX);
            this.groupBox1.Controls.Add(this.labelY);
            this.groupBox1.Controls.Add(this.labelZ);
            this.groupBox1.Controls.Add(this.labelX);
            this.groupBox1.Location = new System.Drawing.Point(17, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Koordinaten";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxZ
            // 
            this.textBoxZ.Location = new System.Drawing.Point(32, 67);
            this.textBoxZ.Name = "textBoxZ";
            this.textBoxZ.Size = new System.Drawing.Size(40, 20);
            this.textBoxZ.TabIndex = 10;
            this.textBoxZ.Text = "200";
            this.textBoxZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxZ.TextChanged += new System.EventHandler(this.textBoxZ_TextChanged);
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(32, 42);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(40, 20);
            this.textBoxY.TabIndex = 9;
            this.textBoxY.Text = "0";
            this.textBoxY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxY.TextChanged += new System.EventHandler(this.textBoxY_TextChanged);
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(31, 16);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(40, 20);
            this.textBoxX.TabIndex = 8;
            this.textBoxX.Text = "0";
            this.textBoxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxX.TextChanged += new System.EventHandler(this.textBoxX_TextChanged);
            // 
            // trackBarZ
            // 
            this.trackBarZ.CausesValidation = false;
            this.trackBarZ.Location = new System.Drawing.Point(79, 67);
            this.trackBarZ.Maximum = 500;
            this.trackBarZ.Minimum = 200;
            this.trackBarZ.Name = "trackBarZ";
            this.trackBarZ.Size = new System.Drawing.Size(100, 45);
            this.trackBarZ.TabIndex = 7;
            this.trackBarZ.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarZ.Value = 200;
            this.trackBarZ.ValueChanged += new System.EventHandler(this.trackBarZ_ValueChanged);
            // 
            // trackBarY
            // 
            this.trackBarY.CausesValidation = false;
            this.trackBarY.Location = new System.Drawing.Point(79, 42);
            this.trackBarY.Maximum = 300;
            this.trackBarY.Minimum = -300;
            this.trackBarY.Name = "trackBarY";
            this.trackBarY.Size = new System.Drawing.Size(100, 45);
            this.trackBarY.TabIndex = 6;
            this.trackBarY.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarY.ValueChanged += new System.EventHandler(this.trackBarY_ValueChanged);
            // 
            // trackBarX
            // 
            this.trackBarX.CausesValidation = false;
            this.trackBarX.LargeChange = 1;
            this.trackBarX.Location = new System.Drawing.Point(79, 16);
            this.trackBarX.Maximum = 300;
            this.trackBarX.Minimum = -300;
            this.trackBarX.Name = "trackBarX";
            this.trackBarX.Size = new System.Drawing.Size(100, 45);
            this.trackBarX.TabIndex = 1;
            this.trackBarX.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarX.Scroll += new System.EventHandler(this.trackBarX_Scroll);
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(7, 48);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(20, 13);
            this.labelY.TabIndex = 5;
            this.labelY.Text = "Y: ";
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.Location = new System.Drawing.Point(7, 70);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(20, 13);
            this.labelZ.TabIndex = 4;
            this.labelZ.Text = "Z: ";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(6, 22);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(20, 13);
            this.labelX.TabIndex = 3;
            this.labelX.Text = "X: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxS1);
            this.groupBox2.Controls.Add(this.textBoxS2);
            this.groupBox2.Controls.Add(this.textBoxS3);
            this.groupBox2.Location = new System.Drawing.Point(265, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(95, 121);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Winkel";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textBoxS3
            // 
            this.textBoxS3.Location = new System.Drawing.Point(35, 67);
            this.textBoxS3.Name = "textBoxS3";
            this.textBoxS3.Size = new System.Drawing.Size(40, 20);
            this.textBoxS3.TabIndex = 9;
            this.textBoxS3.Text = "0";
            this.textBoxS3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxS2
            // 
            this.textBoxS2.Location = new System.Drawing.Point(35, 41);
            this.textBoxS2.Name = "textBoxS2";
            this.textBoxS2.Size = new System.Drawing.Size(40, 20);
            this.textBoxS2.TabIndex = 10;
            this.textBoxS2.Text = "0";
            this.textBoxS2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxS1
            // 
            this.textBoxS1.Location = new System.Drawing.Point(35, 15);
            this.textBoxS1.Name = "textBoxS1";
            this.textBoxS1.Size = new System.Drawing.Size(40, 20);
            this.textBoxS1.TabIndex = 11;
            this.textBoxS1.Text = "0";
            this.textBoxS1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "S1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "S2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "S3:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(639, 335);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Berechnung";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trackBarZ;
        private System.Windows.Forms.TrackBar trackBarY;
        private System.Windows.Forms.TrackBar trackBarX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox textBoxZ;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxS1;
        private System.Windows.Forms.TextBox textBoxS2;
        private System.Windows.Forms.TextBox textBoxS3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}


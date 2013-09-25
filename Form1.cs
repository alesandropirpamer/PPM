using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Berechnung
{
    public partial class Form1 : Form
    {
        Berechnung br = new Berechnung();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void switchState() 
        { 

        }

        private void textBoxX_TextChanged(object sender, EventArgs e)
        {
            try
            {
                trackBarX.Value = Convert.ToInt32(textBoxX.Text);
            }
            catch { }
        }
        private void textBoxY_TextChanged(object sender, EventArgs e)
        {
            try
            {
                trackBarY.Value = Convert.ToInt32(textBoxY.Text);
            }
            catch { }
        }

        private void textBoxZ_TextChanged(object sender, EventArgs e)
        {
            try
            {
                trackBarZ.Value = Convert.ToInt32(textBoxZ.Text);
            }
            catch { }
        }
        private void trackBarX_Scroll(object sender, EventArgs e)
        {
            textBoxX.Text = Convert.ToString(trackBarX.Value);
            berechnen();
        }

        private void trackBarY_ValueChanged(object sender, EventArgs e)
        {
            textBoxY.Text = Convert.ToString(trackBarY.Value);
            berechnen();
        }

        private void trackBarZ_ValueChanged(object sender, EventArgs e)
        {
            textBoxZ.Text = Convert.ToString(trackBarZ.Value);
            berechnen();
        }
        private void berechnen() {
            textBoxS1.Text = Convert.ToString(br.S1(trackBarX.Value, trackBarY.Value, trackBarZ.Value));
            textBoxS2.Text = Convert.ToString(br.S2(trackBarX.Value, trackBarY.Value, trackBarZ.Value));
            textBoxS3.Text = Convert.ToString(br.S3(trackBarX.Value, trackBarY.Value, trackBarZ.Value));
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

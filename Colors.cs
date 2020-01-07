using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabDrawRudnev
{
    public partial class Colors : Form
    {
        public static  Color colorResult;
        Color color;
        public Colors()
        {

            InitializeComponent();
            ScrollRed.Tag = numericRed;
            ScrollGreen.Tag = numericGreen;
            ScrollBlue.Tag = numericBlue;
            numericRed.Tag = ScrollRed;
            numericGreen.Tag = ScrollGreen;
            numericBlue.Tag = ScrollBlue;
            numericRed.Value = color.R;
            numericGreen.Value = color.G;
            numericBlue.Value = color.B;

        }

        private void Colors_Load(object sender, EventArgs e)
        {
        }

        private void ScrollRed_ValueChanged(object sender, EventArgs e)
        {
            ScrollBar scrollBar = (ScrollBar)sender;
            NumericUpDown numericUpDown = (NumericUpDown)scrollBar.Tag;
            numericUpDown.Value = scrollBar.Value;
            UpdateColor();
        }
        private void ScrollGreen_ValueChanged(object sender, EventArgs e)
        {
            ScrollBar scrollBar = (ScrollBar)sender;
            NumericUpDown numericUpDown = (NumericUpDown)scrollBar.Tag;
            numericUpDown.Value = scrollBar.Value;
            UpdateColor();
        }
        private void ScrollBlue_Scroll(object sender, EventArgs e)
        {
            ScrollBar scrollBar = (ScrollBar)sender;
            NumericUpDown numericUpDown = (NumericUpDown)scrollBar.Tag;
            numericUpDown.Value = scrollBar.Value;
            UpdateColor();
        }
        private void NumericRed_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)numericUpDown.Tag;
            numericUpDown.Value = (int)scrollBar.Value;
            UpdateColor();
        }

        private void NumericGreen_ValueChanged(object sender, EventArgs e)
        {
           

            NumericUpDown numericUpDown = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)numericUpDown.Tag;
            numericUpDown.Value = (int)scrollBar.Value;
            UpdateColor();
        }

        private void NumericBlue_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)numericUpDown.Tag;
            numericUpDown.Value = (int)scrollBar.Value;
            UpdateColor();
        }
        private void UpdateColor()
        {
            colorResult = Color.FromArgb(ScrollRed.Value,  ScrollGreen.Value, ScrollBlue.Value);
            pictureBox1.BackColor = colorResult;
 
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog()==DialogResult.OK)
            {
                ScrollRed.Value = colorDialog.Color.R;
                ScrollGreen.Value = colorDialog.Color.G;
                ScrollBlue.Value = colorDialog.Color.B;
                colorResult = colorDialog.Color;
                UpdateColor();

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form1.currentpen.Color = colorResult;
            this.Close(); 
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ScrollRed_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}

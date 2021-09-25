using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_work
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Please select a image file!!!!";
                ofd.Multiselect = false;

                string imgage_file = "";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imgage_file = ofd.FileName;
                }


                Image images = Image.FromFile(imgage_file);
                pictureBox1.Image = images;



                Bitmap cover_image = new Bitmap(imgage_file);


                for (int y = 0; y < 1; y++)
                {
                    for (int x = 0; x < cover_image.Width; x++)
                    {

                        cover_image.SetPixel(x, y, Color.Black);
                    }
                }

                cover_image.Save(@"C:\Users\User\Desktop\Stego_finaloutput.png");

                MessageBox.Show("Complete!!");

            }



           
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

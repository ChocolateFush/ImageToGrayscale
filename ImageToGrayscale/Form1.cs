using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageToGrayscale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap image_import;

        private void open_button_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open_dlg = new OpenFileDialog())
            {
                open_dlg.Title = "Open Image";
                open_dlg.Filter = "bmp files(*.bmp)|*.bmp";

                if (open_dlg.ShowDialog() == DialogResult.OK)
                {
                    image_import = new Bitmap(open_dlg.FileName);
                    picture_box.Image = image_import;
                }
            }
            
        }

        private void grayscale_button_Click(object sender, EventArgs e)
        {
            Bitmap d = new Bitmap(image_import.Width, image_import.Height);

            for (int i = 0; i < image_import.Width; i++) {
                for (int j = 0; j < image_import.Height; j++) {

                    Color oc = image_import.GetPixel(i, j);
                    int grayscale = (int)((oc.R * 0.3) + (oc.G * 0.59) + (oc.B * 0.11));
                    Color nc = Color.FromArgb(oc.A, grayscale, grayscale, grayscale);
                    d.SetPixel(i, j, nc);
                }

            }

            image_import = d;
            picture_box.Image = image_import;
            
        }

        private void g_blur_button_Click(object sender, EventArgs e)
        {
            int[,] kernel = new int[3, 3] { {1,2,1}, {2,4,2}, {1,2,1} };

            Bitmap r = new Bitmap(image_import.Width, image_import.Height);
            int sum = 0;
            int current_value = 0;


            for (int i = 2; i < image_import.Width - 2; i++) {
                for (int j = 2; j < image_import.Height - 2; j++) {
                    for (int k = 0; k < 3; k++) {
                        for (int l = 0; l < 3; l++) {
                            current_value = image_import.GetPixel(i + k, j + l).R;
                            sum += current_value * kernel[k,l];
                        }
                    }
                    sum = sum / 16;
                    r.SetPixel(i+1, j+1, Color.FromArgb(sum,sum,sum));
                    sum = 0;
                }
            }
            image_import = r;
            picture_box.Image = image_import;
        }

        private void edge_detect_Click(object sender, EventArgs e)
        {
            int[,] hori_kernel = new int[3, 3] { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
            int[,] verti_kernel = new int[3, 3] { { -1, -2, -1 }, { 0, 0, 0 }, { 1, 2, 1 } };
            Bitmap r = new Bitmap(image_import.Width, image_import.Height);
            Bitmap s = new Bitmap(image_import.Width, image_import.Height);
            int current_value = 0;
            int sum_product_h = 0;
            int sum_product_v = 0;
            int sum_total = 0;

            for (int i = 2; i < image_import.Width - 2; i++)
            {
                for (int j = 2; j < image_import.Height - 2; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        for (int l = 0; l < 3; l++)
                        {
                            current_value = image_import.GetPixel(i + k, j + l).R;
                            sum_product_h += current_value * hori_kernel[k, l];
                            sum_product_v += current_value * verti_kernel[k, l];
                        }
                    }
                    sum_total = (int)Math.Sqrt(Math.Pow(sum_product_h, 2) + Math.Pow(sum_product_v, 2))/(16 + (10-sensitivity.Value));
                    r.SetPixel(i, j, Color.FromArgb(sum_total, sum_total, sum_total));
                    sum_product_h = 0;
                    sum_product_v = 0;
                }
            }

            image_import = r;
            picture_box.Image = image_import;

            for (int i = 0; i < image_import.Width; i++) {
                for (int j = 0; j < image_import.Height; j++) {
                    if (image_import.GetPixel(i, j).R > 5)
                    {
                        r.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                    }
                    else {
                        r.SetPixel(i, j, Color.FromArgb(0, 0, 0));
                    }

                }
            }

            image_import = r;
            picture_box.Image = image_import;

        }
    }
}

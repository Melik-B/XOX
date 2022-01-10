using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbOyuncu1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btOyna_Click(object sender, EventArgs e)
        {
            OyunForm form = new OyunForm();
            bool aynıKarakterHata = false;

            #region Kullanıcı adı hataları
            if (string.IsNullOrWhiteSpace(tbOyuncu1.Text))
            {
                lbBosHata.Visible = true;
                lb12Hata.Visible = false;
                lb3Hata.Visible = false;
                lbAyniHata.Visible = false;
            }

            if (string.IsNullOrWhiteSpace(tbOyuncu2.Text))
            {
                lbBosHata2.Visible = true;
                lb12Hata2.Visible = false;
                lb3Hata2.Visible = false;
                lbAyniHata.Visible = false;
            }

            if(tbOyuncu1.TextLength > 12)
            {
                lb12Hata.Location = new Point(586, 321);
                lb12Hata.Visible = true;
                lbBosHata.Visible = false;
                lb3Hata.Visible = false;
                lbAyniHata.Visible = false;
            }

            if (tbOyuncu2.TextLength > 12)
            {
                lb12Hata2.Location = new Point(582, 444);
                lb12Hata2.Visible = true;
                lbBosHata2.Visible = false;
                lb3Hata2.Visible = false;
                lbAyniHata.Visible = false;
            }

            if (tbOyuncu1.TextLength < 3 && tbOyuncu1.TextLength > 0)
            {
                lb3Hata.Location = new Point(582, 321);
                lb3Hata.Visible = true;
                lb12Hata.Visible = false;
                lbBosHata.Visible = false;
                lbAyniHata.Visible = false;
            }

            if (tbOyuncu2.TextLength < 3 && tbOyuncu2.TextLength > 0)
            {
                lb3Hata2.Location = new Point(582, 440);
                lb3Hata2.Visible = true;
                lb12Hata2.Visible = false;
                lbBosHata2.Visible = false;
                lbAyniHata.Visible = false;
            }
            #endregion

            if (lbOyuncu1oTik.Visible == true && lbOyuncu2OTik.Visible == true || lbOyuncu1XTik.Visible == true && lbOyuncu2XTik.Visible == true)
            {
                aynıKarakterHata = true;
                lbAyniHata.Location = new Point(582, 321);
                lbAyniHata.Visible = true;
                lbBosHata.Visible = false;
                lb3Hata.Visible = false;
                lb12Hata.Visible = false;
            }

            if (tbOyuncu1.TextLength >= 3 && tbOyuncu1.TextLength <12 && tbOyuncu2.TextLength >= 3 && tbOyuncu2.TextLength < 12 && aynıKarakterHata == false)
            {
                form = new OyunForm();
                form.MdiParent = this;
                form.WindowState = FormWindowState.Maximized;
                form.Show();
                groupBox1.Visible = false;
                form.lbOyuncuAd.Text = tbOyuncu1.Text;
                form.lbOyuncuAd2.Text = tbOyuncu2.Text;
            }

            #region Çalışmadı
            //if (lbOyuncu1oTik.Visible == true)
            //{
            //    form.lbO.Location = new Point(127, 2);
            //    form.lbO.Visible = true;
            //}

            //if (lbOyuncu1XTik.Visible == true)
            //{
            //    form.lbX.Location = new Point(127, 2);
            //    form.lbX.Visible = true;
            //}

            //if (lbOyuncu2OTik.Visible == true)
            //{
            //    form.lbO.Location = new Point(1042, 2);
            //    form.lbO.Visible = true;
            //}

            //if (lbOyuncu2XTik.Visible == true)
            //{
            //    form.lbX.Location = new Point(1042, 2);
            //    form.lbX.Visible = true;
            //}
            #endregion
        }


        private void Oyuncu1O_Click(object sender, EventArgs e)
        {
            lbOyuncu1oTik.Visible = true;
            lbOyuncu1XTik.Visible = false;
        }

        private void Oyuncu1X_Click(object sender, EventArgs e)
        {
            lbOyuncu1XTik.Visible = true;
            lbOyuncu1oTik.Visible = false;
        }

        private void Oyuncu2X_Click(object sender, EventArgs e)
        {
            lbOyuncu2XTik.Visible = true;
            lbOyuncu2OTik.Visible = false;
        }

        private void Oyuncu2o_Click(object sender, EventArgs e)
        {
            lbOyuncu2OTik.Visible = true;
            lbOyuncu2XTik.Visible = false;
        }
    }
}
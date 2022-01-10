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
    public partial class OyunForm : Form
    {
        Form1 form = new Form1();
        string oyuncu = "X";

        public OyunForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            form = new Form1();
            int skor = 0;

            #region İnternetten baktım
            Label label = (Label)sender;

            label.Text = oyuncu;
            label.Enabled = false;

            if (oyuncu == "X")
            {
                oyuncu = "O";
            }
            else
            {
                oyuncu = "X";
            }
            #endregion

            if (label3.Text == "X" && label4.Text == "X" && label5.Text == "X" || label6.Text == "X" && label7.Text == "X" && label8.Text == "X" ||
               label9.Text == "X" && label10.Text == "X" && label11.Text == "X" || label3.Text == "X" && label6.Text == "X" && label9.Text == "X" ||
               label4.Text == "X" && label7.Text == "X" && label10.Text == "X" || label5.Text == "X" && label8.Text == "X" && label11.Text == "X" ||
               label3.Text == "X" && label7.Text == "X" && label11.Text == "X" || label5.Text == "X" && label7.Text == "X" && label9.Text == "X")
            {
                if (form.lbOyuncu2XTik.Visible == true)
                {
                    skor++;
                    Convert.ToString(skor);
                    lbOyuncu2Skor.Text = Convert.ToString(skor);
                }else if (form.lbOyuncu1oTik.Visible == false)
                {
                    skor++;
                    Convert.ToString(skor);
                    lbOyuncu1Skor.Text = Convert.ToString(skor);
                }
                else if (form.lbOyuncu1oTik.Visible == true)
                {
                    skor++;
                    Convert.ToString(skor);
                    lbOyuncu2Skor.Text = Convert.ToString(skor);
                }

                Tekrar();
            }

            if (label3.Text == "O" && label4.Text == "O" && label5.Text == "O" || label6.Text == "O" && label7.Text == "O" && label8.Text == "O" ||
                label9.Text == "O" && label10.Text == "O" && label11.Text == "O" || label3.Text == "O" && label6.Text == "O" && label9.Text == "O" ||
                label4.Text == "O" && label7.Text == "O" && label10.Text == "O" || label5.Text == "O" && label8.Text == "O" && label11.Text == "O" ||
                label3.Text == "O" && label7.Text == "O" && label11.Text == "O" || label5.Text == "O" && label7.Text == "O" && label9.Text == "O")
            {
                if (form.lbOyuncu1oTik.Visible == true)
                {
                    skor++;
                    Convert.ToString(skor);
                    lbOyuncu1Skor.Text = Convert.ToString(skor);
                }
                else if (form.lbOyuncu2XTik.Visible == false)
                {
                    skor++;
                    Convert.ToString(skor);
                    lbOyuncu2Skor.Text = Convert.ToString(skor);
                }
                else if(form.lbOyuncu2XTik.Visible == true)
                {
                    skor++;
                    Convert.ToString(skor);
                    lbOyuncu1Skor.Text = Convert.ToString(skor);
                }

                Tekrar();
            }
        }

        public void Tekrar()
        {
            oyuncu = "X";

            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";

            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            label11.Enabled = true;
        }
    }
}
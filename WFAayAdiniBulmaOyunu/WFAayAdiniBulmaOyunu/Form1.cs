using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAayAdiniBulmaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnayAdiniBul_Click(object sender, EventArgs e)
        {
            try
            {

                int ayAdi = Convert.ToInt32(txtayNo.Text);


                if (ayAdi == 1)

                { lblgoster.Text = "Ocak"; }

                else if(ayAdi == 2)

                { lblgoster.Text = "Şubat"; }

                else if(ayAdi == 3)

                { lblgoster.Text = "Mart"; }

                else if(ayAdi == 4)

                { lblgoster.Text = "Nisan"; }

                else if(ayAdi == 5)

                { lblgoster.Text = "Mayıs"; }

                else if(ayAdi == 6)

                { lblgoster.Text = "Haziran"; }

                else if(ayAdi == 7)

                { lblgoster.Text = "Temmuz"; }

                else if(ayAdi == 8)

                { lblgoster.Text = "Ağustos"; }

                else if(ayAdi == 9)

                { lblgoster.Text = "Eylül"; }

                else if(ayAdi == 10)

                { lblgoster.Text = "Ekim"; }

                else if(ayAdi == 11)

                { lblgoster.Text = "Kasım"; }

                else if(ayAdi == 12)

                { lblgoster.Text = "Aralık"; }

                else { MessageBox.Show("Hata : Lütfen 1 - 12 arası bir değer giriniz. !");}

            }

            catch
            {
                MessageBox.Show("Hata : Lütfen 1-12 arası bir değer giriniz. !");
            }

        }
    }
}

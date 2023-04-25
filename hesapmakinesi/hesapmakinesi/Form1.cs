using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapmakinesi
{
    public partial class hesapmakinesi : Form
    {
        private char _islem;
        private bool _ekrantemizleme;
        private int _ilksayi;
        private int ikincisayi;

        public hesapmakinesi()
        {
            InitializeComponent();
        }

        private void rakam1_button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                labelekran.Text = "";
                _ekrantemizleme = false;
            }
            if (labelekran.Text == "0") labelekran.Text = "";
            labelekran.Text += "1";
        }

        private void rakam2_button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                labelekran.Text = "";
                _ekrantemizleme = false;
            }
            if (labelekran.Text == "0") labelekran.Text = "";
            labelekran.Text += "2";
        }

        private void rakam3_button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                labelekran.Text = "";
                _ekrantemizleme = false;
            }
            if (labelekran.Text == "0") labelekran.Text = "";
            labelekran.Text += "3";
        }

        private void rakam4_button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                labelekran.Text = "";
                _ekrantemizleme = false;
            }
            if (labelekran.Text == "0") labelekran.Text = "";
            labelekran.Text += "4";
        }

        private void rakam5_button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                labelekran.Text = "";
                _ekrantemizleme = false;
            }
            if (labelekran.Text == "0") labelekran.Text = "";
            labelekran.Text += "5";
        }

        private void rakam6_button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                labelekran.Text = "";
                _ekrantemizleme = false;
            }
            if (labelekran.Text == "0") labelekran.Text = "";
            labelekran.Text += "6";
        }

        private void rakam7_button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                labelekran.Text = "";
                _ekrantemizleme = false;
            }
            if (labelekran.Text == "0") labelekran.Text = "";
            labelekran.Text += "7";
        }

        private void rakam8_button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                labelekran.Text = "";
                _ekrantemizleme = false;
            }
            if (labelekran.Text == "0") labelekran.Text = "";
            labelekran.Text += "8";
        }

        private void rakam9_button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                labelekran.Text = "";
                _ekrantemizleme = false;
            }
            if (labelekran.Text == "0") labelekran.Text = "";
            labelekran.Text += "9";
        }

        private void rakam0_button_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                labelekran.Text = "";
                _ekrantemizleme = false;
            }
            if (labelekran.Text == "0") labelekran.Text = "";
            labelekran.Text += "0";
        }
        private void toplama_button_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekrantemizleme = true;
            _ilksayi = Convert.ToInt32(labelekran.Text);
        }

        private void cıkarma_button_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekrantemizleme = true;
            _ilksayi = Convert.ToInt32(labelekran.Text);
        }

        private void carpma_button_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekrantemizleme = true;
            _ilksayi = Convert.ToInt32(labelekran.Text);
        }

        private void bolme_button_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekrantemizleme = true;
            _ilksayi = Convert.ToInt32(labelekran.Text);
        }
        private void sinus_button_Click(object sender, EventArgs e)
        {
            double sin = Convert.ToDouble(labelekran.Text);
            sin = Math.Sin(_ilksayi);
            labelekran.Text = Convert.ToString(sin);
        }

        private void kosinus_button_Click(object sender, EventArgs e)
        {
            double cos = Convert.ToDouble(labelekran.Text);
            cos = Math.Cos(_ilksayi);
            labelekran.Text = Convert.ToString(cos);
        }

        private void kare_button_Click(object sender, EventArgs e)
        {
            double kare = Convert.ToDouble(labelekran.Text);
            kare = Math.Pow(kare, 2);
            labelekran.Text = Convert.ToString(kare);
        }
        private void bolu1_button_Click(object sender, EventArgs e)
        {
            double bolu1 = Convert.ToDouble(labelekran.Text);
            bolu1 = 1 / (bolu1);
            labelekran.Text = Convert.ToString(bolu1);
        }

        private void sil_button_Click(object sender, EventArgs e)
        {
            labelekran.Text = "0";
        }

        private void gecmis_button_Click(object sender, EventArgs e)
        {
            if (gecmis_button.Text == "geçmiş")
            {
                groupbox.Visible = true;
                this.Size = new Size(770, 642);
                gecmis_button.Text = "kapat";
            }
            else
            {
                groupbox.Visible = false;
                this.Size = new Size(503, 642);
                gecmis_button.Text = "geçmiş";
            }

        }
        private void tanjant_button_Click(object sender, EventArgs e)
        {
            double tan = Convert.ToDouble(labelekran.Text);
            tan = Math.Tan(_ilksayi);
            labelekran.Text = Convert.ToString(tan);
        }

        private void kotanjant_button_Click(object sender, EventArgs e)
        {
            double cot = Convert.ToDouble(labelekran.Text);
            cot = 1 / Math.Tan(_ilksayi);
            labelekran.Text = Convert.ToString(cot);
        }
        private void kök_button_Click(object sender, EventArgs e)
        {
            double karekök = Convert.ToDouble(labelekran.Text);
            karekök = Math.Sqrt(karekök);
            labelekran.Text = Convert.ToString(karekök);

        }

           private void esittir_button_Click(object sender, EventArgs e)
        {
            int ikincisayi = Convert.ToInt32(labelekran.Text);
            int sonuc;

            switch (_islem)
            {
                case '+':
                    sonuc = _ilksayi + ikincisayi;
                    break;
                case '-':
                    sonuc = _ilksayi - ikincisayi;
                    break;
                case '*':
                    sonuc = _ilksayi * ikincisayi;
                    break;
                case '/':
                    sonuc = _ilksayi / ikincisayi;  
                    break;
                default:
                    sonuc = 0;
                    break;
            }
            labelekran.Text = Convert.ToString(sonuc);
        }

        private void hesapmakinesi_Load(object sender, EventArgs e)
        {

        }
    }
}


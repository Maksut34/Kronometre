using DLL.data;
using Entity;
using Timer = System.Windows.Forms.Timer;

namespace Kronometre
{
    public partial class Form1 : Form
    {
        int m;
        int h;
        int saniye;
        public Form1()
        {
            InitializeComponent();
        }
        DataContext db=new DataContext();
        private void btn_ba�lat_Click(object sender, EventArgs e)
        {
            
            timer1.Enabled= true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int sanise = Convert.ToInt32(lbl_sanise.Text);

            sanise++;

            lbl_sanise.Text=sanise.ToString();
            if (sanise == 10)
            {
                sanise= 0;
                lbl_sanise.Text = sanise.ToString();
                saniye++;
                lbl_ekran.Text = saniye.ToString();
                if (saniye == 60)
                {
                    saniye = 0;
                    lbl_ekran.Text = saniye.ToString();
                    m++;
                    lbl_M.Text = m.ToString();

                    if (m == 60)
                    {
                        m = 0;
                        lbl_M.Text = m.ToString();
                        h++;
                        lbl_H.Text = h.ToString();
                    }
                }
            }
        }

        private void btn_durdur_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btn_s�f�rla_Click(object sender, EventArgs e)
        {
            S�reler s�r=new S�reler();
            s�r.t�r = comboBox1.Text;
            s�r.sanise=lbl_sanise.Text;
            s�r.saniye=lbl_ekran.Text;
            s�r.dakika=lbl_M.Text;
            s�r.saat=lbl_H.Text;

            db.Set<S�reler>().Add(s�r);
            db.SaveChanges();




            comboBox1.Text = "";
            lbl_sanise.Text = "00";
            lbl_ekran.Text = "00";
            lbl_M.Text = "00";   
            lbl_H.Text = "00";
        }

        
    }
}
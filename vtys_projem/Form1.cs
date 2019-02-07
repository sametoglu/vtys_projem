using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace vtys_projem
{
    public partial class form_giris : Form
    {
        public form_giris()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-C97083V;Initial Catalog=dbproje;Integrated Security=True");

        Form2 arayuz = new Form2();

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.BackColor = System.Drawing.Color.DarkBlue;
            rb_hoca.Checked = true;
            tb_tcno.MaxLength = 11;
            tb_sifre.MaxLength = 16;
            tb_sifre.PasswordChar = '*';
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            baglan.Open();         
            if (rb_hoca.Checked==true)
            {
                SqlDataAdapter data_hoca = new SqlDataAdapter("Select sifre From hoca where tc_no = '" + tb_tcno.Text + "'", baglan);
                DataTable tbl_hoca = new DataTable();
                data_hoca.Fill(tbl_hoca);
                if (tbl_hoca.Rows.Count > 0)
                {
                    arayuz.tc = tb_tcno.Text;
                    arayuz.login = rb_hoca.Text;
                    this.Hide(); 
                    arayuz.Show();
                    baglan.Close();
                    MessageBox.Show(" Giris Basarılı ");
                }
                
                else
                    MessageBox.Show(" Giris Basarısız ");
            }
            else if (rb_ogrenci.Checked == true)
            {
                SqlDataAdapter data_ogrenci = new SqlDataAdapter("Select sifre From ogrenci_ayrıntı where tc_no = '" + tb_tcno.Text+"'", baglan);
                DataTable tbl_ogr = new DataTable();
                data_ogrenci.Fill(tbl_ogr);
                
                if (tbl_ogr.Rows.Count > 0)
                {                      
                    arayuz.tc = tb_tcno.Text;
                    arayuz.login = rb_ogrenci.Text;
                    this.Hide();
                    arayuz.Show();
                    baglan.Close();
                    MessageBox.Show(" Giris Basarılı ");
                }
                else
                    MessageBox.Show(" Giris Basarısız ");
             }
             else if (rb_personel.Checked == true)
             {
                SqlDataAdapter data_personelgiris = new SqlDataAdapter("Select sifre,yetki From personel where tc_no = '" + tb_tcno.Text + "'", baglan);
                DataTable tbl_personelgiris = new DataTable();
                data_personelgiris.Fill(tbl_personelgiris);
                

                if (tbl_personelgiris.Rows.Count > 0)
                {
                    
                    if (tbl_personelgiris.Rows[0][1].ToString() == "1")
                    {
                        arayuz.tc = tb_tcno.Text;
                        arayuz.login = "Admin";
                        arayuz.Show();
                        this.Hide();
                        baglan.Close();
                        MessageBox.Show("Admin Girisi basarılı");

                    }
                    else

                    {
                        arayuz.tc = tb_tcno.Text;
                        arayuz.login = rb_personel.Text;
                        arayuz.Show();
                        this.Hide();
                        baglan.Close();
                        MessageBox.Show("Personel Girisi Basarılı ");
                    }
                    
                    
                    
                    
                    
                    
                }
                
                else    MessageBox.Show(" Giris Basarısız ");
            }
            
         

            baglan.Close();
            
        }

        private void btn_cıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}

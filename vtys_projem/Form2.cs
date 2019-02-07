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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        

        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-C97083V;Initial Catalog=dbproje;Integrated Security=True");
        public string tc;
        public string login;
        public String[] hoca_ıd = new String[99];
        private void Form2_Load(object sender, EventArgs e)
        {
            baglan.Open();
            pnl_dersonay.Visible = false;
            pnl_derssecme.Visible = false;
            pnl_danısman.Visible = false;          


            SqlDataAdapter data_ogrenci = new SqlDataAdapter("SELECT egitim_tip,bolum,fakulte from ogrenci where ogr_ID=(select ogr_ID from ogrenci_ayrıntı where tc_no='" + tc + "') and ogr_ID in (select ogr_ID from ogrenci where mezun=0)", baglan);
            DataTable tbl_ogrenci = new DataTable();
            data_ogrenci.Fill(tbl_ogrenci);

            SqlDataAdapter data_ders = new SqlDataAdapter("SELECT ders_ad,gün,saat,akts from (((onaysız_dersler inner join dersler on onaysız_dersler.ders_ID=dersler.ders_ID)inner join danısman_hoca ON onaysız_dersler.ogr_ID=danısman_hoca.ogr_ID)inner join hoca on onaysız_dersler.hoca_ID=hoca.hoca_ID) where hoca.tc_no ='" + tc + "' and danısman_hoca.ogr_ID in (select ogr_ID from ogrenci where harc=1 and mezun=0)", baglan);
            DataTable tbl_ders = new DataTable();
            data_ders.Fill(tbl_ders);
            
            if (login == "Hoca")
            {
                pnl_dersonay.Visible = true;
                dgv_dersonay.DataSource = tbl_ders;
                MessageBox.Show("harc kontrolu yapıldı ders onayı yapabilirsiniz");
                baglan.Close();
            }
            else if (login == "Ogrenci")

            {

                SqlDataAdapter data_danısman = new SqlDataAdapter("select hoca_ID,unvan,ad,soyad from hoca where fakulte='" + tbl_ogrenci.Rows[0][2] + "' and bolum ='" + tbl_ogrenci.Rows[0][1] + "'", baglan);
                DataTable tbl_danısman = new DataTable();
                data_danısman.Fill(tbl_danısman);

                for (int i = 0; i < tbl_danısman.Rows.Count; i++)
                {
                    cb_danısman.Items.Add(tbl_danısman.Rows[i][1].ToString() + tbl_danısman.Rows[i][2].ToString() + tbl_danısman.Rows[i][3].ToString());
                    hoca_ıd[i] = tbl_danısman.Rows[i][0].ToString();

                }

                pnl_derssecme.Visible = true;
                pnl_danısman.Visible = true;
                SqlDataAdapter data_ogr = new SqlDataAdapter("SELECT egitim_tip,bolum,fakulte from ogrenci where ogr_ID=(select ogr_ID from ogrenci_ayrıntı where tc_no='"+tc+"') and ogr_ID in (select ogr_ID from ogrenci where mezun=0)", baglan);
                DataTable tbl_ogr = new DataTable();
                data_ogr.Fill(tbl_ogr);

                    String bolum = tbl_ogr.Rows[0][1].ToString();
                    String egitim_tip = tbl_ogr.Rows[0][0].ToString();
                    String fakulte = tbl_ogr.Rows[0][2].ToString();


                    
                    
                    
                    if (egitim_tip == "B.hazırlık")
                    {
                        MessageBox.Show("Dersleriniz otomatik Secildi ders programına gözatın.");
                    }
                    else if (egitim_tip == "Normal")
                    {
                        MessageBox.Show("derslere tıklayarak ders secebilirsiniz");
                        lb_dersler.Visible = true;
                        pnl_derssecme.Visible = true;
                    }

                SqlDataAdapter data_dersyaz = new SqlDataAdapter("Select ders_ad,gün,saat,akts from dersler where (ders_tip='"+egitim_tip+"' and bolum = '"+bolum+"' and fakulte= '"+fakulte+"')", baglan);
                DataTable tbl_dersgetir = new DataTable();
                data_dersyaz.Fill(tbl_dersgetir);
                for (int i = 0; i < tbl_dersgetir.Rows.Count; i++)
                {
                    lb_dersler.Items.Add(tbl_dersgetir.Rows[i][0].ToString());
                }

                                
            }

            else if (login=="personel")
            {
                pnl_dersonay.Visible = true;
                pnl_derssecme.Visible = true;
                dgv_dersonay.DataSource = tbl_ders;
                dgv_derssecme.DataSource = tbl_ogrenci;
                baglan.Close();
            }
            
                
            

                       
            baglan.Close();        
        }

        private void btn_onayla_Click(object sender, EventArgs e)
        {
            baglan.Open();           


            SqlDataAdapter data_dersonay = new SqlDataAdapter("exec proc_aktarma '"+tc+"'", baglan);
            DataTable tbl_dersonay = new DataTable();
            data_dersonay.Fill(tbl_dersonay);

            SqlDataAdapter data_ders = new SqlDataAdapter("SELECT ders_ad,akts,gün,saat from ( onaysız_dersler inner join hoca on onaysız_dersler.hoca_ID = hoca.hoca_ID) inner join dersler on onaysız_dersler.ders_ID=dersler.ders_ID	where ogr_ID=(select ogr_ID from ogrenci_ayrıntı where tc_no='" + tc + "') and ogr_ID in(select ogr_ID from ogrenci where harc=1 and mezun=0)", baglan);
            DataTable tbl_ders = new DataTable();
            data_ders.Fill(tbl_ders);
            dgv_dersonay.DataSource = tbl_ders;
            dgv_dersonay.Refresh();
            baglan.Close();
            MessageBox.Show("Ders onay islemi Basarılı");
        }


       
        private void btn_cık_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }


        private void lb_dersler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            baglan.Open();
            try
            {

                SqlDataAdapter data_danısman = new SqlDataAdapter("SELECT hoca_ID from danısman_hoca where ogr_ID=(select ogr_ID from ogrenci_ayrıntı where tc_no='" + tc + "') ", baglan);
                DataTable tbl_danısman = new DataTable();
                data_danısman.Fill(tbl_danısman);

                if (tbl_danısman.Rows.Count > 0)
                {

                    SqlDataAdapter data_ogrID = new SqlDataAdapter("SELECT ogr_ID from ogrenci where ogr_ID=(select ogr_ID from ogrenci_ayrıntı where tc_no='" + tc + "') ", baglan);
                    DataTable tbl_ogrenci = new DataTable();
                    data_ogrID.Fill(tbl_ogrenci);
                    String ogr_ıd = tbl_ogrenci.Rows[0][0].ToString();


                    SqlDataAdapter data_dersyaz = new SqlDataAdapter("Select ders_ID from dersler where ders_ad = '" + lb_dersler.SelectedItem.ToString() + "'", baglan);
                    DataTable tbl_dersgetir = new DataTable();
                    data_dersyaz.Fill(tbl_dersgetir);



                    SqlDataAdapter data_secilmisders = new SqlDataAdapter("select ders_ID from onaysız_dersler where ogr_ID=(select ogr_ID from ogrenci_ayrıntı where tc_no='" + tc + "')", baglan);
                    DataTable tbl_secilmisders = new DataTable();
                    data_secilmisders.Fill(tbl_secilmisders);

                    for (int i = 0; i < tbl_secilmisders.Rows.Count; i++)
                    {
                        if (tbl_secilmisders.Rows[i][0].ToString() == tbl_dersgetir.Rows[0][0].ToString())
                        {
                            MessageBox.Show("bu dersi secmissiniz");
                        }

                    }


                    SqlDataAdapter data_tabloguncelleme = new SqlDataAdapter("Select ders_ad,gün,saat,akts FROM onaysız_dersler INNER JOIN dersler ON onaysız_dersler.ders_ID = dersler.ders_ID where ogr_ID=(select ogr_ID from ogrenci_ayrıntı where tc_no='" + tc + "')", baglan);
                    DataTable tbl_gunceltablo = new DataTable();
                    data_tabloguncelleme.Fill(tbl_gunceltablo);
                    dgv_derssecme.DataSource = tbl_gunceltablo;
                    dgv_derssecme.Refresh();
                }
                else MessageBox.Show("danısman seciniz");
            }

            catch (System.IndexOutOfRangeException)
            {
                MessageBox.Show("dersyok");
            }
            baglan.Close();
        }

        private void btn_danısman_Click(object sender, EventArgs e)
        {
            SqlDataAdapter data_ogrenci = new SqlDataAdapter("SELECT bolum,fakulte from ogrenci where ogr_ID=(select ogr_ID from ogrenci_ayrıntı where tc_no='" + tc + "') and ogr_ID in (select ogr_ID from ogrenci where mezun=0)", baglan);
            DataTable tbl_ogrenci = new DataTable();
            data_ogrenci.Fill(tbl_ogrenci);
            

            string hoca_IDm =hoca_ıd[cb_danısman.SelectedIndex];


            SqlDataAdapter danısman = new SqlDataAdapter("exec proc_danısmansecme '"+hoca_IDm+"','"+tc+"'", baglan);
            DataTable tbl_danısman2 = new DataTable();
            danısman.Fill(tbl_danısman2);

            if (tbl_danısman2.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("danısman zaten secilmis");
            }
            else
                MessageBox.Show("danısman secildi");




        }


        

        
    }
}

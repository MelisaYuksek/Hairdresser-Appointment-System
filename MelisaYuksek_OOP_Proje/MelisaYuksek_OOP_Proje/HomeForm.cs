/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2023-2024 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: Proje
**				ÖĞRENCİ ADI............: Melisa Yüksek
**				ÖĞRENCİ NUMARASI.......: G231210005
**                         DERSİN ALINDIĞI GRUP...: 2C
****************************************************************************/





using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MelisaYuksek_OOP_Proje
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();

        
        }




        private void btnStylist_Click(object sender, EventArgs e)
        {
            this.Hide();
            StylistForm stylistForm = new StylistForm();
            stylistForm.ShowDialog();
            stylistForm = null;
            this.Show();
        }


        private void btnClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientForm clientForm = new ClientForm();
            clientForm.ShowDialog();
            clientForm = null;
            this.Show();

        }
    }
}

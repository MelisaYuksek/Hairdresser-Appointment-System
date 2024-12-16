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
    public partial class AppointmentForm : Form
    {
        private List<Client> clients;
        private string stylistName;

        public AppointmentForm(string stylistName)
        {
            InitializeComponent();
            this.stylistName = stylistName;
            clients = FileHelper.ReadClients();
            ShowAppointments();
        }

        private void ShowAppointments()
        {
            // Stylist adına göre alınan randevuları filtrele
            var appointments = clients.Where(client => client.StylistName == stylistName).ToList();

            // DGV de randevuları görüntüle
            dgvAppointments.DataSource = appointments;
        }




    }
}


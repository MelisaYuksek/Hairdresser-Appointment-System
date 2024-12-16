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
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MelisaYuksek_OOP_Proje
{
    public partial class ClientForm : Form
    {
        private List<Client> clients;
        private List<Stylist> stylists;

        public string ID { get; set; }
        public string name { get; set; }
        public string PhoneNumber { get; set; }
        public string IDNumber { get; set; }
        public string Service { get; set; }
        public string Stylist { get; set; } 
        public DateTime Date { get; set; } 
        public decimal Cost { get; set; }



        public ClientForm()
        {
            InitializeComponent();


            clients = FileHelper.ReadClients();
            stylists = FileHelper.ReadStylists();
            LoadServices();
            LoadStylists();
            UpdateDataGridView();

        }


        private void LoadServices()
        {
            cboService.Items.Clear();
            foreach (var service in ServiceList.Services)
            {
                cboService.Items.Add(service);
            }
        }

        private void LoadStylists()
        {
            cboStylist.Items.Clear();
            foreach (var stylist in stylists)
            {
                cboStylist.Items.Add(stylist.FullName);
            }

        }


        private void UpdateDataGridView()
        {
            dgvClients.DataSource = null;
            dgvClients.DataSource = clients;
            dgvClients.Columns["Price"].HeaderText = "Price"; // Price sütununu ekle ve başlığını ayarla
        }

        private decimal CalculatePrice(string service)
        {
            // Servise göre fiyat hesaplanacak
            // Bu örnek için sabit bir fiyat belirleyelim
            return 50m;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string idNumber = txtIDNumber.Text;
            string service = cboService.SelectedItem.ToString();
            string stylistName = cboStylist.SelectedItem.ToString();
            Stylist selectedStylist = stylists.FirstOrDefault(s => s.FullName == stylistName);
            decimal price = selectedStylist != null ? selectedStylist.Cost : 0; // Stylist'in maliyetini al
            DateTime appointmentDate = dtpAppointmentDate.Value;
            var client = new Client(name, phoneNumber, idNumber, service, stylistName, price, appointmentDate);
            clients.Add(client);
            FileHelper.WriteClients(clients);
            UpdateDataGridView();

        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count > 0)
            {
                var selectedClient = (Client)dgvClients.SelectedRows[0].DataBoundItem;
                clients.Remove(selectedClient);
                FileHelper.WriteClients(clients);
                UpdateDataGridView();
            }

        }
        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // DataGridView hücresine tıklandığında, o satırdaki verileri TextBoxlara aktar
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvClients.Rows[e.RowIndex];
                txtName.Text = selectedRow.Cells["Name"].Value.ToString();
                txtIDNumber.Text = selectedRow.Cells["IDNumber"].Value.ToString();
                txtPhoneNumber.Text = selectedRow.Cells["PhoneNumber"].Value.ToString();
                dtpAppointmentDate.Value = DateTime.ParseExact(selectedRow.Cells["AppointmentDate"].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                cboService.SelectedItem = selectedRow.Cells["Service"].Value.ToString();
                cboStylist.SelectedItem = selectedRow.Cells["Stylist"].Value.ToString();
            }
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Seçilen satırın indeksini al
            int selectedIndex = dgvClients.SelectedRows[0].Index;

            // Seçilen satırın bilgilerini güncelle
            dgvClients.Rows[selectedIndex].Cells["Name"].Value = txtName.Text;
            dgvClients.Rows[selectedIndex].Cells["IDNumber"].Value = txtIDNumber.Text;
            dgvClients.Rows[selectedIndex].Cells["PhoneNumber"].Value = txtPhoneNumber.Text;
            dgvClients.Rows[selectedIndex].Cells["AppointmentDate"].Value = dtpAppointmentDate.Text;
            dgvClients.Rows[selectedIndex].Cells["Service"].Value = cboService.Text;
            dgvClients.Rows[selectedIndex].Cells["Stylist"].Value = cboStylist.Text;

            // ComboBox'ın seçili öğesini kontrol et
            if (cboService.SelectedItem != null)
            {
                dgvClients.Rows[selectedIndex].Cells["Service"].Value = cboService.SelectedItem.ToString();
            }



        }


        private void dgvClients_SelectionChanged(object sender, EventArgs e)
        {
            // DGV de satır seç ve oaly başlasın

            if (dgvClients.SelectedRows.Count > 0)
            {
                

                // Silme veya güncelleme işleminden sonra DGV güncellesin
                UpdateDataGridView();
            }
            else
            {
                // Satır sçemediğinde uyarı versin
                MessageBox.Show("Please select a row to perform delete or update operation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }






        }



        private double GetServiceCost(string service)
        {
            // Hizmetlere göre ücretleri belirle
            switch (service)
            {
                case "Haircut":
                    return 50.0;
                case "Hairstyle":
                    return 40.0;
                case "Manicure":
                    return 30.0;
                // Diğer hizmetler için varsayılan ücreti dön
                default:
                    return 0.0;
            }
        }



        private void btnCalculateTotalPrice_Click(object sender, EventArgs e)
        {
            try
            {
                // DataGridView içindeki Price sütununu topla
                decimal totalPrice = 0;
                foreach (DataGridViewRow row in dgvClients.Rows)
                {
                    if (row.Cells["Price"].Value != null && !string.IsNullOrEmpty(row.Cells["Price"].Value.ToString()))
                    {
                        totalPrice += Convert.ToDecimal(row.Cells["Price"].Value);
                    }
                }

                // Toplam Price'ı label üzerinde göster
                lblTotalPrice.Text = "Total Price: " + totalPrice.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while calculating total price: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}

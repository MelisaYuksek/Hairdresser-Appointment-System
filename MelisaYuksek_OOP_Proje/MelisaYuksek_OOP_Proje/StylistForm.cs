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
    public partial class StylistForm : Form
    {


        private List<Stylist> stylists;
        private List<string> stylistNames = new List<string>();


        public StylistForm()
        {
            InitializeComponent();
            stylists = FileHelper.ReadStylists();
            LoadServices();
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


        private void UpdateDataGridView()
        {
            dgvStylists.DataSource = null;
            dgvStylists.DataSource = stylists;

            // Toplam maliyeti hesapla
            decimal totalCost = CalculateTotalCost();

            // Toplam maliyeti göstermek için bir Label oluştur
            Label totalCostLabel = new Label();
            totalCostLabel.Text = "Total Cost: " + totalCost.ToString("c"); // '
            totalCostLabel.AutoSize = true;

            // Label kontrolünü formun altına yerleştir
            totalCostLabel.Location = new Point(20, dgvStylists.Bottom + 20); // Örnek konum
            this.Controls.Add(totalCostLabel); // Forma ekle

            // Buton oluştur ve Total Cost'u yeniden hesaplamak için Click olayına bağla
            Button recalculateButton = new Button();
            recalculateButton.Text = "Recalculate Total Cost";
            recalculateButton.Location = new Point(150, dgvStylists.Bottom + 20); // Örnek bir konum belirle
            recalculateButton.Click += (sender, e) =>
            {
                // Yeniden hesapla ve Label'i güncelle
                totalCost = CalculateTotalCost();
                totalCostLabel.Text = "Total Cost: " + totalCost.ToString("c");
            };
            this.Controls.Add(recalculateButton); // Forma ekle
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string idNumber = txtIDNumber.Text;
            string service = cboService.SelectedItem.ToString();
            decimal cost = decimal.Parse(costTextBox.Text); // Cost bilgisini al
            var stylist = new Stylist(name, surname, phoneNumber, idNumber, service,cost); 
            stylists.Add(stylist);
            FileHelper.WriteStylists(stylists);
            UpdateDataGridView();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStylists.SelectedRows.Count > 0)
            {
                var selectedStylist = (Stylist)dgvStylists.SelectedRows[0].DataBoundItem;
                stylists.Remove(selectedStylist);
                FileHelper.WriteStylists(stylists);
                UpdateDataGridView();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Seçilen satırın indeksini al
            int selectedIndex = dgvStylists.SelectedRows[0].Index;

            // Seçilen satırın bilgilerini güncelle
            dgvStylists.Rows[selectedIndex].Cells["Name"].Value = txtName.Text;
            dgvStylists.Rows[selectedIndex].Cells["Surname"].Value = txtSurname.Text;
            dgvStylists.Rows[selectedIndex].Cells["IDNumber"].Value = txtIDNumber.Text;
            dgvStylists.Rows[selectedIndex].Cells["PhoneNumber"].Value = txtPhoneNumber.Text;

            // ComboBox'ın seçili öğesini kontrol et
            if (cboService.SelectedItem != null)
            {
                dgvStylists.Rows[selectedIndex].Cells["Service"].Value = cboService.SelectedItem.ToString();
            }


        }

        private void LoadStylists()
        {
           

            
            foreach (DataGridViewRow row in dgvStylists.Rows)
            {
                stylistNames.Add(row.Cells[0].Value.ToString()); 
            }
        }


        private decimal CalculateTotalCost()
        {
            decimal totalCost = 0;

            // DataGridView'deki her bir satır için fiyatları topla
            foreach (DataGridViewRow row in dgvStylists.Rows)
            {
                // DataGridView'de "Service" ve "Cost" adında sütunlar varmış gibi?????
                if (row.Cells["Service"].Value != null && row.Cells["Cost"].Value != null)
                {
                    string service = row.Cells["Service"].Value.ToString();
                    decimal cost = Convert.ToDecimal(row.Cells["Cost"].Value); // Kullanıcının girdiği fiyatı al
                    totalCost += cost;
                }
            }

            return totalCost;
        }

        private void btnViewAppointments_Click(object sender, EventArgs e)
        {
            // DataGridView'dan bir satır seçilmiş mi kontrol et
            if (dgvStylists.SelectedRows.Count > 0)
            {
                // Seçili bir satır varsa, bu satıra karşılık gelen stilistin adını al
                string selectedStylistName = dgvStylists.SelectedRows[0].Cells["FullName"].Value.ToString();

                // Randevuları görüntülemek için bir AppointmentForm oluştur
                AppointmentForm appointmentForm = new AppointmentForm(selectedStylistName);

                // AppointmentForm'u göster
                appointmentForm.ShowDialog();
            }
            else
            {
                // Hiçbir satır seçilmediğinde, kullanıcıya bir uyarı mesajı göster
                MessageBox.Show("Please select a stylist to view appointments.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvStylists_SelectionChanged(object sender, EventArgs e)
        {
          

            // Seçilen satırın kontrolü
            if (dgvStylists.SelectedRows.Count > 0)
            {
                // Seçilen satırın indeksini al
                int selectedIndex = dgvStylists.SelectedRows[0].Index;

                // selectedIndex değerinin sınır kontrollerini yap
                if (selectedIndex >= 0 && selectedIndex < stylistNames.Count)
                {
                    // Seçilen stilist adını stylistNames listesinden al
                    string selectedStylist = stylistNames[selectedIndex];

                }
                else
                {
                    // Kullanıcıya bir hata mesajı göster
                    MessageBox.Show("Geçersiz satır indeksi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void ShowAppointments(string stylistName)
        {
            // Stylist adına göre alınan randevuları görüntülemek için AppointmentFormu aç
            AppointmentForm appointmentForm = new AppointmentForm(stylistName);
            appointmentForm.ShowDialog();
        }


    }
}

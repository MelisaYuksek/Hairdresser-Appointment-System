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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MelisaYuksek_OOP_Proje
{
    public class Client : IPerson
    {
        // arayüzüzden gelen özellikler
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string IDNumber { get; set; }

        // sadee client e özel özlelikler burada
        public string Service { get; set; }
        public string StylistName { get; set; }
        public decimal Price { get; set; }
        public DateTime AppointmentDate { get; set; }

        // Constructor metodu
        public Client(string name,  string phoneNumber, string idNumber, string service, string stylistName, decimal price, DateTime appointmentDate)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            IDNumber = idNumber;
            Service = service;
            StylistName = stylistName;
            Price = price;
            AppointmentDate = appointmentDate;
        }

    }
}

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

namespace MelisaYuksek_OOP_Proje
{
    public class Stylist : IPerson
    {
        // Person arayüzünden gelen özellikler
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string IDNumber { get; set; }

        // Stylist sınıfına özgü özellikler
        public string Surname { get; set; }
        public string Service { get; set; }
        public decimal Cost { get; set; }

        // Constructor metodu
        public Stylist(string name, string surname, string phoneNumber, string idNumber, string service, decimal cost)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
            IDNumber = idNumber;
            Service = service;
            Cost = cost; 
        }

        // Tam adı döndüren metot
        public string FullName => $"{Name} {Surname}";
    }

}

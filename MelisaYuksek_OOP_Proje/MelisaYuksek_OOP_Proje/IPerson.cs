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
    public interface IPerson  //arayüz kendisinden implement edilen bir sınıfa doldurulması zorunlu olan bazı özelliklerin aktarılmasını sağlayacak
    {                               // oluşturduğum client ve stylist classları buradan implement ediliyor
        string Name { get; set; }
        string PhoneNumber { get; set; }
        string IDNumber { get; set; }
    }
}

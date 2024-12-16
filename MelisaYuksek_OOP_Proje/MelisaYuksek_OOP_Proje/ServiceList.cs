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
    public static class ServiceList
    {
        // Örnek hizmetler listesi
        public static List<string> Services { get; } = new List<string>
        {
            "Haircut",
            "Hair Color",
            "Manicure",
            "Pedicure",
            "Facial"
        };
    }
}

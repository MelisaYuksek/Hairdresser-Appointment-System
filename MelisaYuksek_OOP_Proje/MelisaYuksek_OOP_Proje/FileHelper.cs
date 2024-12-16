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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelisaYuksek_OOP_Proje
{
    public static class FileHelper
    {
        // txt belgesine kaydetme dosya yolu belirlensin
        private static string stylistFilePath = "stylists.txt";
        private static string clientFilePath = "clients.txt";

        // Stylist bilgilerini dosyaya yazma metodu
        public static void WriteStylists(List<Stylist> stylists)
        {
            using (StreamWriter writer = new StreamWriter(stylistFilePath))
            {
                foreach (var stylist in stylists)
                {
                    writer.WriteLine($"{stylist.Name},{stylist.Surname},{stylist.PhoneNumber},{stylist.IDNumber},{stylist.Service},{stylist.Cost}");
                }
            }
        }

        public static List<Stylist> ReadStylists()
        {
            List<Stylist> stylists = new List<Stylist>();
            if (File.Exists(stylistFilePath))
            {
                using (StreamReader reader = new StreamReader(stylistFilePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        // ayırdığım her parçanın olduğundan emin ol ona göre ilerle 
                        if (parts.Length >= 6)
                        {
                            Stylist stylist = new Stylist(parts[0], parts[1], parts[2], parts[3], parts[4], decimal.Parse(parts[5]));
                            stylists.Add(stylist);
                        }
                        else
                        {
                            // yanlış data formatı 
                            Console.WriteLine("Invalid data format: " + line);
                        }
                    }
                }
            }
            return stylists;
        }

            // Client bilgilerini dosyaya yazma metodu
            public static void WriteClients(List<Client> clients)
        {
            using (StreamWriter writer = new StreamWriter(clientFilePath))
            {
                foreach (var client in clients)
                {
                    writer.WriteLine($"{client.Name},{client.PhoneNumber},{client.IDNumber},{client.Service},{client.StylistName},{client.Price},{client.AppointmentDate}");
                }
            }
        }

        public static List<Client> ReadClients()
        {
            List<Client> clients = new List<Client>();
            if (File.Exists(clientFilePath))
            {
                using (StreamReader reader = new StreamReader(clientFilePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        Client client = new Client(parts[0], parts[1], parts[2], parts[3], parts[4], decimal.Parse(parts[5]), DateTime.Parse(parts[6]));
                        clients.Add(client);
                    }
                }
            }
            return clients;
        }
    }
}

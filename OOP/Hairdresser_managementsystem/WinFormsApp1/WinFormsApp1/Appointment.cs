/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2023-2024 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:1. Proje
**				ÖĞRENCİ ADI............:Furkan Tataroğlu
**				ÖĞRENCİ NUMARASI.......:g201210089
**                         DERSİN ALINDIĞI GRUP...:1C
****************************************************************************/
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
namespace WinFormsApp1
{
    public class Appointment
    {
        public int Id { get; set; }

        [Required]
        public string CustomerFirstName { get; set; }

        [Required]
        public string CustomerLastName { get; set; }

        [Required]
        public decimal TotalPrice { get; set; }

        [Required]
        public decimal Profit { get; set; }
        [Required]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        [Required]
        public int PersonnelId { get; set; }
        public Personnel Personnel { get; set; }

        [Required] 
        public string Time { get; set; }

        public List<AppointmentService> AppointmentServices { get; set; }


        [NotMapped]
        public string ServiceNames
        {
            get
            {
                return AppointmentServices != null
                    ? string.Join(", ", AppointmentServices.Select(p => p.Service.ServiceName))
                    : string.Empty;
            }
        }

    }
    
}

using System.ComponentModel;
using System.ComponentModel.DataAnnotations; //EKLEDİK

namespace AppModel.Models
{
    public class Musteriler //Public Yaptık
    {
        [Key]
        public int ID { get; set; }

        [DisplayName("MÜŞTERİ ADI")]
        public string ADI { get; set; }

        [DisplayName("MÜŞTERİ SOYADI")]
        public string SOYADI { get; set; }

        [DisplayName("TELEFON NUMARASI")]
        public string TELEFON { get; set; }

        [DisplayName("ADRES")]
        public string ADRES { get; set; }

    }
}
using System.ComponentModel;
using System.ComponentModel.DataAnnotations; //EKLEDİK

namespace AppModel.Models
{
    public class Depolar //Public Yaptık
    {
        [Key]
        public int ID { get; set; }
        [DisplayName("DEPO ADI")]
        public string ADI { get; set; }
        [DisplayName("DEPO ADRESİ")]
        public string ADRES { get; set; }
        [DisplayName("ÇALIŞAN SAYISI")]
        public string CALISANSAYISI { get; set; }
    }
}

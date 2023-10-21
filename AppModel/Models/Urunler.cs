using System.ComponentModel;
using System.ComponentModel.DataAnnotations;//EKLEDİK

namespace AppModel.Models
{
    public class Urunler //Public yaptık
    {
        [Key]
        public int ID { get; set; }

        [DisplayName("ÜRÜN ADI")]
        public string ADI { get; set; }

        [DisplayName("MARKASI")]
        public string MARKA { get; set; }

        [DisplayName("ALIŞ FİYATI")]
        public int ALISFIYAT { get; set; }

        [DisplayName("SATIŞ FİYATI")]
        public int SATISFIYAT { get; set; }

    }
}
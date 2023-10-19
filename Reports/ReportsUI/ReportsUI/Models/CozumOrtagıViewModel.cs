using ReportsUI.DBFirst;

namespace ReportsUI.Models
{
    public class CozumOrtagıViewModel
    {
        public CozumOrtagıViewModel()
        {
            DosyaDurumlars = new HashSet<DosyaDurumlar>();
            CozumOrtagiDosyas = new HashSet<CozumOrtagiDosya>();
            CozumOrtaklaris =new HashSet<CozumOrtaklari>();
        }

        public  virtual ICollection<DosyaDurumlar> DosyaDurumlars { get; set; }
        public virtual ICollection<CozumOrtagiDosya> CozumOrtagiDosyas { get; set; }
        public virtual ICollection<CozumOrtaklari> CozumOrtaklaris { get; set; }
    }
}

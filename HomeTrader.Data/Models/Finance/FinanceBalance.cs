using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeTrader.Data.Models.Finance
{
    public class FinanceBalance
    {

        [Key]
        [Required]
        public int Id { get; set; }
        [ForeignKey("CompanyId")]
        public int CompanyId { get; set; }
        [Display(Name = "Nazwa")]
        public string ComapanyName { get; set; }
        [Display(Name = "rok")]
        public int RaportYear { get; set; }

        #region Bilans
        [Display(Name = "Aktywa trwale")]
        public int AktywaTrwale { get; set; }
        [Display(Name = "AktywaObrotowe")]
        public int AktywaObrotowe { get; set; }
        [Display(Name = "Aktywa Razem")]
        public int AktywaRazem { get; set; }
        [Display(Name = "Kapital Wlasny Akcjonariuszy Jednostki Dominujacej")]
        public int KapitalWlasnyAkcjonariuszyJednostkiDominujacej { get; set; }
        [Display(Name = "Udzialy Niekontrolujace")]
        public int UdzialyNiekontrolujace { get; set; }
        [Display(Name = "Zobowiazania Dlugoterminowe")]
        public int ZobowiazaniaDlugoterminowe { get; set; }
        [Display(Name = "Zobowiazania Krotkoterminowe")]
        public int ZobowiazaniaKrotkoterminowe { get; set; }
        [Display(Name = "Pasywa Razem")]
        public int PasywaRazem { get; set; }
        #endregion
    }
}

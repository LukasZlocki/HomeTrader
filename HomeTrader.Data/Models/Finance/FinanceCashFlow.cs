using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeTrader.Data.Models.Finance
{
    public class FinanceCashFlow
    {

        [Key]
        [Required]
        public int Id { get; set; }
        [ForeignKey("CompanyId")]
        public int CompanyId { get; set; }
        [Display(Name = "Nazwa")]
        public string ComapanyName { get; set; }
        [Display(Name = "Rok")]
        public int RaportYear { get; set; }

        #region Cash Flow
        [Display(Name = "Przeplywy z dzialalnosci operacyjnej")]
        public int PrzeplywyZDzialalnosciOperacyjnej { get; set; }
        [Display(Name = "Przeplywy z dzialalnosci investycyjnej")]
        public int PrzeplywyZDzialalnosciInvestycyjnej { get; set; }
        [Display(Name = "Przeplywy z dzialalnosci finansowej")]
        public int PrzeplywyZDzialalnosciFinansowej { get; set; }
        [Display(Name = "Przeplywy razem")]
        public int PrzeplywyRazem { get; set; }
        #endregion
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GridviewCrudOps.Models {
    public class Company3
    {
        [Key]
        public int CompanyId { get; set; }

        [Required]
        [StringLength(10)]
        public string Name { get; set; }
    }
}

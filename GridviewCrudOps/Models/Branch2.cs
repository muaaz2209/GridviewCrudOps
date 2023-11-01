using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GridviewCrudOps.Models;
public class Branch2
{
    [Key]
    public int BranchId { get; set; }

    [Required]
    [StringLength(10)]
    public string Name { get; set; }

    [ForeignKey("Company")]
    public int CompanyId { get; set; }
    public Company Company { get; set; }
}

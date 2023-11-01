using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GridviewCrudOps.Models;
public class Employee
{
    [Key]
    public int EmployeeId { get; set; }

    [Required]
    [StringLength(10)]
    public string Name { get; set; }

    [ForeignKey("Company")]
    public int CompanyId { get; set; }
    public Company Company { get; set; }

    [ForeignKey("Branch")]
    public int BranchId { get; set; }
    public Branch2 Branch { get; set; }
}

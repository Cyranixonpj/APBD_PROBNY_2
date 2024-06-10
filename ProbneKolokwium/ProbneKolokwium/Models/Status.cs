using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProbneKolokwium.Models;
[Table("Status")]
public class Status
{
    [Key]
    [Column("ID")]
    public int StatusId { get; set; }
    
    [Column("Name")]
    [MaxLength(50)]
    public string StatusName { get; set; }
    
    public IEnumerable<Order>Orders { get; set; }
}
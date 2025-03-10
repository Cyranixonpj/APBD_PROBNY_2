using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProbneKolokwium.Models;
[Table("Client")]
public class Client
{
    
    [Key]
    [Column("ID")]
    public int ClientId { get; set; }
    
    [Column("FirstName")]
    [MaxLength(50)]
    public string ClientFirstName { get; set; }
    
    
    [Column("LastName")]
    [MaxLength(100)]
    public string ClientLastName { get; set; }
    
    public IEnumerable<Order>Orders { get; set; }
}
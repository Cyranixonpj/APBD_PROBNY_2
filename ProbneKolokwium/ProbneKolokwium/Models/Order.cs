using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProbneKolokwium.Models;
[Table("Order")]
public class Order
{
    [Key]
    [Column("ID")]
    public int OrderId { get; set; }
    
    [Column("CreatedAt", TypeName = "datetime")]
    public DateTime CreatedAt { get; set; }
    
    [Column("FullfilledAt", TypeName = "datetime")]
    public DateTime? FullfilledAt { get; set; }
    
    [ForeignKey("Client")]
    [Column("ClientID")]
    public int ClientId { get; set; }
    
    [ForeignKey("Status")]
    [Column("StatusID")]
    public int StatusId { get; set; }
    
    public IEnumerable<ProductOrder>ProductOrders { get; set; }
}
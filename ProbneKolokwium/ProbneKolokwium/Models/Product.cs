using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ProbneKolokwium.Models;

[Table("Product")]
public class Product
{
    [Key]
    [Column("ID")]
    public int ProductId { get; set; }
    
    [Column("Name")]
    [MaxLength(50)]
    public string ProductName { get; set; }
    
    [Column("Price",TypeName = "numeric(10,2)")]
    public double ProductPrice { get; set; }
    
    public IEnumerable<ProductOrder>ProductOrders { get; set; }
    
}
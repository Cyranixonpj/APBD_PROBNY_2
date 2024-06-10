using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ProbneKolokwium.Models;
[Table("Product_Order")]
[PrimaryKey("ProductId", "OrderId")]
public class ProductOrder
{
    [ForeignKey("Product")]
    [Column("ProductID")]
    public int ProductId { get; set; }
    
    [ForeignKey("Order")]
    [Column("OrderID")]
    public int OrderId { get; set; }
    
    [Column("Amount")] 
    public int Amount { get; set; }
    
}
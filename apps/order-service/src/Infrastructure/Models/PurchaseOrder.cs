using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OrderService.Core.Enums;

namespace OrderService.Infrastructure.Models;

[Table("PurchaseOrders")]
public class PurchaseOrderDbModel
{
    [Required()]
    public DateTime CreatedAt { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? Notes { get; set; }

    public DateTime? OrderDate { get; set; }

    [StringLength(1000)]
    public string? OrderNumber { get; set; }

    public StatusEnum? Status { get; set; }

    [StringLength(1000)]
    public string? Supplier { get; set; }

    [Range(-999999999, 999999999)]
    public double? TotalAmount { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}

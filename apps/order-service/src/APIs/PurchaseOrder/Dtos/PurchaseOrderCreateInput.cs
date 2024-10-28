using OrderService.Core.Enums;

namespace OrderService.APIs.Dtos;

public class PurchaseOrderCreateInput
{
    public DateTime CreatedAt { get; set; }

    public string? Id { get; set; }

    public string? Notes { get; set; }

    public DateTime? OrderDate { get; set; }

    public string? OrderNumber { get; set; }

    public StatusEnum? Status { get; set; }

    public string? Supplier { get; set; }

    public double? TotalAmount { get; set; }

    public DateTime UpdatedAt { get; set; }
}

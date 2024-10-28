using OrderService.APIs.Dtos;
using OrderService.Infrastructure.Models;

namespace OrderService.APIs.Extensions;

public static class PurchaseOrdersExtensions
{
    public static PurchaseOrder ToDto(this PurchaseOrderDbModel model)
    {
        return new PurchaseOrder
        {
            CreatedAt = model.CreatedAt,
            Id = model.Id,
            Notes = model.Notes,
            OrderDate = model.OrderDate,
            OrderNumber = model.OrderNumber,
            Status = model.Status,
            Supplier = model.Supplier,
            TotalAmount = model.TotalAmount,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static PurchaseOrderDbModel ToModel(
        this PurchaseOrderUpdateInput updateDto,
        PurchaseOrderWhereUniqueInput uniqueId
    )
    {
        var purchaseOrder = new PurchaseOrderDbModel
        {
            Id = uniqueId.Id,
            Notes = updateDto.Notes,
            OrderDate = updateDto.OrderDate,
            OrderNumber = updateDto.OrderNumber,
            Status = updateDto.Status,
            Supplier = updateDto.Supplier,
            TotalAmount = updateDto.TotalAmount
        };

        if (updateDto.CreatedAt != null)
        {
            purchaseOrder.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            purchaseOrder.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return purchaseOrder;
    }
}

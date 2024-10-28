using OrderService.APIs.Common;
using OrderService.APIs.Dtos;

namespace OrderService.APIs;

public interface IPurchaseOrdersService
{
    /// <summary>
    /// Create one Purchase Order
    /// </summary>
    public Task<PurchaseOrder> CreatePurchaseOrder(PurchaseOrderCreateInput purchaseorder);

    /// <summary>
    /// Delete one Purchase Order
    /// </summary>
    public Task DeletePurchaseOrder(PurchaseOrderWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Purchase Orders
    /// </summary>
    public Task<List<PurchaseOrder>> PurchaseOrders(PurchaseOrderFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Purchase Order records
    /// </summary>
    public Task<MetadataDto> PurchaseOrdersMeta(PurchaseOrderFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Purchase Order
    /// </summary>
    public Task<PurchaseOrder> PurchaseOrder(PurchaseOrderWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Purchase Order
    /// </summary>
    public Task UpdatePurchaseOrder(
        PurchaseOrderWhereUniqueInput uniqueId,
        PurchaseOrderUpdateInput updateDto
    );
}

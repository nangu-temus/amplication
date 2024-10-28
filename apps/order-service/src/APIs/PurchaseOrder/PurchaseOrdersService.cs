using OrderService.Infrastructure;

namespace OrderService.APIs;

public class PurchaseOrdersService : PurchaseOrdersServiceBase
{
    public PurchaseOrdersService(OrderServiceDbContext context)
        : base(context) { }
}

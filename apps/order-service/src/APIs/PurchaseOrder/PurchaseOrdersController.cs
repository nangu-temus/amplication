using Microsoft.AspNetCore.Mvc;

namespace OrderService.APIs;

[ApiController()]
public class PurchaseOrdersController : PurchaseOrdersControllerBase
{
    public PurchaseOrdersController(IPurchaseOrdersService service)
        : base(service) { }
}

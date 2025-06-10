using EShoppingAPI.Common;
using EShoppingAPI.interfaces;
using EShoppingAPI.Models;
using EShoppingAPI.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShoppingAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly EshoppingDbContext _db;
        private readonly IOrder _order;
        public OrderController(EshoppingDbContext db,IOrder order)
        {
            _db = db;
            _order=order;
        }
        [HttpPost]
        public string SubmitOrder(OrderModel order)
        {
            if (order.Products.Any())
            {
                _order.SaveOrder(order);
            }
            return "success";
        }
        
    }
}

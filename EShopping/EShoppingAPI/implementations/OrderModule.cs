using EShoppingAPI.Common;
using EShoppingAPI.interfaces;
using EShoppingAPI.Models;
using EShoppingAPI.ViewModels;

namespace EShoppingAPI.implementations
{
    public class OrderModule : IOrder
    {
        private readonly EshoppingDbContext _db;
        public OrderModule(EshoppingDbContext db)
        {
            _db = db;
        }
        public void SaveOrder(OrderModel order)
        {
            var products = order.Products.Join(_db.TblProducts, o => o.Id, p => p.Id, (o, p) => new { p.Id, p.Price, p.Discount, o.Quantity });
            TblOrder tblOrder = new TblOrder();
            tblOrder.OrderStatus = (int)OrderStatus.Placed;
            tblOrder.CreatedOn = DateTime.Now;
            tblOrder.IsPayment = (int)PaymentStatus.Pending;
            tblOrder.Discount = order.Discount;
            tblOrder.UserId = order.UserId;
            tblOrder.TotalPrice = products.Sum(x => (x.Price * x.Quantity));
            _db.TblOrders.Add(tblOrder);
            _db.SaveChanges();
            tblOrder.OrderNumber = "ORD" + tblOrder.Id;
            _db.TblOrders.Update(tblOrder);
            _db.SaveChanges();
            foreach (var item in order.Products)
            {
                TblOrderDetail tblOrderDetail = new TblOrderDetail();
                tblOrderDetail.OrderId = tblOrder.Id;
                tblOrderDetail.ProductId = item.Id;
                tblOrderDetail.Quantity = item.Quantity;
                tblOrderDetail.Price = products.Where(x => x.Id == item.Id).First().Price;
                tblOrderDetail.CreatedDate = DateTime.Now;
                _db.TblOrderDetails.Add(tblOrderDetail);
                _db.SaveChanges();

                TblProduct tblProduct = _db.TblProducts.Where(x => x.Id == item.Id).First();
                tblProduct.Quantity = tblProduct.Quantity - item.Quantity;
                _db.TblProducts.Update(tblProduct);
                _db.SaveChanges();

            }
        }
    }
}

using System;
using System.Collections.Generic;
using car_service.Models;
using car_service.Services;
using Microsoft.AspNetCore.Mvc;

namespace car_service.Controllers
{
  [Route("order")]
  [ApiController]
  public class OrderController : ControllerBase
  {
    private ServiceOrder _order;
    public OrderController(ServiceOrder order)
    {
      this._order = order;
    }

    [HttpPost]
    public void CreateOrder(Order order)
    {
      this._order.Create(order);
    }

    [HttpGet]
    public List<Order> GetService()
    {
      return this._order.Get();
    }

    [HttpDelete]
    public void DeleteAllOrders()
    {
      this._order.DeleteAll();
    }

    // [HttpPost]
    // public void AddService(OrderItem orderItem)
    // {
    //   this._order.AddService(orderItem);
    // }
  }
}
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
    // public int _orderId;
    public OrderController(ServiceOrder order)
    {
      this._order = order;
    }

    [HttpPost]
    public void CreateOrder(Order order)
    {
      // this._orderId = order.Id;
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

    [HttpPost("{idService}")]
    public void AddService(int idService, int idOrder = 1)
    {
      this._order.AddService(idService, idOrder);
    }
  }
}
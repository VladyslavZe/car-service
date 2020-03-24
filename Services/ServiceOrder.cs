using System;
using System.Collections.Generic;
using System.Linq;
using car_service.Data;
using car_service.Models;

namespace car_service.Services
{
  public class ServiceOrder
  {
    private AutoServiceDbContext _context;
    public ServiceOrder(AutoServiceDbContext context)
    {
      this._context = context;
    }

    public void Create(Order order)
    {
      this._context.Orders.Add(order);
      _context.SaveChanges();
    }
    public List<Order> Get()
    {
      return this._context.Orders.ToList();
    }

    public void DeleteAll()
    {
      this._context.Orders.RemoveRange(_context.Orders.ToList());
      this._context.SaveChanges();
    }

    public void AddService(int idService, int orderId)
    {
      System.Console.WriteLine($"ИД Сервиса - {idService}, ИД Заказа -  {orderId} ");
      // int idOrder = this._context.Orders.Find(id);
      // this._context.OrderItems(idService, orderId);
    }
  }
}
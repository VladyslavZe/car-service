using System;
using System.Collections.Generic;
using System.Linq;
using car_service.Data;
using car_service.Models;

namespace car_service.Services
{
  public class ServiceInputData
  {
    private AutoServiceDbContext _context;

    public ServiceInputData(AutoServiceDbContext context)
    {
      this._context = context;
    }

    public List<OrderItem> Get()
    {
      return this._context.OrderItems.ToList();
    }


    public void AddService(OrderItem orderItem)
    {
      this._context.OrderItems.Add(orderItem);
      this._context.SaveChanges();
    }

  }
}
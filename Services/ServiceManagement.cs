using System;
using System.Collections.Generic;
using System.Linq;
using car_service.Data;
using car_service.Models;

namespace car_service.Services
{
  public class ServiceManagement
  {
    private AutoServiceDbContext _context;

    public ServiceManagement(AutoServiceDbContext context)
    {
      this._context = context;
    }

    public void Create(Service service)
    {
      this._context.Services.Add(service);
      _context.SaveChanges();
    }

    public List<Service> Get()
    {
      return this._context.Services.ToList();
    }
  }
}
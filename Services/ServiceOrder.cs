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
  }
}
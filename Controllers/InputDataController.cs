using System;
using System.Collections.Generic;
using car_service.Models;
using car_service.Services;
using Microsoft.AspNetCore.Mvc;

namespace car_service.Controllers
{
  [Route("inputData")]
  [ApiController]
  public class InputDataController : ControllerBase
  {
    private ServiceInputData _context;
    public InputDataController(ServiceInputData context)
    {
      this._context = context;
    }

    [HttpGet]
    public List<OrderItem> GetService()
    {
      return this._context.Get();
    }

    [HttpPost]
    public void AddService(OrderItem orderItem)
    {
      this._context.AddService(orderItem);
    }
  }
}
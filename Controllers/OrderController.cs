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
    private DateTime _date;
    private int _idClient;
    public OrderController()
    {
      this._date = new DateTime();
    }

  }
}
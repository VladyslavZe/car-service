using System.Collections.Generic;
using car_service.Models;
using car_service.Services;
using Microsoft.AspNetCore.Mvc;

namespace car_service.Controllers
{
  [Route("api/service")]
  [ApiController]
  public class ServiceController : ControllerBase
  {
    private ServiceManagement _service;
    public ServiceController(ServiceManagement service)
    {
      this._service = service;
    }

    [HttpGet]
    public List<Service> GetService(Service service)
    {
      return this._service.Get();
    }

    [HttpPost]
    public void CreateService(Service service)
    {
      _service.Create(service);
    }

  }
}
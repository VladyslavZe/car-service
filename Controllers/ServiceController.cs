using System.Collections.Generic;
using car_service.Models;
using car_service.Services;
using Microsoft.AspNetCore.Mvc;

namespace car_service.Controllers
{
  [Route("service")]
  [ApiController]
  public class ServiceController : ControllerBase
  {
    private ServiceManagement _service;
    public ServiceController(ServiceManagement service)
    {
      this._service = service;
    }


    [HttpPost]
    public void CreateService(Service service)
    {
      this._service.Create(service);
    }

    [HttpGet]
    public List<Service> GetService()
    {
      return this._service.Get();
    }
  }
}
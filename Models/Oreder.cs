
using System;
using System.Collections.Generic;

namespace car_service.Models
{
  public class Order
  {
    public int Id { get; set; }
    public int IdClient { get; set; }
    public DateTime DateTime { get; }
    private List<Service> Services;

    public Order()
    {
    }

    public Order(int id, int IdClient)
    {
      this.Id = id;
      this.IdClient = IdClient;
      this.DateTime = new DateTime();
      this.Services = new List<Service>();
    }
  }
}

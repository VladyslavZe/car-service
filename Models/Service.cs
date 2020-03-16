
namespace car_service.Models
{
  public class Service
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Service()
    {
    }

    public Service(int id, string name, decimal price)
    {
      this.Id = id;
      this.Name = name;
      this.Price = price;
    }
  }
}


namespace car_service.Models
{
  public class Service
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }

    public Service()
    {
    }

    public Service(int id, string name, decimal price, string category)
    {
      this.Id = id;
      this.Name = name;
      this.Price = price;
      this.Category = category;
    }
  }
}

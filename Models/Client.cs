
namespace car_service.Models
{
  public class Client
  {
    public int Id { get; set; }
    public string Name { get; set; }

    public Client()
    {
    }

    public Client(int id, string name)
    {
      this.Id = id;
      this.Name = name;
    }
  }
}

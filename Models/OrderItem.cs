
namespace car_service.Models
{
  public class OrderItem
  {
    public int IdOrder { get; set; }
    public int IdService { get; set; }

    public OrderItem()
    {
    }

    public OrderItem(int id, int idService)
    {
      this.IdOrder = id;
      this.IdService = idService;
    }
  }
}


namespace car_service.Models
{
  public class OrderItem
  {
    public int Id { get; set; }
    public int IdOrder { get; set; }
    public int IdService { get; set; }

    public OrderItem()
    {
    }

    public OrderItem(int idOrder, int idService)
    {
      this.IdOrder = idOrder;
      this.IdService = idService;
    }
  }
}

using PizzaApi.Modal.Api;

namespace PizzaApi.Repository;

public interface IOrderRepository
{
	public List<Order> GetAllOrders();
	public Order GetSingleOrder(string index);
	public List<PizzaPrice> GetPizzaNames();
}
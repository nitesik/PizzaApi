using PizzaApi.Modal.Api;

namespace PizzaApi.Service;

public interface IOrderService
{
	public List<Order> GetAllOrders();
	public Order GetSingleOrder(string index);
	public List<PizzaPrice> GetPizzaNames();
}
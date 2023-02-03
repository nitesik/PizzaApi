using PizzaApi.Modal.Api;
using PizzaApi.Repository;

namespace PizzaApi.Service;

public class OrderService : IOrderService
{
	private IOrderRepository _orderRepository;

	public OrderService(IOrderRepository orderRepository)
	{
		_orderRepository = orderRepository;
	}

	public Order GetSingleOrder(string index)
	{
		return _orderRepository.GetSingleOrder(index);
	}
	public List<Order> GetAllOrders()
	{
		return _orderRepository.GetAllOrders();
	}

	public List<PizzaPrice> GetPizzaNames()
	{
		return _orderRepository.GetPizzaNames();
	}
}
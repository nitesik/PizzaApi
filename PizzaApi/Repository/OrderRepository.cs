using Newtonsoft.Json;
using PizzaApi.Modal.Api;

namespace PizzaApi.Repository;

public class OrderRepository : IOrderRepository
{

	public List<PizzaPrice> GetPizzaNames()
	{
		List<Order> orders = GetAllOrders();

		List<PizzaPrice> newOrders = new List<PizzaPrice>();

		orders.ForEach(order =>
			{
				newOrders.Add(new PizzaPrice()
				{
					name = order.name,
					price = order.price
				});
			}
		);

		return newOrders;
	}

	public Order GetSingleOrder(string index)
	{
		var orders = GetAllOrders();
		return orders[Convert.ToInt32(index)];
	}
	
	public List<Order> GetAllOrders()
	{
		List<Order> orders = new List<Order>();

		using (StreamReader file = new StreamReader("./Repository/Orders.json"))
		{
			string json = file.ReadToEnd();
			orders = JsonConvert.DeserializeObject<List<Order>>(json);
		}


		return orders;
	}
}
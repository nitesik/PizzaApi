using Microsoft.AspNetCore.Mvc;
using PizzaApi.Service;

namespace PizzaApi.Controllers;

[Route("Orders")]
public class OrderController : Controller
{
	private IOrderService _orderService;

	public OrderController(IOrderService orderService)
	{
		_orderService = orderService;
	}

	[HttpGet]
	[Route("{index}")]
	public IActionResult GetSingleOrder(string index)
	{
		return Ok(_orderService.GetSingleOrder(index));
	}
	
	// GET
	[HttpGet]
	public IActionResult Index()
	{
		return Ok(_orderService.GetAllOrders());
	}

	[HttpGet]
	[Route("Pizzas")]
	public IActionResult PizzaNames()
	{

		return Ok(_orderService.GetPizzaNames());
	}
}
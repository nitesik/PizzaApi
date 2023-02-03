namespace PizzaApi.Modal.Api;

public class Order
{
	public string name { get; set; }
	public float price { get; set; }
	public List<string> ingredients { get; set; }
}
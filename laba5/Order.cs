// Клас замовлення
public class Order
{
    public List<OrderItem> Items { get; set; }
    public double TotalPrice { get; set; }
    public string Status { get; set; }

    public Order()
    {
        Items = new List<OrderItem>();
        Status = "Pending";
    }

    public void AddItem(Product product, int quantity)
    {
        Items.Add(new OrderItem { Product = product, Quantity = quantity });
        TotalPrice += product.Price * quantity;
    }

    public void CompleteOrder()
    {
        Status = "Completed";
    }
}
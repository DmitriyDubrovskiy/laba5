// Клас магазину
public class Store
{
    public List<User> Users { get; set; }
    public List<Product> Products { get; set; }
    public List<Order> Orders { get; set; }

    public Store()
    {
        Users = new List<User>();
        Products = new List<Product>();
        Orders = new List<Order>();
    }

    public void AddUser(User user)
    {
        Users.Add(user);
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public Order CreateOrder(User user)
    {
        var order = new Order();
        Orders.Add(order);
        user.PurchaseHistory.Add(order);
        return order;
    }

    public List<Product> SearchProducts(string criteria)
    {
        return Products.Where(p => p.Search(criteria)).ToList();
    }
}
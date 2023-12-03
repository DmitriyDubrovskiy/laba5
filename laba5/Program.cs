class Program
{
    static void Main()
    {
        // Приклад використання
        Store store = new Store();

        User user1 = new User("user1", "password1");
        User user2 = new User("user2", "password2");
        store.AddUser(user1);
        store.AddUser(user2);

        Product product1 = new Product("Laptop", 1000, "Powerful laptop", "Electronics");
        Product product2 = new Product("Book", 20, "Interesting book", "Books");
        store.AddProduct(product1);
        store.AddProduct(product2);

        Order order1 = store.CreateOrder(user1);
        order1.AddItem(product1, 2);
        order1.AddItem(product2, 3);
        order1.CompleteOrder();

        string searchCriteria = "book";
        List<Product> searchResults = store.SearchProducts(searchCriteria);

        Console.WriteLine($"Search results for '{searchCriteria}':");
        foreach (Product result in searchResults)
        {
            Console.WriteLine($"{result.Name} - {result.Price}$ ({result.Category})");
        }
    }
}

// Клас товару
public class Product : ISearchable
{
    public string Name { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }

    public Product(string name, double price, string description, string category)
    {
        Name = name;
        Price = price;
        Description = description;
        Category = category;
    }

    public bool Search(string criteria)
    {
        return Name.ToLower().Contains(criteria.ToLower()) || Category.ToLower().Contains(criteria.ToLower());
    }
}
class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order()
    {
        this._products = new List<Product>();
    }
    public Order(Customer customer)
    {
        this._customer = customer;
        this._products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalOrder()
    {
        int costSendInUSA = 5;
        int costSendOutUSA = 35;
        double costSend = 0;
        foreach (Product product in _products)
        {
            costSend += product.GetTotalCost();

        }
        if (_customer.isLiveInUSA())
        {
            costSend += costSendInUSA;
        }
        else
        {
            costSend += costSendOutUSA;
        }

        return costSend;

    }

    public string GetPackingLabel()
    {
        string label = "[PackingLabel]\n";
        foreach (Product product in _products)
        {
            label += product.GetPackingInfo() + "\n";

        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"[Shipping Label]\n{_customer.GetName()}\n{_customer.GetAddress()}";
    }




}

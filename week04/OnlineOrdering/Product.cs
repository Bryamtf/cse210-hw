class Product
{
    private int _productId;
    private string _nameProduct;
    private double _price;
    private int _quantity;

   public Product() { }
   public Product(int productId, string nameProduct, double price, int quantity)
    {
        this._productId = productId;
        this._nameProduct = nameProduct;
        this._price = price;
        this._quantity = quantity;
    }
    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    public string GetPackingInfo()
    {
        return $"{_nameProduct} (ID: {_productId})";
    }
}
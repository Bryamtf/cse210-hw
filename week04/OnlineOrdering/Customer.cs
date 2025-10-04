class Customer
{
    private string _nameCustomer;
    private Address _address;
   public Customer() { }
  public  Customer(string nameCustomer, Address address)
    {
        this._nameCustomer = nameCustomer;
        this._address = address;
    }

    public bool isLiveInUSA()
    {
        return _address.isLiveInUSA();
    }

    public string GetName()
    {
        return this._nameCustomer;
    }

    public string GetAddress()
    {
        return this._address.GetFullAddress();
    }
}
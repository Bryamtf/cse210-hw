class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address() { }
    public Address(string street, string city, string stateProvince, string country)
    {
        this._street = street;
        this._city = city;
        this._stateProvince = stateProvince;
        this._country = country;
    }
    public bool isLiveInUSA()
    {
        if (_country.ToUpper().Equals("USA"))
        {
            return true;
        }
        return false;
    }

    public string GetFullAddress()
    {
        return $"{_street}, {_city}, {_stateProvince}, {_country}";
    }
}
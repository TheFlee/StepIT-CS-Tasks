// 5
public enum ArticleType
{
    Food,
    Electronics,
    Clothing
}

// 6
public enum ClientType
{
    Regular,
    VIP
}

//7
public enum PayType
{
    Cash,
    CreditCard
}

// 1
struct Article
{
    public string productCode;
    public string productName;
    public double price;
    public ArticleType Type;
}

// 2
struct Client
{
    public string clientCode;
    public string fullName;
    public string address;
    public string phone;
    public int numberOfOrders;
    public double totalAmountOfOrders;
    public ClientType Type;
}

// 3
struct RequestItem
{
    public Article commodity;
    public int numberOfCommodity;
}


// 4
struct Request
{
    public string orderCode;
    public Client client;
    public string orderDate;
    public RequestItem[] orderedProducts;
    public PayType PaymentType;
    public double orderPrice
    {
        get
        {
            double total = 0;
            for (int i = 0; i < orderedProducts.Length; i++)
            {
                total += orderedProducts[i].commodity.price * orderedProducts[i].numberOfCommodity;
            }
            return total;
        }
    }

}

namespace ProbneKolokwium.ResponseModels;

public class GetClientOrdersResponseModel
{
    public int OrderId { get; set; }

    public string ClientsLastName { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime FullfilledAt { get; set; }
    public string Status { get; set; }
    
    public List<GetProductList> Products { get; set; }
}

public class GetProductList()
{
    public string Name { get; set; }

    public double Price { get; set; }

    public int Amount { get; set; }
}
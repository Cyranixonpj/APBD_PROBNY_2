using Microsoft.EntityFrameworkCore;
using ProbneKolokwium.Contexts;
using ProbneKolokwium.ResponseModels;

namespace ProbneKolokwium.Service;


public interface IOrderService
{
    Task<GetClientOrdersResponseModel> GetOrdersByIdAsync(int id);
}


public class OrderService(DatabaseContext context): IOrderService
{
    public async Task<GetClientOrdersResponseModel> GetOrdersByIdAsync(int id)
    {
        // var result = await context.Clients
        //     .Where(e => e.ClientId == id)
        //     .Select(e => new GetClientOrdersResponseModel()
        //     {
        //         OrderId = e.Orders.Select(e => e.OrderId).FirstOrDefault(),
        //         ClientsLastName = e.ClientLastName,
        //         CreatedAt = e.Orders.Select(e => e.CreatedAt).FirstOrDefault(),
        //         FullfilledAt = e.Orders.Select(e => e.FullfilledAt).FirstOrDefault(),
        //         
        //
        //     }).FirstOrDefaultAsync();
        //
        //
        // return null;
    }
}
using Domain.Models;
using Microsoft.AspNetCore.Http;
namespace Infrastracture.Services;

public interface ICustomerService
{
    public Task<List<Customer>> GetCustomers();
    public Task AddCustomer(Customer customer);
    public Task UpdateCustomer(Customer customer);
    public Task DeleteCustomer(int id);
}
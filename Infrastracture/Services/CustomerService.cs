using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Domain;
using Domain.Models;
using Infrastracture.DataContext;
using Microsoft.AspNetCore.Http;

namespace Infrastracture.Services;

public class CustomerService : ICustomerService
{
    private readonly DapperContext _db;

    public CustomerService(DapperContext context)
    {
        _db = context;
    }

    public async Task<List<Customer>> GetCustomers()
    {
        var sql = "SELECT * FROM Customer";
        var res = await _db.Connection().QueryAsync<Customer>(sql);
        return res.ToList();
    }

    public async Task AddCustomer(Customer customer)
    {
        var sql =
            "INSERT INTO Customer (FullName, Email, PhoneNumber, Gender, Address) VALUES (@FullName, @Email, @PhoneNumber, @Gender, @Address)";
        await _db.Connection().ExecuteAsync(sql, customer);
    }

    public async Task UpdateCustomer(Customer customer)
    {
        var sql =
            "UPDATE Customer SET FullName = @FullName, Email = @Email, PhoneNumber = @PhoneNumber, Gender = @Gender, Address = @Address WHERE Id = @Id";
        await _db.Connection().ExecuteAsync(sql, customer);
    }

    public async Task DeleteCustomer(int id)
    {
        var sql = "DELETE FROM Customer WHERE Id = @Id";
        await _db.Connection().ExecuteAsync(sql, new { Id = id });
    }

   
}
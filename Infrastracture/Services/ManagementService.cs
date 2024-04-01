using Dapper;
using Domain.Models;
using Infrastracture.DataContext;

namespace Infrastracture.Services;

public class ManagementService : IManagementService
{
    private readonly DapperContext _db;

    public ManagementService(DapperContext context)
    {
        _db = context;
    }
    public async Task<List<Management>> GetManagement()
    {
        var sql = "select * from Management";
        var res = await _db.Connection().QueryAsync<Management>(sql);
        return res.ToList();
    }

    public async Task AddManagement(Management management)
    {
        var sql =
            "insert into Management(AccountNumber,AccountType,Balance,CustomerId)values (@AccountNumber,@AccountType,@Balance,@CustomerId)";
        await _db.Connection().ExecuteAsync(sql, management);
    }

    public async Task UpdateManagement(Management management)
    {
        var sql =
            "update Management set AccountNumber = @AccountNumber,AccountType = @AccountType,Balance = @Balance,CustomerId = @CustomerId where Id = @Id";
        await _db.Connection().ExecuteAsync(sql, management);
    }

    public async Task DeleteManagement(int id)
    {
        var sql = "delete from Management where Id = @Id";
        await _db.Connection().ExecuteAsync(sql, new { Id = id });
    }
}
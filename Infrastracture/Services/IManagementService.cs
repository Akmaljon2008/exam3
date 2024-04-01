using Domain.Models;

namespace Infrastracture.Services;

public interface IManagementService
{
    public Task<List<Management>> GetManagement();
    public Task AddManagement(Management management);
    public Task UpdateManagement(Management management);
    public Task DeleteManagement(int id);

}
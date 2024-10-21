using GesFin.Domain.Models.User;

public interface IUserService
{
    Task Add(User user);
    Task Delete(User user);
    Task Delete(long id);
    Task<User> Get(long id);
    Task<List<User>> GetAll();
    Task Update(User user);
}
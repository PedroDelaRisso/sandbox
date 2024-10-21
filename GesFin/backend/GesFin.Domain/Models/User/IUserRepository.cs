namespace GesFin.Domain.Models.User;

public interface IUserRepository
{
    Task<User> Get(long id);
    Task<List<User>> GetAll();
    Task Add(User user);
    Task Update(User user);
    Task Delete(long id);
    Task Delete(User user);
}
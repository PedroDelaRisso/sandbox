namespace GesFin.Domain.Models.User;

public class UserService(IUserRepository userRepository) : IUserService
{
    private readonly IUserRepository _userRepository = userRepository;

    public async Task Add(User user)
    {
        await _userRepository.Add(user);
    }

    public async Task Delete(long id)
    {
        await _userRepository.Delete(id);
    }

    public async Task Delete(User user)
    {
        await _userRepository.Delete(user);
    }

    public async Task<List<User>> GetAll()
    {
        return await _userRepository.GetAll();
    }

    public async Task<User> Get(long id)
    {
        return await _userRepository.Get(id);
    }

    public async Task Update(User user)
    {
        await _userRepository.Update(user);
    }
}

using GesFin.Domain.Models.Multitenancy;

namespace GesFin.Domain.Models.User;

public class User : Multitenancy<long>, IAggregateRoot
{
    public string Name { get; set; } = string.Empty;
}
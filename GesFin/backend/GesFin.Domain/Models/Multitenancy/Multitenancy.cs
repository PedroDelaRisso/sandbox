namespace GesFin.Domain.Models.Multitenancy;

public abstract class Multitenancy<TId>
{
    public string TenantId { get; set; } = string.Empty;
    public TId Id { get; set; } = default!;
}
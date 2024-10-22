namespace GesFin.Domain.Models.Multitenancy;

public interface IMultitenancyService
{
    string CurrentTenant { get; }
    void SetCurrentTenant(string tenant);
}
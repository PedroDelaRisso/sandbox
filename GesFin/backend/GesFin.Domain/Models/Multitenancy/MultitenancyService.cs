namespace GesFin.Domain.Models.Multitenancy;

public class MultitenancyService: IMultitenancyService
{
    private string _tenant = string.Empty;

    public string CurrentTenant
    {
        get => _tenant;
        private set
        {
            if (_tenant != value)
            {
                var oldTenant = _tenant;
                _tenant = value;
            }
        }
    }

    public void SetCurrentTenant(string tenant)
    {
        if (string.IsNullOrWhiteSpace(tenant))
            throw new ArgumentException("CurrentTenant cannot be null or whitespace.", nameof(tenant));
        CurrentTenant = tenant;
    }
}
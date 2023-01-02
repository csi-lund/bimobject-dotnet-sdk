using BimObject.Base.Client;

namespace BimObject.Sdk;

public class BimObjectApiSettings
{
    public ICollection<IBimObjectClient> Clients { get; }
}

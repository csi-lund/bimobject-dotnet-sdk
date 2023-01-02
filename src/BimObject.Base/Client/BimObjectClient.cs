using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BimObject.Base.Client;

public class BimObjectClient : IBimObjectClient
{
    public BimObjectClient(string clientKey, string clientToken, ClientType clientType, ReadOnlyCollection<string> redirectUris)
    {
        ClientKey = clientKey;
        ClientToken = clientToken;
        ClientType = clientType;
        RedirectUris = redirectUris;
    }

    public string ClientKey { get; set; }

    public string ClientToken { get; set; }

    public ClientType ClientType { get; set; }

    public ReadOnlyCollection<string> RedirectUris { get; set; }

    public Task Post()
    {
        throw new NotImplementedException();
    }
}

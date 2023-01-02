using BimObject.Base.Client;
using Microsoft.Extensions.DependencyInjection;

namespace BimObject.Sdk;

/// <summary>
/// 
/// </summary>
public static class BimObjectApi
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="serviceCollection"></param>
    /// <param name="customSettings"></param>
    /// <param name="retryPolicies"></param>
    /// <returns></returns>
    public static IServiceCollection UseBimObject(
        this IServiceCollection serviceCollection, 
        Action<BimObjectApiSettings, IHttpClientBuilder>? customSettings)
    {
        var settings = new BimObjectApiSettings();
        customSettings?.Invoke(settings, serviceCollection.AddHttpClient<IBimObjectClient, BimObjectClient>());

        return serviceCollection;
    }
}

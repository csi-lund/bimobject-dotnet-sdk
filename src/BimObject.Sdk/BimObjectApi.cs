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
    /// <returns></returns>
    public static IServiceCollection UseBimObject(this IServiceCollection serviceCollection, Action<BimObjectApiSettings>? customSettings)
    {
        var settings = new BimObjectApiSettings();
        customSettings?.Invoke(settings);
    }
}

public class BimObjectApiSettings
{ 
}

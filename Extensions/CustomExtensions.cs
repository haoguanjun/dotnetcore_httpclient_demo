using Polly;
using Polly.Extensions.Http;

namespace MyApp
{
    public static class CustomExtensions {
        public static IServiceCollection AddAppServices(
            this IServiceCollection serviceCollection )
        {
            // 真正注册自定义的服务
            serviceCollection.AddHttpClient<FakeApiClient>(
                // 配置 HttpClient
                (provider, client) => {
                    // 获得配置对象
                    var config = provider.GetRequiredService<IConfiguration>();
                    // 通过配置对象，获得配置参数
                    var url = config.GetValue<string>("apiServer:url");
                    client.BaseAddress = new Uri( url );
                }
            )
            .AddPolicyHandler(
                    HttpPolicyExtensions.HandleTransientHttpError()
                        .WaitAndRetryAsync(6, _ => TimeSpan.FromSeconds(5))
                    );
                    
            return serviceCollection;
        }
    }
}
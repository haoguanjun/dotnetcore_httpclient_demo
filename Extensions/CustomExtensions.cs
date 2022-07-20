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
                // 实现使用指数退避算法的 HTTP 调用重试
                // https://docs.microsoft.com/zh-cn/dotnet/architecture/microservices/implement-resilient-applications/implement-http-call-retries-exponential-backoff-polly
                HttpPolicyExtensions.HandleTransientHttpError()
                    .WaitAndRetryAsync(6, 
                        retryAttempt => TimeSpan.FromSeconds(
                            Math.Pow(2, retryAttempt))
                    )
            );
                    
                    
            return serviceCollection;
        }
    }
}
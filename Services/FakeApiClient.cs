
using MyApp;

public class FakeApiClient {
    private readonly HttpClient _client = null;
    public FakeApiClient(HttpClient client)
    {
        _client = client;
    }

    public async Task<User> GetUser(int id)
    {
        var url = $"users/{id}";

        /*
        var userJson = await _client.GetStringAsync(url);
        
        // 反序列化
        var user = System.Text.Json.JsonSerializer
                        .Deserialize<User>(userJson);
        */
        var user2 = await _client.GetFromJsonAsync<User>(url);

        return user2;
    }
}
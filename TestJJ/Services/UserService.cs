using System.Text.Json;
using TestJJ.Models;

namespace TestJJ.Services;

public class UserService
{
    private readonly HttpClient httpClient;

    public UserService()
    {
        httpClient = new HttpClient();
    }

    public async Task<List<User>> GetUsersAsync()
    {
        var response = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/users");
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<List<User>>(content, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        }) ?? [];
    }

    public async Task<User?> GetUserByIdAsync(int id)
    {
        var response = await httpClient.GetAsync($"https://jsonplaceholder.typicode.com/users/{id}");
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<User>(content, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });
    }
}


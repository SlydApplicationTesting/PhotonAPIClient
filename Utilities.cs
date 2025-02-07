using System.Net.Http.Headers;

namespace PhotonAPIClient
{
    public static class Utilities
    {
        public static void AddAuthorizationHeader(this HttpClient client, string token)
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }
    }
}
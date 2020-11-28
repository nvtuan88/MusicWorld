using Microsoft.AspNetCore.Http;


namespace MusicWorld.Infrastructure
{
    public static class UrlExtensions
    {
        public static string PathAnyQuery(this HttpRequest request) => request.QueryString.HasValue
            ? $"{request.Path}{request.QueryString}" : request.Path.ToString();

    }
}

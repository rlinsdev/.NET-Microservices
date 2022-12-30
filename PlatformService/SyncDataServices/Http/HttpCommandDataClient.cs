using PlatformService.Dtos;

namespace PlatformService.SyncDataServices.Http
{
    public class HttpCommandDataClient : ICommandDataClient
    {
        private readonly HttpClient _httpClient;

        public HttpCommandDataClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public Task SendPlatformToCommand(PlatformReadDto plat)
        {
            throw new NotImplementedException();
        }
    }
}
namespace WebAssembly.Services
{
    public class ItemService : IItemService
    {
        private readonly HttpClient _httpClient;
        public ItemService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


    }
}

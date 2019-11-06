using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Umbraco.Headless.Client.Net.Delivery;

namespace DotnetCore.Events.Demo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IHttpClientFactory _clientFactory;

        public IndexModel(ILogger<IndexModel> logger, IHttpClientFactory clientFactory)
        {
            _logger = logger;
            _clientFactory = clientFactory;
        }

        public async Task OnGet()
        {
            try
            {
                // Ugly way...
                var headlessClient = new ContentDeliveryService(new ContentDeliveryConfiguration("marcin-headless-uk-fest"));

                // Pure HttpClient way...
                var headlessHttpClient = _clientFactory.CreateClient("headless");

                var test = await headlessClient.Content.GetRoot();
                var test2 = await headlessHttpClient.GetAsync("/").ConfigureAwait(false);

                // Not yet possible...?
                //var test3 = await _contentDeliveryClient.Content.GetRoot();
            }
            catch (Exception _)
            {
            }
        }
    }
}

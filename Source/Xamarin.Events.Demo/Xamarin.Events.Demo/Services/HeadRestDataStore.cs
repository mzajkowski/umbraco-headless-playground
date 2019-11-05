using Events.Demo.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Events.Demo.Models;

namespace Xamarin.Events.Demo.Services
{
    public class HeadRestDataStore : IDataStore<Item>
    {
        EventsHeadRestClient client;
        IEnumerable<Item> items;

        public HeadRestDataStore()
        {
            client = new EventsHeadRestClient(new Uri(App.HeadRestBackendUrl));

            items = new List<Item>();
        }

        bool IsConnected => Connectivity.NetworkAccess == NetworkAccess.Internet;
        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            if (forceRefresh && IsConnected)
            {
                var events = await client.GetEvents();

                items = await Task.Run(() => events.Events.Select(x => new Item { 
                    Id = x.Id.ToString(), 
                    Text = x.Name, 
                    Description = x.Url }));
            }

            return items;
        }

        public async Task<Item> GetItemAsync(string id)
        {
            //if (id != null && IsConnected)
            //{
            //    var json = await client.GetStringAsync($"api/item/{id}");
            //    return await Task.Run(() => JsonConvert.DeserializeObject<Item>(json));
            //}

            return null;
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            if (item == null || !IsConnected)
                return false;

            //var serializedItem = JsonConvert.SerializeObject(item);

            //var response = await client.PostAsync($"api/item", new StringContent(serializedItem, Encoding.UTF8, "application/json"));

            //return response.IsSuccessStatusCode;
            return true;
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            if (item == null || item.Id == null || !IsConnected)
                return false;

            //var serializedItem = JsonConvert.SerializeObject(item);
            //var buffer = Encoding.UTF8.GetBytes(serializedItem);
            //var byteContent = new ByteArrayContent(buffer);

            //var response = await client.PutAsync(new Uri($"api/item/{item.Id}"), byteContent);

            //return response.IsSuccessStatusCode;
            return true;
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            if (string.IsNullOrEmpty(id) && !IsConnected)
                return false;

            //var response = await client.DeleteAsync($"api/item/{id}");

            //return response.IsSuccessStatusCode;
            return true;
        }
    }
}

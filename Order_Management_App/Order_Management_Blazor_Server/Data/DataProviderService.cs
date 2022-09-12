using Order_Management_Blazor_Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Xml.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.IO;
using System.Net;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Order_Management_Blazor_Server.Data
{
    public class DataProviderService
    {
        private HttpClient _client;
        private string _apiUrl;

        public DataProviderService(HttpClient client)
        {
            client.BaseAddress = new Uri("http://localhost:44365/");
            // GitHub API versioning
            client.DefaultRequestHeaders.Add("Accept",
                "application/json");
            // GitHub requires a user-agent
            client.DefaultRequestHeaders.Add("User-Agent",
                "HttpClientFactory");

            _client = client;

            _apiUrl = "/api/Suppliers";
        }

        // Document: https://docs.microsoft.com/en-us/aspnet/core/fundamentals/http-requests?view=aspnetcore-5.0
        public async Task<List<Supplier>> GetSuppliersAsync()
        {
            return await _client.GetFromJsonAsync<List<Supplier>>("/api/Suppliers");
        }

        public async Task<Supplier> GetSupplierByIdAsync(int id)
        {
            return await _client.GetFromJsonAsync<Supplier>($"/api/Suppliers/{id}");

            //Supplier supplier = null;
            //HttpResponseMessage response = _client.GetAsync($"{_apiUrl}/{id}").Result;

            //if (response.IsSuccessStatusCode)
            //{
            //    supplier = JsonConvert.DeserializeObject<Supplier>(response.Content.ReadAsStringAsync().Result);
            //}
            //return Task.FromResult(supplier);
        }

        public async Task<Supplier> CreateSupplierAsync(Supplier supplier)
        {
            HttpResponseMessage response = await _client.PostAsJsonAsync<Supplier>("/api/Suppliers/", supplier);
            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
            {
                supplier = JsonConvert.DeserializeObject<Supplier>(response.Content.ReadAsStringAsync().Result);
            }
            return supplier;
        }

        public async Task<Supplier> UpdateSupplierAsync(Supplier supplier)
        {
            HttpResponseMessage response = await _client.PutAsJsonAsync($"/api/Suppliers/{supplier.Id}", supplier);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            //supplier = await response.Content.ReadAsAsync<Supplier>();

            if (response.IsSuccessStatusCode)
            {
                supplier = JsonConvert.DeserializeObject<Supplier>(response.Content.ReadAsStringAsync().Result);
            }

            return supplier;
        }

        public async Task<HttpStatusCode> DeleteSupplierAsync(int id)
        {
            HttpResponseMessage response = await _client.DeleteAsync($"/api/Suppliers/{id}");
            return response.StatusCode;
        }

        //public List<SelectListItem> States()
        //{
        //    List<SelectListItem> states = new List<SelectListItem>();
        //    foreach (var state in NeededData.GetStates())
        //    {
        //        states.Add(new SelectListItem
        //        {
        //            Value = state,
        //            Text = state
        //        });
        //    }

        //    return states;
        //}
    }
}

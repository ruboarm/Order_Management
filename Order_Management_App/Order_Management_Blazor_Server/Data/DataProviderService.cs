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
        //public DataProviderService()
        {
            // HTTP Client use without injection
            //_client = new HttpClient();
            //_client.BaseAddress = new Uri("https://localhost:44365/");
            //_client.DefaultRequestHeaders.Add("Accept",
            //"application/json");
            //_client.DefaultRequestHeaders.Add("User-Agent",
            //    "HttpClientFactory");

            _client = client;

            _apiUrl = "/api/Suppliers";
        }

        // Document: https://docs.microsoft.com/en-us/aspnet/core/fundamentals/http-requests?view=aspnetcore-5.0
        public async Task<List<Supplier>> GetSuppliersAsync()
        {
            List<Supplier> list = null;
            try
            {
                // HTTP Client use without injection
                //var response = await _client.GetAsync(_apiUrl);
                //string responseString = await response.Content.ReadAsStringAsync();

                list = await _client.GetFromJsonAsync<List<Supplier>>(_apiUrl);
            }
            catch (Exception ex)
            {
                throw;
            }
            return list;
        }

        public async Task<Supplier> GetSupplierByIdAsync(int id)
        {
            Supplier supplier = null;
            try
            {
                // HTTP Client use without injection
                //var response = await _client.GetAsync(_apiUrl);
                //string responseString = await response.Content.ReadAsStringAsync();

                supplier = await _client.GetFromJsonAsync<Supplier>($"{_apiUrl}/{id}");
            }
            catch (Exception ex)
            {
                throw;
            }
            return supplier;
        }

        public async Task<Supplier> CreateSupplierAsync(Supplier supplier)
        {
            HttpResponseMessage response = await _client.PostAsJsonAsync<Supplier>($"{_apiUrl}", supplier);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated Supplier from the response body.
            Supplier createdSupplier = null;
            if (response.IsSuccessStatusCode)
            {
                createdSupplier = JsonConvert.DeserializeObject<Supplier>(response.Content.ReadAsStringAsync().Result);
            }
            return createdSupplier;
        }

        public async Task<Supplier> UpdateSupplierAsync(Supplier supplier)
        {
            HttpResponseMessage response = await _client.PutAsJsonAsync($"{_apiUrl}/{supplier.Id}", supplier);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated Supplier from the response body.
            Supplier updateSupplier = null;
            if (response.IsSuccessStatusCode)
            {
                updateSupplier = JsonConvert.DeserializeObject<Supplier>(response.Content.ReadAsStringAsync().Result);
            }

            return updateSupplier;
        }

        public async Task<HttpStatusCode> DeleteSupplierAsync(int id)
        {
            HttpResponseMessage response = await _client.DeleteAsync($"{_apiUrl}/{id}");
            return response.StatusCode;
        }



        public List<string> GetStates()
        {
            return new List<string>()
            {
                "Available",
                "Out of Stock"
            };
        }
    }
}

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
                //var response = await _client.GetAsync(_apiUrl);
                //string responseString = await response.Content.ReadAsStringAsync();

                list = await _client.GetFromJsonAsync<List<Supplier>>("/api/Suppliers");
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
                //var response = await _client.GetAsync(_apiUrl);
                //string responseString = await response.Content.ReadAsStringAsync();

                supplier = await _client.GetFromJsonAsync<Supplier>($"/api/Suppliers/{id}");
            }
            catch (Exception ex)
            {
                throw;
            }
            return supplier;
        }

        public async Task<List<Supplier>> CreateSupplierAsync(Supplier supplier)
        {
            HttpResponseMessage response = await _client.PostAsJsonAsync<Supplier>("/api/Suppliers/", supplier);
            response.EnsureSuccessStatusCode();

            List<Supplier> list = null;
            if (response.IsSuccessStatusCode)
            {
                list = JsonConvert.DeserializeObject<List<Supplier>>(response.Content.ReadAsStringAsync().Result);
            }
            return list;
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

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

        public DataProviderService()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("http://localhost:64195/");
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            _apiUrl = "https://localhost:44365/api/suppliers";
        }

        

        public Task<List<Supplier>> GetSuppliersAsync()
        {
            List<Supplier> suppliers = new List<Supplier>();

            HttpResponseMessage response = _client.GetAsync(_apiUrl).Result;

            if (response.IsSuccessStatusCode)
            {
                suppliers = JsonConvert.DeserializeObject<List<Supplier>>(response.Content.ReadAsStringAsync().Result);
            }

            return Task.FromResult(suppliers);
        }

        public Task<Supplier> GetSupplierByIdAsync(int id)
        {
            Supplier supplier = null;
            HttpResponseMessage response = _client.GetAsync($"{_apiUrl}/{id}").Result;

            if (response.IsSuccessStatusCode)
            {
                supplier = JsonConvert.DeserializeObject<Supplier>(response.Content.ReadAsStringAsync().Result);
            }
            return Task.FromResult(supplier);
        }

        public Task<Uri> CreateSupplierAsync(Supplier supplier)
        {
            HttpResponseMessage response = _client.PostAsJsonAsync($"{_apiUrl}/create", supplier).Result;

            if (response.IsSuccessStatusCode)
            {
                supplier = JsonConvert.DeserializeObject<Supplier>(response.Content.ReadAsStringAsync().Result);
            }
            //return Task.FromResult(supplier);

            //HttpResponseMessage response = await _client.PostAsJsonAsync("/products", supplier);
            //response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return Task.FromResult(response.Headers.Location);
        }

        public async Task<Supplier> UpdateSupplierAsync(Supplier supplier)
        {
            HttpResponseMessage response = await _client.PutAsJsonAsync($"/update/{supplier.Id}", supplier);
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
            HttpResponseMessage response = await _client.DeleteAsync($"api/suppliers/{id}");
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

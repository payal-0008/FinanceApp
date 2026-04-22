using FinanceApp.Models;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace FinanceApp.Services
{
    public class ApiService
    {
        

        //public ApiService()
        //{
        //    var handler = new HttpClientHandler();
        //    handler.ServerCertificateCustomValidationCallback =
        //        HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;

        //    _http = new HttpClient(handler)
        //    {
        //        BaseAddress = new Uri("https://localhost:7056/")
        //    };
        //}

        private readonly HttpClient _http;

        public ApiService()
        {
            _http = new HttpClient();
            _http.BaseAddress = new Uri("https://localhost:7056/");
        }


        //public ApiService()
        //{
        //    var handler = new HttpClientHandler();
        //    handler.ServerCertificateCustomValidationCallback =
        //        HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;

        //    _http = new HttpClient(handler)
        //    {
        //        // ✅ Use your PC IP for phone
        //        BaseAddress = new Uri("http://172.23.200.92:5251/")
        //    };
        //}

        public async Task<string> Register(RegisterModel model)
        {
            var json = JsonSerializer.Serialize(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
             var response =  await _http.PostAsync("api/Auth/register", content);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }

            var error = await response.Content.ReadAsStringAsync();
            throw new Exception(error);
        }

        public async Task<string?> LoginAsync(string email, string password)
        {
            var payload = JsonSerializer.Serialize(new { email, password });
            var content = new StringContent(payload, Encoding.UTF8, "application/json");

            var response = await _http.PostAsync("api/auth/login", content);
            if (!response.IsSuccessStatusCode) return null;

            var json = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<JsonElement>(json);
            return result.GetProperty("token").GetString();
        }

 
    }
}

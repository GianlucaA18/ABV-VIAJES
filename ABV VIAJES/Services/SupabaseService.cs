using ABV_VIAJES.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.Net.Http;

namespace ABV_VIAJES.Services
{
    public class SupabaseService
    {
        private readonly HttpClient _httpClient;

        public SupabaseService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<Viaje>> ObtenerViajes()
        {
            // URL de la API de Supabase
            var url = "https://khibrbpjpbpukcplwnuf.supabase.co/rest/v1/viajes?select=*"; // Reemplaza con tu URL de Supabase

            // Headers: apikey y Authorization
            _httpClient.DefaultRequestHeaders.Add("apikey", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImtoaWJyYnBqcGJwdWtjcGx3bnVmIiwicm9sZSI6InNlcnZpY2Vfcm9sZSIsImlhdCI6MTcyODc0OTIwMCwiZXhwIjoyMDQ0MzI1MjAwfQ.z0jp3HEGE53wwaIm_KVdOh7bO135AsnZvmOMv87im-o"); // Reemplaza con tu API Key de Supabase
            _httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImtoaWJyYnBqcGJwdWtjcGx3bnVmIiwicm9sZSI6InNlcnZpY2Vfcm9sZSIsImlhdCI6MTcyODc0OTIwMCwiZXhwIjoyMDQ0MzI1MjAwfQ.z0jp3HEGE53wwaIm_KVdOh7bO135AsnZvmOMv87im-o"); // Reemplaza con tu token de autorización

            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var jsonContent = await response.Content.ReadAsStringAsync();
                var viajes = JsonConvert.DeserializeObject<List<Viaje>>(jsonContent);
                return viajes;
            }

            // Retornar una lista vacía si no hay éxito en la solicitud
            return new List<Viaje>();
        }
    }
}

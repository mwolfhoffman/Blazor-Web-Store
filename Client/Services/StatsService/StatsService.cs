using System;
using Blazored.LocalStorage;

namespace BlazingShop.Client.Services.StatsService
{
    public class StatsService : IStatsService
    {
        private readonly HttpClient _http;
        private readonly ILocalStorageService _localStorageService;

        public StatsService(HttpClient http, ILocalStorageService localStorageService)
        {
            _http = http;
            _localStorageService = localStorageService;
        }

        public async Task GetVisits()
        {
            int visits = int.Parse(await _http.GetStringAsync("api/Stats"));
        }

        public async Task IncrementVisits()
        {
           
            DateTime? lastVisit = await _localStorageService.GetItemAsync<DateTime>("lastVisit");
            if(lastVisit == null || ((DateTime)lastVisit).Date != DateTime.Now.Date)
            {
                await _localStorageService.SetItemAsync("lastVisit", DateTime.Now);
                await _http.PostAsync("api/Stats", null);
            }
        }
    }
}


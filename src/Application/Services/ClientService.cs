using eSupport.Application.Models;
using eSupport.Application.Infrastructure;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using eSupport.Application.ViewModels;

namespace eSupport.Application.Services
{
    public class ClientService : IClientService
    {
        private readonly IOptionsSnapshot<AppSettings> _settings;
        // private IHttpClient _apiClient;
        private readonly string _remoteServiceBaseUrl;
        public ClientService(IOptionsSnapshot<AppSettings> settings, IHttpContextAccessor httpContextAccesor, IHttpClient httpClient)
        {
            _settings = settings;
            _remoteServiceBaseUrl = $"{_settings.Value.ClientUrl}/api/v1/client";
            _httpContextAccesor = httpContextAccesor;
            // _apiClient = httpClient;
        }
        private IHttpContextAccessor _httpContextAccesor;

        public async Task<Client> GetClient()
        {
            return 1;
        }

        public async Task AddClient()
        {
            return 1;
        }

        public async Task<Client> ModifyClient()
        {
            return 1;
        }

        public async Task<Client> GetAllClients(int pageSize, int pageIndex)
        {
            return 1;
        }
    }
}
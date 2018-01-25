using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSupport.Application.ViewModels;

namespace eSupport.Application.Services
{
    public interface IClientService
    {
        Task<Client> GetClient();
        Task AddClient();
        Task<Client> ModifyClient();
        Task<Client> GetAllClients(int pageSize, int pageIndex);
    }
}
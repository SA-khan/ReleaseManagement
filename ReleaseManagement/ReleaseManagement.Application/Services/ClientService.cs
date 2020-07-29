using ReleaseManagement.Application.Interfaces;
using ReleaseManagement.Application.ViewModels;
using ReleaseManagement.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReleaseManagement.Application.Services
{
    public class ClientService : IClientService
    {
        private IClientRepository _clientRepository;
        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public ClientViewModel GetClients()
        {
            return new ClientViewModel()
            {
                Clients = _clientRepository.GetClients()
            };
        }

    }
}

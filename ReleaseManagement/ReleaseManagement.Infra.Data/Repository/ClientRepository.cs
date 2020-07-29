using ReleaseManagement.Domain.Interfaces;
using ReleaseManagement.Domain.Models;
using ReleaseManagement.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReleaseManagement.Infra.Data.Repository
{
    public class ClientRepository : IClientRepository
    {
        private ReleaseManagementDBContext _ctx;
        public ClientRepository(ReleaseManagementDBContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Client> GetClients()
        {
            return _ctx.Clients;
        }
    }
}

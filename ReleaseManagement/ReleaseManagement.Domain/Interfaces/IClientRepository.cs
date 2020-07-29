using ReleaseManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReleaseManagement.Domain.Interfaces
{
    public interface IClientRepository
    {
        IEnumerable<Client> GetClients();
    }
}

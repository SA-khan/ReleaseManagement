using ReleaseManagement.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReleaseManagement.Application.Interfaces
{
    public interface IClientService
    {
        ClientViewModel GetClients();
    }
}

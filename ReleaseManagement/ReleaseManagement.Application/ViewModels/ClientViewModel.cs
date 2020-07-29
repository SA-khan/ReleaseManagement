using ReleaseManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReleaseManagement.Application.ViewModels
{
    public class ClientViewModel
    {
        public IEnumerable<Client> Clients { get; set; }
    }
}

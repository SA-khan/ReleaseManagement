using System;
using System.Collections.Generic;
using System.Text;

namespace ReleaseManagement.Domain.Models
{
    class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
    }
}

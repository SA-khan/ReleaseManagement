using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorld.App_Code
{
    public class Patch
    {
        public string clientName { get; set; }
        public string clientType { get; set; }
        public string clientEnvType { get; set; }
        public string clientAppLink { get; set; }
        public string clientPOCName { get; set; }
        public string numberOfPatches { get; set; }
        public string patchHotNumber { get; set; }
        public string patchQATested { get; set; }
        public string patchDeployedBy { get; set; }
        public string patchCreatedDate { get; set; }
        public string patchDeployedDate { get; set; }
        public string patchProductID { get; set; }
        public string patchNumberOfDaysPassed { get; set; }
        public string patchWorkingDirectory { get; set; }
        public string patchStatus { get; set; }
    }
}
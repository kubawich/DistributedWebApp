using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DistributedWebAppUsersService.Models
{
    public struct DeviceInfoModel
    {
        public DateTime LastLogin { get; set; }
        public List<string> DevicesIP { get; set; }
        public List<string> Positions { get; set; }
        public List<string> BrowsersInfo { get; set; }
        public List<string> OperatingSystems { get; set; }
        public List<string> DevicesInfo { get; set; }
    }
}

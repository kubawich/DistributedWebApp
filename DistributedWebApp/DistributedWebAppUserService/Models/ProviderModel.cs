using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Both posts and offers belongs to Orders sevice so they'll be links to OrdersServiceAPI rather than to coresponding data model in this sevice
namespace DistributedWebAppUsersService.Models
{
    public struct ProviderModel
    {
        public string Description { get; set; }
        public List<Uri> Posts { get; set; }
        public List<Uri> Offers { get; set; }
#nullable enable
        public string? CompanyName { get; set; }
        public Uri? CompnyImage { get; set; }
#nullable disable
    }
}

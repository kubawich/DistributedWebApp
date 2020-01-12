namespace DistributedWebAppUsersService.Models
{
    public struct LocationDataModel
    {
        public string Nationality { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
#nullable enable
        public string? District { get; set; }
        public string? Street { get; set; }
        public string? StreetNumber { get; set; }
#nullable disable
    }
}
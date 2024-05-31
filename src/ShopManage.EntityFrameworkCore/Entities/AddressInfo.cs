using System;
using Volo.Abp.Domain.Entities;

namespace ShopManage.EntityFrameworkCore.Entities
{
    public class AddressInfo : BasicAggregateRoot<Guid>
    {
        public string? Address { get; set; }

        public string? Detail { get; set; }

        public string? TelName { get; set; }

        public string? TelPhone { get; set; }

        public int? Type { get; set; }

        public string? Description { get; set; }

        public Guid? UserId { get; set; }

        public Guid? MarketId { get; set; }
    }
}

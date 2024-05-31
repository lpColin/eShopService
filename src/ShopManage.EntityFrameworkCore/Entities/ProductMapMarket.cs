using System;
using Volo.Abp.Domain.Entities;

namespace ShopManage.EntityFrameworkCore.Entities
{
    public class ProductMapMarket : BasicAggregateRoot<Guid>
    {
        public Guid? MarketId { get; set; }

        public Guid? ProductId { get; set; }
    }
}

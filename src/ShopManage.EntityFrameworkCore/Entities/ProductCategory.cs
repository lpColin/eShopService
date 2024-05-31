using System;
using Volo.Abp.Domain.Entities;

namespace ShopManage.EntityFrameworkCore.Entities
{
    public class ProductCategory : BasicAggregateRoot<Guid>
    {
        public string? Name { get; set; }

        public string? IconUrl { get; set; }

        public string? Tag { get; set; }

        public string? Description { get; set; }

        public int? Type { get; set; }
    }
}

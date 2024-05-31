using System;
using Volo.Abp.Domain.Entities;

namespace ShopManage.EntityFrameworkCore.Entities
{
    public class ProductSnap : BasicAggregateRoot<Guid>
    {
        public Guid? ProductId { get; set; }

        public string? Title { get; set; }

        public string? Name { get; set; }

        public string? IconUrl { get; set; }

        public string[]? ImgUrls { get; set; }

        public string? Description { get; set; }

        public decimal Price { get; set; }

        public int TotalNum { get; set; }

        public string? Tags { get; set; }

        public Guid? OrderId { get; set; }
    }
}

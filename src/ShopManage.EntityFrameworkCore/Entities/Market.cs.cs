using System;
using Volo.Abp.Domain.Entities;

namespace ShopManage.EntityFrameworkCore.Entities
{
    public class Market : BasicAggregateRoot<Guid>
    {
        public string? Title { get; set; }

        public string? Name { get; set; }

        public string? IconUrl { get; set; }

        public string? ImgUrls { get; set; }

        public string? Notice { get; set; }

        public string? Description { get; set; }

        public int? Type { get; set; }
    }
}

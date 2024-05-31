using System;
using Volo.Abp.Domain.Entities;

namespace ShopManage.EntityFrameworkCore.Entities
{
    public class Product : BasicAggregateRoot<Guid>
    {
        public string? Title { get; set; }

        public string? Name { get; set; }

        public string? IconUrl { get; set; }

        public string[]? ImgUrls { get; set; }

        public string? Description { get; set; }

        public decimal Price { get; set; }

        public decimal OriginalPrice { get; set; }

        public float Discount { get; set; }

        /// <summary>
        /// 库存
        /// </summary>
        public int Stock { get; set; }

        public string? Tags { get; set; }

        public Guid? ProductCategoryId { get; set; }
    }
}

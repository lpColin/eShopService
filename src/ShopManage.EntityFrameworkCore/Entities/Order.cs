using System;
using Volo.Abp.Domain.Entities;

namespace ShopManage.EntityFrameworkCore.Entities
{
    public class Order : BasicAggregateRoot<Guid>
    {
        public Guid? AddressInfoId { get; set; }

        public Guid? MarketId { get; set; }

        public Guid? UserId { get; set; }

        public decimal Price { get; set; }

        public int TotalNum { get; set; }

        public int? Status { get; set; }

        public string? Remark { get; set; }

        /// <summary>
        /// 快送类型
        /// </summary>
        public int? DeliveryType { get; set; }

        public string? AddressInfo { get; set; }       

    }
}

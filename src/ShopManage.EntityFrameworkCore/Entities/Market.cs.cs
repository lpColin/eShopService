using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace ShopManage.EntityFrameworkCore.Entities
{
    public class Market : BasicAggregateRoot<Guid>
    {
        /// <summary>
        /// 标提
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        public string IconUrl { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        public string[] ImgUrls { get; set; }
    }
}

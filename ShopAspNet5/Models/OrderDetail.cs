using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAspNet5.Models
{
    public class OrderDetail {

        public int id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int orderID { get; set; }

        public int CarID { get; set; }

        public uint price { get; set; }

        public virtual Car car { get; set; }

        public virtual Order order { get; set; }

    }
}

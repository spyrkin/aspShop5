namespace ShopAspNet5.Models
{
    public class OrderModel
    {
        public int id { get; set; }
        public string userName { get; set; } // имя покупателя
        public string address { get; set; } // адрес покупателя
        public string email { get; set; } // email покупателя

        public int tvID { get; set; } // ссылка на связанную модель TVModel
        public TVModel tv { get; set; } // Ссылка на весь объект (телевизор)
    }
}

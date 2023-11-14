﻿using BurgerShop.Entities.Abstract;

namespace BurgerShop.Entities.Concrete
{
    public class Extra : BaseEntity, IEntity<int>
    {
        public int Id { get; set; }
        public string ExtraName { get; set; }
        public string? ExtraImageUrl { get; set; }
        private decimal _extraPrice;

        public decimal ExtraPrice
        {
            get { return _extraPrice; }
            set { _extraPrice = (value < 0) ? 0 : value; }
        }
        public Guid? OrderDetailId { get; set; }

        //Navigation Property
        public OrderDetail? OrderDetail { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMicro.Services.Order.Domain.OrderAggregate;

namespace UMicro.Services.Order.Application.Dtos
{
    public class OrderDto
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get;  set; }
        public AddressDto Address { get;  set; }
        public string BuyerId { get;  set; }//userid
        private List<OrderItemDto> OrderItems { get; set; }
    }
}

﻿using System.ComponentModel.DataAnnotations;

namespace FastFood.Core.ViewModels.Orders
{
    public class CreateOrderInputModel
    {
        [Required]
        public string Customer { get; set; }

        public int ItemId { get; set; }

        public int EmployeeId { get; set; }


        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }
    }
}

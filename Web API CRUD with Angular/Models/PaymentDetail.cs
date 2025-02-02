﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_API_CRUD_with_Angular.Models
{
    public class PaymentDetail
    {
        [Key]
        public int PaymentDetailID { get; set; }
        [Column(TypeName= "varchar(100)")]
        public string CardOwnerName { get; set; } = "";
        [Column(TypeName = "varchar(16)")]
        public string CardNumber { get; set; } = "";
        [Column(TypeName = "varchar(5)")]
        public string ExpirationDate { get; set; } = "";
        [Column(TypeName = "varchar(3)")]
        public string SecurityCode { get; set; } = "";
    }
}

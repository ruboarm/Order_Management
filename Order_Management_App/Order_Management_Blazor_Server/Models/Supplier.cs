using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Order_Management_Blazor_Server.Data;

namespace Order_Management_Blazor_Server.Models
{
    public class Supplier
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string SupplierName { get; set; }

        [Required]
        public string AddressLine1 { get; set; }

        [Required]
        public string AddressLine2 { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public int PostalCode { get; set; }

        [Required]
        public string State { get; set; } = Lists.GetStates()[0];
    }
}

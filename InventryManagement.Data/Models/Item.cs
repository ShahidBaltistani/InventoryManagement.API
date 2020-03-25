using System;
using System.Collections.Generic;
using System.Text;

namespace InventryManagement.Data.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }


    }
}

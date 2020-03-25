using InventryManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventryManagement.ViewModel.ViewModels
{
   public class UserViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int? ItemId { get; set; }
        public virtual List<Item> Item { get; set; }

    }
}

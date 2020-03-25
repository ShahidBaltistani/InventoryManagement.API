using InventryManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventryManagement.ViewModel.ViewModels
{
   public class ItemViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public  string   UserName { get; set; }
        public  string CategoryName { get; set; }
    }
}


using System;
using System.Collections.Generic;
using System.Text;

namespace InventryManagement.Data.Models
{
   public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[]  PassworHash { get; set; }
        public byte[] PassworSalt { get; set; }

    }
}
        
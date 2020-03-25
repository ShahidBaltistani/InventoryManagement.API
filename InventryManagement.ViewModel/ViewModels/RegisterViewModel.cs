using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InventryManagement.ViewModel.ViewModels
{
   public class RegisterViewModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(8,MinimumLength =4, ErrorMessage ="Must be b/w 4 to 8")]
        public string Password { get; set; }

    }
}

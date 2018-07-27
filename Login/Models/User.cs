
using System;
using System.ComponentModel.DataAnnotations;
namespace Login.Models{
        public class User
    {
        [Key]
        public int idUser { get; set; }
        [Required(ErrorMessage="*first name is required")]
        [MinLength(2, ErrorMessage="*first name must be at least 2 characters")]
        public string firstname{ get; set; }
        
        [Required(ErrorMessage="*last name is required")]
        [MinLength(2,ErrorMessage="*last name must be at least 2 characters")]
        public string lastname{ get; set; }

        [Required(ErrorMessage="*email is required")]
        [EmailAddress(ErrorMessage = "*not a valid email address")]
        public string email{get; set;}

        [Required(ErrorMessage="*password is required")]
        [MinLength(8,ErrorMessage="*password must be at least 8 characters")]
        public string password { get; set; }

        [Compare("password",ErrorMessage="password must match")]
        public string confirm_password {get;set;}

    }





}

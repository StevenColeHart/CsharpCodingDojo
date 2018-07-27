using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Login.Models
{
    public class Activity
    {

        public int ActivityId { get; set; }

        [Required(ErrorMessage="required")]
        public User coordinator { get; set; }
        
        [Required(ErrorMessage="required")]
        public string activity { get; set; }

        [Required(ErrorMessage="Date required!")]
    
        public DateTime? Date { get; set; }

        public List<RSVP> RSVPS { get; set; }
        public Wedding()
        {
            RSVPS = new List<RSVP>();
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Date < DateTime.Now)
            {
                yield return new ValidationResult(
                    "Date must be in the future!"
                    );
            }
        }
    }





}
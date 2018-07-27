
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace beltexam.Models{
        public class Post
    {

        [Key]
        public int id { get; set; }

        public User creator{ get; set;}

        [Required (ErrorMessage = "new post required")]
        [MinLength(4, ErrorMessage="Idea must be at least 4 characters")]
        public string text{ get; set;}

        public DateTime created_at {get; set;}

        public DateTime updated_at {get; set;}

        public List<Like> likes {get; set;}

        public Post(){
            likes = new List<Like>();

        }



        
 

    }





}

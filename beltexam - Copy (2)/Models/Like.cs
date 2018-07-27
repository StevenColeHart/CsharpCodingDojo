using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace beltexam.Models
{
    public class Like
    {
        public int Likeid {get; set;}
        public User user {get;set;}
        public Post post {get;set;}

        public Like(){
        }

        public Like(User user, Post post){
            this.user = user;
            this.post = post;
        }
        
    }
}
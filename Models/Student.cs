﻿using System.ComponentModel.DataAnnotations;

namespace StudentCruds.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string StudentName  { get; set; } 
        public string Course { get; set; }

    }
}

﻿namespace HW.MentorApp.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }
    }
}

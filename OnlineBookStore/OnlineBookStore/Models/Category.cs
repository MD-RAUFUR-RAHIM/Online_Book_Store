﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OnlineBookStore.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [Range(1, 100, ErrorMessage = "Display Order Must be from 1 to 100")]
        [DisplayName("Display Order")]
        public int  DisplayOrder { get; set; }
    }
}

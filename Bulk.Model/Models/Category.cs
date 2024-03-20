﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bulk.Model.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Category Name")]
        [MaxLength(30)]
        public required string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage ="Display order must be between 1-100")]
        public int DisplayOrder { get; set; }
    }
}
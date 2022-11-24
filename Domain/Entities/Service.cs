﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Service
    {
		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(500)]
		public string Name { get; set; }

		[Required]
		public int CategoryId { get; set; }

		[ForeignKey("CategoryId")]
		public Category Category { get; set; }

		[Required]
		[MaxLength(1000)]
		public string KeyWords { get; set; }

		[Required]
		[MaxLength(1200)]
		public string Description { get; set; }
		[Required]
		[MaxLength(200)]
		public string MainImage { get; set; }
		public ICollection<Package> Packages { get; set; }

		[Required]
		public int FreelancerId { get; set; }

		[ForeignKey("FreelancerId")]
		public Freelancer Freelancer { get; set; }

	}
}

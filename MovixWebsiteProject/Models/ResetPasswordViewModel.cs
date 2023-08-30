﻿using System.ComponentModel.DataAnnotations;

namespace MovixWebsiteProject.Models
{
	public class ResetPasswordViewModel
	{
		public Guid UserId { get; set; }
		[Required]
		[StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
		[DataType(DataType.Password)]
		[Display(Name = "Password")]
		public string Password { get; set; }
		[Required]
		[DataType(DataType.Password)]
		[Compare("Password", ErrorMessage = "Must be same as password")]
		public string? ConfirmPassword { get; set; }
		[Required]
		public string? Code { get; set; }
	}
}

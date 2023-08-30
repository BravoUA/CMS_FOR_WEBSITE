using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CMS_FOR_WEBSITE.Models
{
	
	public class Users
	{
		public string Email { get; set; }
		public string Password { get; set; }
		public int Admin { get; set; }
		[Key]
		public int id { get; set; }

	}
}

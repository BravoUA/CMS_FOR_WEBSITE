using System.ComponentModel.DataAnnotations;

namespace CMS_FOR_WEBSITE.Models
{
	public class Salt
	{
		public string SaltPassword { get; set; }
		public string SaltEmail { get; set; }
		[Key]
        public int idSalt { get; set; }

	}
}

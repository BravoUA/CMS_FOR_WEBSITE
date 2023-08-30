using System.ComponentModel.DataAnnotations;

namespace CMS_FOR_WEBSITE.Models
{
    public class FildType
    {
        public string FildTypeName { get; set; }
        [Key]
        public int id { get; set; }
    }
}

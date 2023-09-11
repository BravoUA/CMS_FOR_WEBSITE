using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_FOR_WEBSITE.Models
{
    class NameofFirm
    {
        public string Name { get; set; }
        
        public int ID { get; set; }
        public int idBrand { get; set; }
    }
}

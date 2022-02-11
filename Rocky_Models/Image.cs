using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocky_Models
{
    public class Image
    {
        [Key]
        public int Id { get; set; }
        public byte[] Images { get; set; }
        public string Extension { get; set; }
    }
}

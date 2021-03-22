using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Messaging.Models
{
    public class TextMessage
    {
        [Required]
        [StringLength(10,MinimumLength=10, ErrorMessage="Number must be 10 digtis minimum")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Number must be 10 digtis minimum")]
        [DisplayName("To")]
        public string ToNumber { get; set; }
        [Required]
        [StringLength(140, ErrorMessage = "140 character max")]
        [DisplayName("Message")]
        public string Message { get; set; }


    }
}

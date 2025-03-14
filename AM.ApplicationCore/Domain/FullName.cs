using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AM.ApplicationCore.Domain
{
    [Owned]
    public class FullName
    {
        [MaxLength(25, ErrorMessage = "longeur maximale est 25")]
        [MinLength(3, ErrorMessage = "longeur maximale est 3")]
        public String FirstName { get; set; }
        [MaxLength(25, ErrorMessage = "longeur maximale est 25")]
        [MinLength(3, ErrorMessage = "longeur maximale est 3")]
        public String LastName { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagmentRefactored.Entites
{
    internal class kitchen
    {
        [Key]
        [MaxLength(50)]
        public string user_name { get; set; }

        [MaxLength(50)]
        public string pass_word { get; set; }
    }
}

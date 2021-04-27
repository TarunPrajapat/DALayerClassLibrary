using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALayer
{
    class UserId
    {
        [Key]
        public int Id { get; set; }
        [Range(100000,999999)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Userid { get; set; }

        [Required]
        public string Username { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TerminalAPI.Models
{
    public class Passenger
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Passenger_Id { get; set; }
        public string Passenger_Name { get; set; }
        public string Passenger_Phone { get; set; }
        public string Passenger_Email { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TerminalAPI.Models
{
    public abstract class TravelCard
    {
        [Key]
        public long Card_Id { get; set; }
        public double Card_Balance { get; set; }
        public string Card_Issue_Date { get; set; }
    }
}

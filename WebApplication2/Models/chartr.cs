using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class chartr
    {
        [Key]
        public int ID { get; set; }
        public string TheColorr { get; set; }
        public int data { get; set; }
       
    }
}

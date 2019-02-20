using System;
using System.Collections.Generic;
using System.Text;

namespace dbmasteraapp.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DateInclusion { get; set; }
        public DateTime DateChange { get; set; }
        public string Category { get; set; }
        public bool Closed { get; set; }
        public int Status { get; set; }
    }
}

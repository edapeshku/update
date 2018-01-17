using System;

namespace eSupport.Services.Ticket.API.Model
{
    public class Ticket
    {
        public int Id { get; set; }

        public string TicketNumber { get; set; }

        public string Description { get; set; }

        public bool Active { get; set; }

        public DateTime CreatedAt { get; set; }

        public int CreatedBy { get; set; }

        public bool IsSolved { get; set; }
    }
}
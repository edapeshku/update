using System;

namespace eSupport.Services.Ticket.API.Model
{
    public class Priority
    {
        public int Id { get; set; }

        public string PriorityName { get; set; }

        public int Level { get; set; }

        public bool Active { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public int UpdatedBy { get; set; }

        public DateTime UpdatedAt { get; set; }

        public int DeletedBy { get; set; }

        public DateTime DeletedAt { get; set; }
    }
}
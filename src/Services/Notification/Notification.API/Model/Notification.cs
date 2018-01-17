using System;

namespace eSupport.Services.Notification.API.Model
{
    public class Notification
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public bool IsViewed { get; set; }

        public DateTime ViewedAt { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
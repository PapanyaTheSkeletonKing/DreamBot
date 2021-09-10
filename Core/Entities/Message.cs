using System;
using Core.Interfaces;

namespace Core.Entities
{
    public class Reminder : IEntity<int>
    {
        public int Id { get; set; }
        
        public int UserId { get; set; }
        
        public DateTime NotificationTime { get; set; }
    }
}
using System;

namespace Charity.Data
{
    public class ActivitiesExecution
    {
        public int Id { get; set; }
        public int ActivityId { get; set; }
        public virtual Activities Activities { get; set; }
        public int UserId { get; set; }
        public virtual Users Users { get; set; }
        public DateTime SignedOn { get; set; }
    }
}

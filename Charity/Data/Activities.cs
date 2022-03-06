using System;
using System.Collections.Generic;

namespace Charity.Data
{
    public class Activities
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public char Location  { get; set; }
        public string Description { get; set; }
        public int OrganiserId { get; set; }
        public virtual Users Users { get; set; }
        public int InterestCount { get; set; }
        public int ParticipantsCount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public CategoryType Category { get; set; }
        public virtual ICollection<ActivitiesExecution> ActivitiesExecution { get; set; }

    }
}

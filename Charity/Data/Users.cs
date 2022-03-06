using System.Collections.Generic;

namespace Charity.Data
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Familname { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public char Phonenumber { get; set; }
        public RoleType Role { get; set; }
        public virtual ICollection<ActivitiesExecution> ActivitiesExecution { get; set; }
    }
}

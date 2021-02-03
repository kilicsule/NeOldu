using System.Collections.Generic;

namespace Neoldu.Data.Domain.Entities
{
    public class DeathDate : BaseGuidEntity
    {
        public DeathDate()
        {
            Peoples = new HashSet<People>();
        }
        public int Year { get; set; }
        public virtual ICollection<People> Peoples{ get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCepam.Domain
{
    public class Poll : BaseEntity, IPoll
    {

        public string Question { get; set; }


        public ICollection<PollOption> Options { get; set; }
    }
}

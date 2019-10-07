using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCepam.Domain
{
    public class PollOption : BaseEntity, IPollOption
    {
        public string Value { get; set; }

        public int Votes { get; set; }

        public ICollection<Poll> Polls { get; set; }
    }
}

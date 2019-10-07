using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCepam.Domain
{
    public interface IPoll
    {
        string Question { get; set; }

        ICollection<PollOption> Options { get; set; }
    }
}

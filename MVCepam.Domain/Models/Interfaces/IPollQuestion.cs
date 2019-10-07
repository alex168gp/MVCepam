using System.Collections.Generic;

namespace MVCepam.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public interface IPollOption
    {
        /// <summary>
        /// 
        /// </summary>
        string Value { get; set; }

        int Votes { get; set; }

        ICollection<Poll> Polls { get; set; }
    }
}

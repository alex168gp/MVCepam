using System.Collections.Generic;

namespace MVCepam.Domain
{
    /// <summary>
    /// A model for some questionnaire
    /// </summary>
    interface IQuestionnaire
    {
        /// <summary>
        /// A question
        /// </summary>
        string Question { get; set; }

        /// <summary>
        /// 
        /// </summary>
        List<string> Options { get; set; }

        /// <summary>
        /// A type of options
        /// </summary>
        string Type { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace twright_FinancialAPI.Models
{
    /// <summary>
    /// The class that is used for holding Household data from SQL
    /// </summary>
    public class Household
    {
        /// <summary>
        /// Primary Key of Household
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the Household
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Greeting of the Household
        /// </summary>
        public string Greeting { get; set; }

        /// <summary>
        /// When household was create
        /// </summary>
        public DateTime Established { get; set; }



        
    }
}
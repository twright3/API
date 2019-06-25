using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace twright_FinancialAPI.Models
{
    /// <summary>
    /// Household Budget(s)
    /// </summary>
    public class Budget
    {
        /// <summary>
        /// Budget ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Household ID
        /// </summary>
        public int HouseholdId { get; set; }

        /// <summary>
        /// Budget Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Budget Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Budget Target Amount
        /// </summary>
        public decimal TargetAmount { get; set; }
    }
}
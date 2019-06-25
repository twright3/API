using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using twright_FinancialAPI.Enumerations;

namespace twright_FinancialAPI.Models
{
    /// <summary>
    /// Bank Accounts
    /// </summary>
    public class Accounts
    {
        /// <summary>
        /// Bank Account ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Household ID
        /// </summary>
        public int HouseholdId { get; set; }

        /// <summary>
        /// Household Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Date Account Is Opened
        /// </summary>
        public DateTime Opened { get; set; }

        /// <summary>
        /// Account Type
        /// </summary>
        public AccountType AccountType { get; set; }

        /// <summary>
        /// Starting Balance of Account
        /// </summary>
        public decimal StartingBalance { get; set; }

        /// <summary>
        /// Current Balance of Account
        /// </summary>
        public decimal CurrentBalance { get; set; }

        /// <summary>
        /// Low Balance Warning Level
        /// </summary>
        public decimal LowBalanceLevel { get; set; }
    }
}
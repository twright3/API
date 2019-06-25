using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace twright_FinancialAPI.Enumerations
{
    /// <summary>
    /// Consumer is able to select the type of the account.
    /// </summary>
    public enum AccountType
    {
        /// <summary>
        /// Checking
        /// </summary>
        Checking,
        /// <summary>
        /// Savings
        /// </summary>
        Savings,
        /// <summary>
        /// Money Market
        /// </summary>
        Moneymarket,
        /// <summary>
        /// Credit
        /// </summary>
        Credit
    }
}
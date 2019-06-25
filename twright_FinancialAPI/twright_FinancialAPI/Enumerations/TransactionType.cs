using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace twright_FinancialAPI.Enumerations
{
    /// <summary>
    /// Consumer is able to select the type of transaction
    /// </summary>
    public enum TransactionType
    {
        /// <summary>
        /// Deposit
        /// </summary>
        Deposit,
        /// <summary>
        /// Withdrawal
        /// </summary>
        Withdrawal,
        /// <summary>
        /// Adjustment Up
        /// </summary>
        [Display(Name = "Adjustment Up")]
        AdjustmentUp,
        /// <summary>
        /// Adjustment Down
        /// </summary>
        [Display(Name = "Adjustment Down")]
        Adjustmentdown,
        /// <summary>
        /// Reconciliation
        /// </summary>
        Reconciliation
    }
}
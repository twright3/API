using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using twright_FinancialAPI.Enumerations;

namespace twright_FinancialAPI.Models
{
    /// <summary>
    /// Bank Account Transaction(s)
    /// </summary>
    public class Transactions
    {
        /// <summary>
        /// Transaction ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Bank Account ID
        /// </summary>
        public int BankAccountId { get; set; }

        /// <summary>
        /// Budget Category Item ID
        /// </summary>
        public int? BudgetCategoryItemId { get; set; }

        /// <summary>
        /// Transaction Amount
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Transaction Type
        /// </summary>
        public TransactionType TransactionType { get; set; }

        /// <summary>
        /// Payee for Transaction
        /// </summary>
        public string Payee { get; set; }

        /// <summary>
        /// Transaction Memo
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// When Transaction Was Entered 
        /// </summary>
        public DateTime Entered { get; set; }

        /// <summary>
        /// When Transaction Was Reconciled
        /// </summary>
        public bool Reconciled { get; set; }

        /// <summary>
        /// When Transaction Was Reconciled 
        /// </summary>
        public DateTime? ReconciledDate { get; set; }

        /// <summary>
        /// Transaction Reconciled Amount
        /// </summary>
        public decimal ReconciledAmount { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace twright_FinancialAPI.Models
{
    /// <summary>
    /// Budget Category Item(s)
    /// </summary>
    public class BudgetCategoryItem
    {
        /// <summary>
        /// Budget Cat Item ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Budget Category ID
        /// </summary>
        public int BudgetCategoryId { get; set; }

        /// <summary>
        /// Budget Category Item Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Budget Caterory Item Description
        /// </summary>
        public string Description { get; set; }

        
    }
}
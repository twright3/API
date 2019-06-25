using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using twright_FinancialAPI.Models;

namespace twright_FinancialAPI.Controllers
{
    /// <summary>
    /// This endpoint allows a consumer to work with the Financial Portal
    /// </summary>
    [RoutePrefix("api/Household")]
    public class HouseHoldsController : ApiController
    {

        private TwrightDbContext db = new TwrightDbContext();

        /// <summary>
        /// This endpoint allows a consumer to retrieve Household info by Id
        /// </summary>
        /// <remarks>
        /// Remarks go here...
        /// </remarks>
        /// <param name="id">Primary Key of the Household</param>
        /// <returns>Type Household</returns>
        [Route("GetData")]
        public async Task<Household> GetHouseholdData(int id)
        {
            var myHouseData = await db.GetHouseholdData(id);
            return myHouseData;
        }

        /// <summary>
        /// This endpoint allows a consumer to retrieve Budget info by Id
        /// </summary>
        /// <param name="id">Get Budgets by Household Id</param>
        /// <returns>Type Household Budget</returns>
        [Route("GetBudgets")]
        public async Task<List<Budget>> GetHouseholdBudgets(int id)
        {
            var budgets = await db.GetHouseholdBudgets(id);
                return budgets;
        }

        /// <summary>
        /// This endpoint allows a consumer to retrieve Budget Details info by Id
        /// </summary>
        /// <param name="id">Get Budget Details by Id</param>
        /// <returns>Type Budget Details</returns>
        [Route("GetBudgetDetails")]
        public async Task<Budget> GetBudgetDetailsData(int id)
        {
            var myBudgetDetailsData = await db.GetBudgetDetailsData(id);
            return myBudgetDetailsData;
        }

        /// <summary>
        /// This endpoint allows a consumer to retrieve Budget Catergory by Id
        /// </summary>
        /// <param name="id">Get Budget Catergories by Budget Id</param>
        /// <returns>Type Budget Category Items</returns>
        [Route("GetCategories")]
        public async Task<List<BudgetCategoryItem>> GetBudgetsItemsData(int id)
        {
            var myBudgetItemsData = await db.GetBudgetsItemsData(id);
            return myBudgetItemsData;
        }

        /// <summary>
        /// This endpoint allows a consumer to retrieve Budget Catergory Details info by Id
        /// </summary>
        /// <param name="id">Get Budget Catergory Details by Budget Id</param>
        /// <returns>Type Budget Category Items Details</returns>
        [Route("GetCategoryDetails")]
        public async Task<BudgetCategoryItem> GetCategoryDetailsData(int id)
        {
            var myBudgetDetailsData = await db.GetCategoryDetailsData(id);
            return myBudgetDetailsData;
        }

        /// <summary>
        /// This endpoint allows a consumer to retrieve Bank Account info by Id
        /// </summary>
        /// <param name="id">Get Account by House Id</param>
        /// <returns>Tpye Account</returns>
        [Route("GetAccounts")]
        public async Task<List<Accounts>> GetAccountsData(int id)
        {
            var myAccountsData = await db.GetAccountsData(id);
            return myAccountsData;
        }

        /// <summary>
        /// This endpoint allows a consumer to retrieve Account Details by Id
        /// </summary>
        /// <param name="id">Get Account Details by Account Id</param>
        /// <returns>Type Account Details</returns>
        [Route("GetAccountDetails")]
        public async Task<Accounts> GetAccountDetailsData(int id)
        {
            var myAccountDetailsData = await db.GetAccountDetailsData(id);
            return myAccountDetailsData;
        }

        /// <summary>
        /// This endpoint allows a consumer to retrieve Transactions by Id
        /// </summary>
        /// <param name="id">Get Transactions by Accoount Id</param>
        /// <returns>Type Transaction</returns>
        [Route("GetTransactions")]
        public async Task<List<Transactions>> GetTransactionsData(int id)
        {
            var myTransactionsData = await db.GetTransactionsData(id);
            return myTransactionsData;
        }


        /// <summary>
        /// This endpoint allows a consumer to retrieve Transaction Details by Id
        /// </summary>
        /// <param name="id">Get Transaction Details by Transaction Id</param>
        /// <returns>Type Transaction Details</returns>
        [Route("GetTransactionDetails")]
        public async Task<Transactions> GetTransactionDetailsData(int id)
        {
            var myTransactionDetailsData = await db.GetTransactionDetailsData(id);
            return myTransactionDetailsData;
        }

        /// <summary>
        /// This endpoint allows a consumer to Add Bank Account
        /// </summary>
        /// <param name="houseId">Target Household to Add Account to by HouseId</param>
        /// <param name="accountname">Name of Account</param>
        /// <param name="opened">Date Opened</param>
        /// <param name="accountType">Type of Account</param>
        /// <param name="startingBalance">Starting Balance of Account</param>
        /// <param name="lowBalance">Amount to be Notified of Low Balance</param>
        /// <param name="currentBalance">Current Balance of Account</param>
        /// <returns>Type Add Bank Account</returns>
        [Route("AddAccount")]
        [AcceptVerbs("GET")]
        public async Task<IHttpActionResult> AddBankAccountAsync(int houseId, string accountname, DateTime opened, int accountType, decimal startingBalance, decimal lowBalance, decimal currentBalance)
        {
            return Ok(await db.AddBankAccountAsync(houseId, accountname, opened, accountType, startingBalance, lowBalance, currentBalance));
        }

        /// <summary>
        /// This endpoint allows a consumer to Add Budget
        /// </summary>
        /// <param name="houseId">Target Household to Add Budget to by HouseId</param>
        /// <param name="budgetCatName">Budget Name</param>
        /// <param name="budgetDescription">Description of Budget</param>
        /// <param name="budgetTargetAmount">Target Amount for Budget</param>
        /// <returns>Type Add Budget</returns>
        [Route("AddBudget")]
        [AcceptVerbs("GET", "POST")]
        public async Task<IHttpActionResult> AddBudgetAsync(int houseId, string budgetCatName, string budgetDescription, decimal budgetTargetAmount)
        {
            return Ok(await db.AddBudgetAsync(houseId, budgetCatName, budgetDescription, budgetTargetAmount));
        }

        /// <summary>
        /// This endpoint allows a consumer to Add Transaction
        /// </summary>
        /// <param name="bankAccountId">Target Account to Add Transaction to by Account Id</param>
        /// <param name="budgetCategoryItemId">Target Budget Category by Category Id</param>
        /// <param name="amount">Amount of Transaction</param>
        /// <param name="transactionType">Tpye of Transaction</param>
        /// <param name="payee">Transactions Paid To</param>
        /// <param name="memo">Note of What Transaction was For</param>
        /// <param name="entered">Date Transaction Entered</param>
        /// <param name="reconciled">If Transaction Was Reconciled</param>
        /// <param name="reconciledDate">Reconciled Date if Reconciled</param>
        /// <param name="reconciledAmount">Reconciled Amount if Reconciled</param>
        /// <returns>Type Add Transaction</returns>
        [Route("AddTransaction")]
        [AcceptVerbs("GET", "POST")]
        public async Task<IHttpActionResult> AddTransactionAsync(int bankAccountId, int budgetCategoryItemId, decimal amount, int transactionType, string payee, string memo, DateTime entered, bool reconciled, DateTime reconciledDate, decimal reconciledAmount)
        {
            return Ok(await db.AddTransactionAsync(bankAccountId, budgetCategoryItemId, amount, transactionType, payee, memo, entered, reconciled, reconciledDate, reconciledAmount));
        }

        /// <summary>
        /// Update a Account
        /// </summary>
        /// <param name="accountId">Target Account to Update by Account Id</param>
        /// <param name="transactionAmount">Transaction Amount</param>
        /// <param name="transactionType">Transaction Type</param>
        /// <returns>Type Update Account</returns>
        [Route("UpdateAccount")]
        [AcceptVerbs("GET","PUT")]
        public async Task<IHttpActionResult> UpdateAccount(int accountId, decimal transactionAmount, int transactionType)
        {
            return Ok(await db.UpdateAccount(accountId, transactionAmount, transactionType));
        }

        /// <summary>
        /// Delete a Transaction
        /// </summary>
        /// <param name="id">Target Tranaction to Delete by Transaction Id</param>
        /// <returns>Type Delete Transaction</returns>
        [Route("DeleteTransaction")]
        [AcceptVerbs("DELETE")]
        public async Task<IHttpActionResult> DeleteTransaction(int id)
        {
            return Ok(await db.DeleteTransaction(id));
        }
    }
}

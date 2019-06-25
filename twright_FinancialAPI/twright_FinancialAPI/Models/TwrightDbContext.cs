using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace twright_FinancialAPI.Models
{
    /// <summary>
    /// Database
    /// </summary>
    public class TwrightDbContext : DbContext
    {
        /// <summary>
        /// Default Connection to Database
        /// </summary>
        public TwrightDbContext()
            : base("DefaultConnection")
        {
        }

        /// <summary>
        /// Consumer can get Household Data by Household ID
        /// </summary>
        //SQL GET HOUEHOLD
        public async Task<Household> GetHouseholdData(int id)
        {
            return await Database.SqlQuery<Household>("GetHouseholdData @id",
                new SqlParameter("id", id)).FirstOrDefaultAsync();
        }

        /// <summary>
        /// Consumer can get Household Budget Data by Household ID
        /// </summary>
        public async Task<List<Budget>> GetHouseholdBudgets(int id)
        {
            return await Database.SqlQuery<Budget>("GetHouseholdBudgets @id",
                new SqlParameter("id", id)).ToListAsync();
        }

        /// <summary>
        /// Consumer can get Budget Data Details by Budget ID
        /// </summary>
        public async Task<Budget> GetBudgetDetailsData(int id)
        {
            return await Database.SqlQuery<Budget>("GetHouseholdBudgetDetails @budgetId",
                new SqlParameter("budgetId", id)).FirstOrDefaultAsync();
        }

        /// <summary>
        /// Consumer can get Budget Category Data by BudgetCat ID
        /// </summary>
        public async Task<List<BudgetCategoryItem>> GetBudgetsItemsData(int id)
        {
            return await Database.SqlQuery<BudgetCategoryItem>("GetBudgetItems @budgetCatId",
                new SqlParameter("budgetCatId", id)).ToListAsync();
        }

        /// <summary>
        /// Consumer can get Budget Category Data Details by BudgetCatItem ID
        /// </summary>
        public async Task<BudgetCategoryItem> GetCategoryDetailsData(int id)
        {
            return await Database.SqlQuery<BudgetCategoryItem>("GetHouseholdBudgetDetails @budgetCatItemId",
                new SqlParameter("budgetCatItemId", id)).FirstOrDefaultAsync();
        }

        /// <summary>
        /// Consumer can get Household Account(s) Data by House ID
        /// </summary>
        public async Task<List<Accounts>> GetAccountsData(int id)
        {
            return await Database.SqlQuery<Accounts>("GetAccounts @houseId",
                new SqlParameter("houseId", id)).ToListAsync();
        }

        /// <summary>
        /// Consumer can get Account(s) Data Details by Account ID
        /// </summary>
        public async Task<Accounts> GetAccountDetailsData(int id)
        {
            return await Database.SqlQuery<Accounts>("GetAccountDetails @accountId",
                new SqlParameter("accountId", id)).FirstOrDefaultAsync();
        }

        /// <summary>
        /// Consumer can get Account Transaction Data by Account ID
        /// </summary>
        public async Task<List<Transactions>> GetTransactionsData(int id)
        {
            return await Database.SqlQuery<Transactions>("GetTransactions @accountId",
                new SqlParameter("accountId", id)).ToListAsync();
        }

        /// <summary>
        /// Consumer can get Transaction(s) Data Detials by Transaction ID
        /// </summary>
        public async Task<Transactions> GetTransactionDetailsData(int id)
        {
            return await Database.SqlQuery<Transactions>("GetTransactionDetails @transactionId",
                new SqlParameter("transactionId", id)).FirstOrDefaultAsync();
        }

        //int houseId, string accountname, DateTime opened, int accountType, decimal startingBalance, decimal lowBalance, decimal currentBalance


        /// <summary>
        /// Consumer can Add A Bank Account To A Household
        /// </summary>
        public async Task <int> AddBankAccountAsync(int houseId, string accountname, DateTime opened, int accountType, decimal startingBalance, decimal lowBalance, decimal currentBalance)
        {
            return await Database.ExecuteSqlCommandAsync("AddAccount @houseId, @accountname, @opened, @accountType, @startingBalance, @lowBalance, @currentBalance",
                new SqlParameter("houseId", houseId),
                new SqlParameter("accountname", accountname),
                new SqlParameter("opened", opened),
                new SqlParameter("accountType", accountType),
                new SqlParameter("startingBalance", startingBalance),
                new SqlParameter("lowBalance", lowBalance),
                new SqlParameter("currentBalance", currentBalance));

                
        }

        /// <summary>
        /// Consumer can Add Budget to a Household
        /// </summary>
        public async Task<int> AddBudgetAsync(int houseId, string budgetCatName, string budgetDescription, decimal budgetTargetAmount)
        {
            return await Database.ExecuteSqlCommandAsync("AddBudget @houseId, @budgetCatName, @budgetDescription, @budgetTargetAmount",
                new SqlParameter("houseId", houseId),
                new SqlParameter("budgetCatName", budgetCatName),
                new SqlParameter("budgetDescription", budgetDescription),
                new SqlParameter("budgetTargetAmount", budgetTargetAmount));


        }

        /// <summary>
        /// Consumer can Add A Transaction To A Account
        /// </summary>
        public async Task<int> AddTransactionAsync(int bankAccountId, int budgetCategoryItemId, decimal amount, int transactionType, string payee, string memo, DateTime entered, bool reconciled, DateTime reconciledDate, decimal reconciledAmount)
        {
            return await Database.ExecuteSqlCommandAsync("AddTransaction @bankAccountId, @budgetCategoryItemId, @amount, @transactionType, @payee, @memo, @entered, @reconciled, @reconciledDate, @reconciledAmount",
                new SqlParameter("bankAccountId", bankAccountId),
                new SqlParameter("budgetCategoryItemId", budgetCategoryItemId),
                new SqlParameter("amount", amount),
                new SqlParameter("transactionType", transactionType),
                new SqlParameter("payee", payee),
                new SqlParameter("memo", memo),
                new SqlParameter("entered", entered),
                new SqlParameter("reconciled", reconciled),
                new SqlParameter("reconciledDate", reconciledDate),
                new SqlParameter("reconciledAmount", reconciledAmount));


        }
        /// <summary>
        /// Consumer can Update A Account
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="transactionAmount"></param>
        /// <param name="transactionType"></param>
        /// <returns></returns>
        public async Task<int> UpdateAccount(int accountId, decimal transactionAmount, int transactionType)
        {
            return await Database.ExecuteSqlCommandAsync("UpdateAccount @accountId",
               new SqlParameter("accountId", accountId),
               new SqlParameter("transactionAmount", transactionAmount),
               new SqlParameter("transactionType", transactionType));
        }

        /// <summary>
        /// Consumer can Delete A Transaction From A Account
        /// </summary>
        /// <param name="transactionId"></param>
        /// <returns></returns>
        public async Task<int> DeleteTransaction(int transactionId)
        {
            return await Database.ExecuteSqlCommandAsync("DeleteTransaction @transactionId",
               new SqlParameter("transactionId", transactionId));
        }

        //public DbSet<Household> Households { get; set; }

    }
}
using System.Collections.ObjectModel;

namespace twright_FinancialAPI.Areas.HelpPage.ModelDescriptions
{
    /// <summary>
    /// 
    /// </summary>
    public class ComplexTypeModelDescription : ModelDescription
    {
        /// <summary>
        /// 
        /// </summary>
        public ComplexTypeModelDescription()
        {
            Properties = new Collection<ParameterDescription>();
        }

        /// <summary>
        /// 
        /// </summary>
        public Collection<ParameterDescription> Properties { get; private set; }
    }
}
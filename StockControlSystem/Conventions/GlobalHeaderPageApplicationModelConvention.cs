using Microsoft.AspNetCore.Mvc.ApplicationModels;
using StockControlSystem.Filters;

namespace StockControlSystem.Conventions
{
    #region snippet1
    public class GlobalHeaderPageApplicationModelConvention 
        : IPageApplicationModelConvention
    {
        public void Apply(PageApplicationModel model)
        {
            model.Filters.Add(new AddHeaderAttribute(
                "GlobalHeader", new string[] { "Global Header Value" }));
        }
    }
    #endregion
}

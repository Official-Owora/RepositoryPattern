using System.ComponentModel;

namespace RepositoryPattern_Models.Enums
{
    public enum ProductCategories
    {
        [Description("Local dishes")]
        LocalDishes =1,
        [Description("Continental dishes")]
        ContinentalDishes,
        [Description("Snacks")]
        Snacks,
    }
}

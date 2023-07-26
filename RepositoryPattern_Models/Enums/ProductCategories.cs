using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

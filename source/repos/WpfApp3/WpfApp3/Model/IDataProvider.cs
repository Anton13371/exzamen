using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3.Model
{
    interface IDataProvider
    {

        IEnumerable<Buyer> GetBuyers();
        IEnumerable<BuyerSearch> GetBuyerSearch();
    }
}

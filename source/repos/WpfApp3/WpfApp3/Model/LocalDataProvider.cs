using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3.Model
{
    public class LocalDataProvider : IDataProvider
    {
        public IEnumerable<Buyer> GetBuyers()
        {
            return new Buyer[]{
            new Buyer{Age=12,DateBuy=new DateTime(2021,4,12), SumBuy=125.3, Name="Юля", Type = "Платиновый"},
            new Buyer{Age=21,DateBuy=new DateTime(2021,4,19), SumBuy=300.4, Name="Жека", Type = "Золотой"},
            new Buyer{Age=13,DateBuy=new DateTime(2021,4,21), SumBuy=401.4, Name="Ярик", Type = "Серебряный"}
            };
        }
        public IEnumerable<BuyerSearch> GetBuyerSearch()
        {
            return new BuyerSearch[] {
        new BuyerSearch{ Title="Платиновый" },
        new BuyerSearch{ Title="Золотой" },
        new BuyerSearch{ Title="Серебряный" },
    };
        }

    }
}

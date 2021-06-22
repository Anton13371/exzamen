using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WpfApp3.Model
{
    public class DataProvider : IDataProvider
    {
        private Buyer[] BuyerArray;
        public DataProvider(string fileName)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Buyer[]));
            using (FileStream BuyersList = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                BuyerArray = (Buyer[])formatter.Deserialize(BuyersList);
            }
        }

       

           public IEnumerable<BuyerSearch> GetBuyerSearch()
        {
            return new BuyerSearch[]
            {
                new BuyerSearch { Title="Платиновый"},
                new BuyerSearch { Title="Золотой"},
                new BuyerSearch { Title="Серебряный"}
            };
        }

        public IEnumerable<Buyer> GetBuyers()
        {
            return BuyerArray;
        }
    }
}

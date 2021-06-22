using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp777.Model
{
    public class LocalDataProvider : IDataProvider
    {
        public IEnumerable<Worker> GetWorkers()
        {
            return new Worker[]{
            new Worker{Name="Жека", Age=20, Salary=2600.8 , BeginningWork=new DateTime(2021,4,13), Position = "Директор" },
            new Worker{Name="Руслан", Age=32,Salary=45345.7 , BeginningWork=new DateTime(2021,6,6), Position="Зам.Директора" },
            new Worker{Name="Ярик", Age=37,Salary=234523.4 , BeginningWork=new DateTime(2021,2,3), Position= "Инженер"},
        };
        }
        public IEnumerable<WorkerPosition> GetWorkerPositions()
        {
            return new WorkerPosition[] {
        new WorkerPosition{ Title="Директор" },
        new WorkerPosition{ Title="Зам.Директора" },
        new WorkerPosition{ Title="Инженер" },
    };
        }
    }
}

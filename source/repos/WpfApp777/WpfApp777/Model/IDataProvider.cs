using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp777.Model
{
    interface IDataProvider
    {
        IEnumerable<Worker> GetWorkers();
        IEnumerable<WorkerPosition> GetWorkerPositions();
    }
}

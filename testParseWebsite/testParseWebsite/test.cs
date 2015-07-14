using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections.ObjectModel;

namespace testParseWebsite
{
    public class Testclass
    {
        public Testclass()
        {
            TableCollection = new ObservableCollection<DataTable>();
        }
        public ObservableCollection<DataTable> TableCollection { get; set; }

        
    }
}

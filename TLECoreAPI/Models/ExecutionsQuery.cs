using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TLECoreAPI.Models
{
    public class ExecutionsQuery
    {
        public AppDb Db { get; }

        public ExecutionsQuery(AppDb db)
        {
            Db = db;
        }
    }
}

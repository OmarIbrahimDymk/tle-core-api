using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TLECoreAPI.Models
{
    public class Executions
    {
        internal AppDb Db { get; set; }

        public Executions()
        {

        }

        internal Executions(AppDb db)
        {
            Db = db;
        }

    }
}

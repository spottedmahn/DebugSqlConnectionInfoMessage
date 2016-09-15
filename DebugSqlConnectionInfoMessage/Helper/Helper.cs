using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class Helper
    {
        public List<string> RunTestPrintsSpWorks()
        {
            var res = new List<string>();
            using (var db = CreateDbWorks(res))
            {
                db.TestPrints();
            }
            return res;
        }

        public List<string> RunTestPrintsSpFails()
        {
            var res = new List<string>();
            using (var db = CreateDbFails(res))
            {
                db.TestPrints();
            }
            return res;
        }

        private DebugEntitiesWorks CreateDbWorks(List<string> msgs)
        {
            var res = new DebugEntitiesWorks();
            var sqlConn = (SqlConnection)res.Database.Connection;
            sqlConn.InfoMessage += (obj, e) => { msgs.Add(e.Message); };
            return res;
        }

        private DebugEntitiesFails CreateDbFails(List<string> msgs)
        {
            var res = new DebugEntitiesFails();
            var sqlConn = (SqlConnection)res.Database.Connection;
            sqlConn.InfoMessage += (obj, e) => { msgs.Add(e.Message); };
            return res;
        }
    }
}

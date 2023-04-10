using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceServ
    {
    public class InvoiceCRUD
        {

        public static DataTable ListData(string sql)
            {
            var dt= new DataTable();
            SQLiteDataAdapter adtr = new SQLiteDataAdapter(sql, DbInfo.cnn);
            adtr.Fill(dt);
            return dt;
            }
        }
    }

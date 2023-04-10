using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceServ
    {
    public class DbInfo
        {
        public static SQLiteConnection cnn = new SQLiteConnection("DataSource=.\\DataBase.db;Version=3");
        }
    }

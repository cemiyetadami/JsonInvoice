using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceServ
    {
    public class InvoiceFrame
        {
        public static List<Invoice> GetAllInvoices()
            {
            var rtrn = new List<Invoice>();
            var sql = "select ID,InvoiceID,SenderTitle,ReceiverTitle,Date FROM InvoiceHeader";
            var dat = InvoiceCRUD.ListData(sql);
            foreach (DataRow item in dat.Rows)
                {
                var inv = new Invoice();
                inv.ID = int.Parse(item[0].ToString());
                var header = new Invoice.Header();
                var lines = new List<Invoice.Line>();
                header.InvoiceId = item[1].ToString();
                header.SenderTitle = item[2].ToString();
                header.ReceiverTitle = item[3].ToString();
                header.Date = DateTime.Parse(item[4].ToString());
                inv.InvoiceHeader = header;
                var dtlines = (InvoiceCRUD.ListData("select ID,HeaderID,LineID,Name,Quantity,UnitCode,UnitPrice,LineExtensionAmount from InvoiceLine WHERE HeaderID=" + inv.ID.ToString()));
                foreach (DataRow line in dtlines.Rows)
                    {
                    var invline = new Invoice.Line();
                    invline.Id = int.Parse(line[0].ToString());
                    invline.HeaderId = int.Parse(line[1].ToString());
                    invline.LineID = int.Parse(line[2].ToString());
                    invline.Name = line[3].ToString();
                    invline.Quantity = int.Parse(line[4].ToString());
                    invline.UnitCode = line[5].ToString();
                    invline.UnitPrice = int.Parse(line[6].ToString());
                    invline.LineExtensionAmount = int.Parse(line[7].ToString());
                    lines.Add(invline);
                    }
                inv.InvoiceLine = new List<Invoice.Line>();
                inv.InvoiceLine.AddRange(lines);
                rtrn.Add(inv);

                }
            return rtrn;
            }
        }
    }

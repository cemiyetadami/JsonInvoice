using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceServ
    {
    public class Invoice
        {
        public int ID { get; set; }

        public Header InvoiceHeader { get; set; }
        public List<Line> InvoiceLine { get; set; }

        public class Header
            {
            public string InvoiceId { get; set; }
            public string SenderTitle { get; set; }
            public string ReceiverTitle { get; set; }
            public DateTime Date { get; set; }

            }
        public class Line
            {
            public int Id { get; set; }
            public int HeaderId { get; set; }
            public int LineID { get; set; }
            public string Name { get; set; }
            public int Quantity { get; set; }
            public string UnitCode { get; set; }
            public int UnitPrice { get; set; }
            public int LineExtensionAmount { get; set; }

            }
        }
    }

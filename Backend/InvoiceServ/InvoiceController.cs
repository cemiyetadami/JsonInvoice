using System;
using System.Collections;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace InvoiceServ
    {
   



    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class InvoiceController : ApiController
        {


        // GET api/Websites 
        public IEnumerable Get()
            {
            return InvoiceFrame.GetAllInvoices();
            }

        // GET api/Websites/5 
        //public Invoice Get(int id)
        //    {
        //    try
        //        {
        //        return invoices[id];
        //        }
        //    catch (Exception e)
        //        {
        //        return new Invoice();
        //        }
        //    }

        // POST api/values 
        public void Post([FromBody] string value)
            {
            Console.WriteLine("Post method called with value = " + value);
            }

        // PUT api/values/5 
        public void Put(int id, [FromBody] string value)
            {
            Console.WriteLine("Put method called with value = " + value);
            }

        // DELETE api/values/5 
        public void Delete(int id)
            {
            Console.WriteLine("Delete method called with id = " + id);
            }
        }





    }
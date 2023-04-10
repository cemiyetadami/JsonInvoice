using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Net.Http;

namespace InvoiceServ
    {
    internal class FileController
        {
        [HttpPost]
        [Route("api/upload")]
        public async Task<IHttpActionResult> UploadFile()
            {
            // Check if the request contains multipart/form-data.
            if (!Request.Content.IsMimeMultipartContent())
                {
                return BadRequest("Unsupported media type.");
                }

            try
                {
                // Set the upload directory and the maximum file size.
                var uploadDir = HttpContext.Current.Server.MapPath("~/uploads/");
                var provider = new MultipartFormDataStreamProvider(uploadDir);
                provider.MaxFileSize = 1024 * 1024 * 10; // 10 MB

                // Read the file from the request.
                await Request.Content.ReadAsMultipartAsync(provider);

                // Get the uploaded file.
                var file = provider.FileData.FirstOrDefault();
                if (file == null)
                    {
                    return BadRequest("No file was uploaded.");
                    }

                // Do something with the file.
                var fileName = file.Headers.ContentDisposition.FileName.Replace("\"", "");
                var filePath = Path.Combine(uploadDir, fileName);
                File.Move(file.LocalFileName, filePath);

                // Return the file URL.
                var fileUrl = Url.Content("~/uploads/" + fileName);
                return Ok(fileUrl);
                }
            catch (Exception ex)
                {
                return InternalServerError(ex);
                }
            }
        }

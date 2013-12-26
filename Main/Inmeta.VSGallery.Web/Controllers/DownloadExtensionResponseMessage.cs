using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Inmeta.VSGallery.Model;

namespace Inmeta.VSGallery.Web.Controllers
{
    public class DownloadExtensionResponseMessage : HttpResponseMessage
    {
        public DownloadExtensionResponseMessage(Extension extension)
        {
            this.StatusCode = HttpStatusCode.OK;
            var stream = new MemoryStream(extension.Content);
            this.Content = new StreamContent(stream);
            this.Content.Headers.ContentType = new MediaTypeHeaderValue("application/vsix");
            this.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment")
            {
                FileName = extension.Name
            };
        }        
    }
}
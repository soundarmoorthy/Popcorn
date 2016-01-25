using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Inmeta.VSGallery.Web.Models
{
    public class UploadExtensionModel
    {
        [Required]
        [ValidExtensionRequired(ErrorMessage = "You must select a valid vsix or msi file")]
        public HttpPostedFileBase File { get; set; }
        public byte[] ReadFileContent()
        {
            var content = new byte[File.ContentLength];
            File.InputStream.Read(content, 0, content.Length);
            return content;
        }
    }
}
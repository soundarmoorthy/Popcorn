using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Inmeta.VSGallery.Web.Models
{
    public class UploadExtensionModel
    {
        [Required]
        [VsixRequired(ErrorMessage = "You must select a valid Vsix file")]
        public HttpPostedFileBase File { get; set; }
        public byte[] ReadFileContent()
        {
            var content = new byte[this.File.ContentLength];
            this.File.InputStream.Read(content, 0, content.Length);
            return content;
        }
    }
}
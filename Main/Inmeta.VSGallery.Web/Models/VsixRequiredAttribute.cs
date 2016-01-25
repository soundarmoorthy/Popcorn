using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.IO;
using System.Web;

namespace Inmeta.VSGallery.Web.Models
{
    public class ValidExtensionRequiredAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                var file = value as HttpPostedFileBase;
                if (file == null)
                    return false;

                try
                {
                    var extension = Path.GetExtension(file.FileName.ToLower());
                    if (string.IsNullOrEmpty(extension))
                        return false;

                    if (extension == ".vsix" || extension == ".msi")
                        return true;
                }
                catch (Exception ex) { Debug.Assert(true, ex.ToString()); }
            }
            return false;
        }
    }
}
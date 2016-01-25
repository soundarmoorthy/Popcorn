using System;
using System.Linq;
using System.Web.Mvc;
using Inmeta.VSGallery.Model;
using Inmeta.VSGallery.Web.Models;
using Inmeta.VSIX;
using System.IO;
using VSIXParser;

namespace Inmeta.VSGallery.Web.Controllers
{
    public partial class UploadController : Controller
    {
        public virtual ActionResult Index()
        {
            return View();
        }

        public virtual ActionResult Post(UploadExtensionModel model)
        {
            if (ModelState.IsValid)
            {

                using (var ctx = new GalleryContext())
                {
                    var filename = model.File;
                    var fileExt = Path.GetExtension(filename.FileName);

                    Extension extension = null;
                    //if (fileExt == ".msi")
                    //    extension = HandleMsi(model, ctx);
                    if (fileExt == ".vsix")
                        extension = HandleVsix(model, ctx);

                    ctx.SaveChanges();
                    return RedirectToAction(MVC.Extension.Index(extension.VsixId));
                }
            }
            return View(Views.Index);
        }

        private static Extension HandleVsix(UploadExtensionModel model, GalleryContext ctx)
        {
            var vsix = model.ReadFileContent();
            var vsixItem = VsixRepository.Read(vsix, model.File.FileName);
            var extension = ctx.ExtensionsWithStuff.FirstOrDefault(e => e.VsixId == vsixItem.VsixId);
            if (extension == null)
            {
                extension = new Extension(vsixItem, vsix);
                var project = new Project(extension.Name, extension.Description);
                var release = new Release(project, extension);
                ctx.Releases.Add(release);
            }
            else
            {
                extension.Update(vsixItem, vsix);
                extension.Release.Project.ModifiedDate = DateTime.Now;
            }

            return extension;
        }

        //private Extension HandleMsi(UploadExtensionModel model, GalleryContext ctx)
        //{
        //    var msi = model.ReadFileContent();
        //    var vsixItem = GetInputFromUI();
        //    var extension = ctx.ExtensionsWithStuff.FirstOrDefault(e => e.VsixId == vsixItem.VsixId);
        //    if (extension == null)
        //    {
        //        extension = new Extension(vsixItem, msi);
        //        var project = new Project(extension.Name, extension.Description);
        //        var release = new Release(project, extension);
        //        ctx.Releases.Add(release);
        //    }
        //    else
        //    {
        //        extension.Update(vsixItem, vsix);
        //        extension.Release.Project.ModifiedDate = DateTime.Now;
        //    }

        //    return extension;
        //}

        //private VsixItem GetInputFromUI(byte[] msi)
        //{
        //    Vsix v = new Vsix();
        //    v.Version = "1.0";
        //    v.Identifier.Author = 
        //    v.Identifier.Id = Guid.NewGuid().ToString();
        //    var vsixItem = new VsixItem(v, msi)
        //}
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Web;
using Inmeta.VSGallery.Model;

namespace Inmeta.VSGallery.Web.Models
{
    public class ExtensionViewModel
    {
        public Extension Extension { get; set; }
        public string ProjectDescription { get; set; }
        public StarRating StarRating { get; set; }
        public string DownloadUrl { get; set; }
        public ExtensionViewModel(Extension e, string projectDescription, double averageRating, string baseUrl)
        {
            Extension = e;
            ProjectDescription = projectDescription;
            StarRating = new StarRating(e.Release.Id, averageRating);
            DownloadUrl = e.DownloadUrl(baseUrl);
        }
    }
    public class ReleasesViewModel
    {
        public string SearchText { get; set; }
        public IEnumerable<ReleaseViewModel> Releases { get; set; }

        [Obsolete("Only used by MVC model binder. Don't use!!!!")]
        public ReleasesViewModel()
        {

        }
        public ReleasesViewModel(IEnumerable<ReleaseViewModel> releases)
        {
            this.Releases = releases;
        }

        public ReleasesViewModel(IEnumerable<Release> releases)
        {
            this.Releases = releases.Select(e => new ReleaseViewModel(e));
        }
    }

    public class UploadExtensionModel
    {
        [Required]//, FileExtensions(Extensions = "vsix", ErrorMessage = "Select a VSIX file")]
        public HttpPostedFileBase File { get; set; }

        public byte[] ReadFileContent()
        {
            var content = new byte[this.File.ContentLength];
            this.File.InputStream.Read(content, 0, content.Length);
            return content;
        }
    }

    public class ReleaseViewModel
    {
        public ReleaseViewModel()
        {

        }

        public ReleaseViewModel(Release e)
        {
            AverageRating = e.GetAverageRating();
            Icon = e.Extension.Icon;
            NrDownloads = e.DownloadCount;
            Title = e.Extension.Name;
            Description = e.Extension.Description;
            Author = e.Extension.Author;
            ModifiedDate = e.Project.ModifiedDate;
            VsixId = e.Extension.VsixId;
            StarRating = new StarRating(e.Id, AverageRating);
            NrRatings = e.Ratings.Count();
        }

        public string VsixId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Icon { get; set; }
        public int NrDownloads { get; set; }
        public double AverageRating { get; set; }
        public int NrRatings { get; set; }

        public StarRating StarRating { get; set; }

    }

    public class StarRating
    {
        public int ReleaseId { get; set; }
        public int NrStars { get; set; }

        public StarRating(int releaseId, double averageRating)
        {
            ReleaseId = releaseId;
            NrStars = Convert.ToInt32(averageRating);
        }
    }
}
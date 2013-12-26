using System;
using System.Linq;

namespace Galleries.Domain.Model
{
    public partial class Release
    {
        public Release()
        {

        }

        public Release(Inmeta.VSGallery.Model.Release r, string baseUrl)
        {
            Rating = r.GetAverageRating();
            RatingsCount = r.Ratings.Count();
            ReviewsCount = r.Reviews.Count();
            DateReleased = DateTime.Now;
            Description = r.Project.Description;
            IsCurrentRelease = true;
            IsDisplayedOnHomePage = true;
            IsPublic = true;

            Project = new Project(r.Project)
            {
                Metadata = r.Extension.VsixMetadata(baseUrl),
                Title = r.Extension.Name,
                Description = r.Extension.Description
            };
            Files = new ReleaseFile[1]
            {
                new ReleaseFile()
                {
                    DownloadCount = r.DownloadCount
                }
            };
        }
    }

    public partial class Project
    {
        public Project()
        {

        }

        public Project(Inmeta.VSGallery.Model.Project p)
        {
            Description = p.Description;
            Title = p.Title;
            ModifiedDate = p.ModifiedDate;
            FileReleaseEnabled = true;
            IsPublished = true;
        }
    }
}
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ServiceModel;
using System.Web.Services;

namespace Galleries.Domain.Model
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="IdeCategory", Namespace="http://schemas.datacontract.org/2004/07/Galleries.Domain.Model")]
    public partial class IdeCategory : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private Galleries.Domain.Model.IdeCategory[] ChildrenField;
        
        private bool HasMoreField;
        
        private System.Guid IdField;
        
        private Galleries.Domain.Model.IdeCategory ParentField;
        
        private string TitleField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Galleries.Domain.Model.IdeCategory[] Children
        {
            get
            {
                return this.ChildrenField;
            }
            set
            {
                this.ChildrenField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool HasMore
        {
            get
            {
                return this.HasMoreField;
            }
            set
            {
                this.HasMoreField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Galleries.Domain.Model.IdeCategory Parent
        {
            get
            {
                return this.ParentField;
            }
            set
            {
                this.ParentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title
        {
            get
            {
                return this.TitleField;
            }
            set
            {
                this.TitleField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Release", Namespace="http://schemas.datacontract.org/2004/07/Galleries.Domain.Model")]
    public partial class Release : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Nullable<System.DateTime> DateReleasedField;
        
        private string DescriptionField;
        
        private Galleries.Domain.Model.ReleaseFile[] FilesField;
        
        private int IdField;
        
        private bool IsCurrentReleaseField;
        
        private bool IsDisplayedOnHomePageField;
        
        private bool IsPublicField;
        
        private string NameField;
        
        private Galleries.Domain.Model.Project ProjectField;
        
        private double RatingField;
        
        private int RatingsCountField;
        
        private int ReviewsCountField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> DateReleased
        {
            get
            {
                return this.DateReleasedField;
            }
            set
            {
                this.DateReleasedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Galleries.Domain.Model.ReleaseFile[] Files
        {
            get
            {
                return this.FilesField;
            }
            set
            {
                this.FilesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsCurrentRelease
        {
            get
            {
                return this.IsCurrentReleaseField;
            }
            set
            {
                this.IsCurrentReleaseField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsDisplayedOnHomePage
        {
            get
            {
                return this.IsDisplayedOnHomePageField;
            }
            set
            {
                this.IsDisplayedOnHomePageField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsPublic
        {
            get
            {
                return this.IsPublicField;
            }
            set
            {
                this.IsPublicField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Galleries.Domain.Model.Project Project
        {
            get
            {
                return this.ProjectField;
            }
            set
            {
                this.ProjectField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Rating
        {
            get
            {
                return this.RatingField;
            }
            set
            {
                this.RatingField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RatingsCount
        {
            get
            {
                return this.RatingsCountField;
            }
            set
            {
                this.RatingsCountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ReviewsCount
        {
            get
            {
                return this.ReviewsCountField;
            }
            set
            {
                this.ReviewsCountField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Project", Namespace="http://schemas.datacontract.org/2004/07/Galleries.Domain.Model")]
    public partial class Project : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int AffiliateIdField;
        
        private Galleries.Domain.Model.Category[] CategoriesField;
        
        private System.DateTime CreatedDateField;
        
        private Galleries.Domain.Model.Release CurrentReleaseField;
        
        private string DescriptionField;
        
        private bool DiscussionsEnabledField;
        
        private bool FileReleaseEnabledField;
        
        private int IdField;
        
        private string InitialProjectNameField;
        
        private bool IsPublishedField;
        
        private System.Collections.Generic.Dictionary<string, string> MetadataField;
        
        private System.DateTime ModifiedDateField;
        
        private string NameField;
        
        private Galleries.Domain.Model.Release[] ReleasesField;
        
        private bool SourceCodeBrowsingEnabledField;
        
        private string[] TagsField;
        
        private string TitleField;
        
        private bool WorkItemTrackingEnabledField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AffiliateId
        {
            get
            {
                return this.AffiliateIdField;
            }
            set
            {
                this.AffiliateIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Galleries.Domain.Model.Category[] Categories
        {
            get
            {
                return this.CategoriesField;
            }
            set
            {
                this.CategoriesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreatedDate
        {
            get
            {
                return this.CreatedDateField;
            }
            set
            {
                this.CreatedDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Galleries.Domain.Model.Release CurrentRelease
        {
            get
            {
                return this.CurrentReleaseField;
            }
            set
            {
                this.CurrentReleaseField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool DiscussionsEnabled
        {
            get
            {
                return this.DiscussionsEnabledField;
            }
            set
            {
                this.DiscussionsEnabledField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool FileReleaseEnabled
        {
            get
            {
                return this.FileReleaseEnabledField;
            }
            set
            {
                this.FileReleaseEnabledField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string InitialProjectName
        {
            get
            {
                return this.InitialProjectNameField;
            }
            set
            {
                this.InitialProjectNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsPublished
        {
            get
            {
                return this.IsPublishedField;
            }
            set
            {
                this.IsPublishedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.Dictionary<string, string> Metadata
        {
            get
            {
                return this.MetadataField;
            }
            set
            {
                this.MetadataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ModifiedDate
        {
            get
            {
                return this.ModifiedDateField;
            }
            set
            {
                this.ModifiedDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Galleries.Domain.Model.Release[] Releases
        {
            get
            {
                return this.ReleasesField;
            }
            set
            {
                this.ReleasesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool SourceCodeBrowsingEnabled
        {
            get
            {
                return this.SourceCodeBrowsingEnabledField;
            }
            set
            {
                this.SourceCodeBrowsingEnabledField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] Tags
        {
            get
            {
                return this.TagsField;
            }
            set
            {
                this.TagsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title
        {
            get
            {
                return this.TitleField;
            }
            set
            {
                this.TitleField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool WorkItemTrackingEnabled
        {
            get
            {
                return this.WorkItemTrackingEnabledField;
            }
            set
            {
                this.WorkItemTrackingEnabledField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ReleaseFile", Namespace="http://schemas.datacontract.org/2004/07/Galleries.Domain.Model")]
    public partial class ReleaseFile : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private Galleries.Domain.Model.FileAttachment AttachmentField;
        
        private string DescriptionField;
        
        private int DownloadCountField;
        
        private int IdField;
        
        private System.Collections.Generic.Dictionary<string, string> MetadataField;
        
        private Galleries.Domain.Model.Release ParentField;
        
        private Galleries.Domain.Model.ReleaseFileType TypeField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Galleries.Domain.Model.FileAttachment Attachment
        {
            get
            {
                return this.AttachmentField;
            }
            set
            {
                this.AttachmentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DownloadCount
        {
            get
            {
                return this.DownloadCountField;
            }
            set
            {
                this.DownloadCountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.Dictionary<string, string> Metadata
        {
            get
            {
                return this.MetadataField;
            }
            set
            {
                this.MetadataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Galleries.Domain.Model.Release Parent
        {
            get
            {
                return this.ParentField;
            }
            set
            {
                this.ParentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Galleries.Domain.Model.ReleaseFileType Type
        {
            get
            {
                return this.TypeField;
            }
            set
            {
                this.TypeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FileAttachment", Namespace="http://schemas.datacontract.org/2004/07/Galleries.Domain.Model")]
    public partial class FileAttachment : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string FileNameField;
        
        private int IdField;
        
        private System.DateTime UploadDateField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FileName
        {
            get
            {
                return this.FileNameField;
            }
            set
            {
                this.FileNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime UploadDate
        {
            get
            {
                return this.UploadDateField;
            }
            set
            {
                this.UploadDateField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ReleaseFileType", Namespace="http://schemas.datacontract.org/2004/07/Galleries.Domain.Model")]
    public partial class ReleaseFileType : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string DescriptionField;
        
        private string IdField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Category", Namespace="http://schemas.datacontract.org/2004/07/Galleries.Domain.Model")]
    public partial class Category : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private Galleries.Domain.Model.Category[] ChildrenField;
        
        private int IdField;
        
        private Galleries.Domain.Model.Category ParentField;
        
        private string TitleField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Galleries.Domain.Model.Category[] Children
        {
            get
            {
                return this.ChildrenField;
            }
            set
            {
                this.ChildrenField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Galleries.Domain.Model.Category Parent
        {
            get
            {
                return this.ParentField;
            }
            set
            {
                this.ParentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title
        {
            get
            {
                return this.TitleField;
            }
            set
            {
                this.TitleField = value;
            }
        }
    }
}
namespace VsGallery.WebServices
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ReleaseQueryResult", Namespace="http://schemas.datacontract.org/2004/07/VsGallery.WebServices")]
    public partial class ReleaseQueryResult : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private Galleries.Domain.Model.Release[] ReleasesField;
        
        private int TotalCountField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Galleries.Domain.Model.Release[] Releases
        {
            get
            {
                return this.ReleasesField;
            }
            set
            {
                this.ReleasesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TotalCount
        {
            get
            {
                return this.TotalCountField;
            }
            set
            {
                this.TotalCountField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[ServiceContract]
[WebService(Name = "VsIdeService")]
[WebServiceBinding(Name = "VsIdeService", ConformsTo = WsiProfiles.BasicProfile1_1, EmitConformanceClaims = true)]

public interface IVsIdeService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVsIdeService/GetCategoryTree", ReplyAction="http://tempuri.org/IVsIdeService/GetCategoryTreeResponse")]
    [System.ServiceModel.FaultContractAttribute(typeof(System.Guid), Action="http://galleries.msdn.microsoft.com/faults/generic", Name="guid", Namespace="http://schemas.microsoft.com/2003/10/Serialization/")]
    Galleries.Domain.Model.IdeCategory GetCategoryTree(System.Guid categoryId, int level, string projectType, string templateType, string[] skus, string[] subSkus, int[] templateGroupIds, int[] vsVersions, string cultureName);

    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVsIdeService/GetRootCategories", ReplyAction="http://tempuri.org/IVsIdeService/GetRootCategoriesResponse")]
    [System.ServiceModel.FaultContractAttribute(typeof(System.Guid), Action="http://galleries.msdn.microsoft.com/faults/generic", Name="guid", Namespace="http://schemas.microsoft.com/2003/10/Serialization/")]
    Galleries.Domain.Model.IdeCategory[] GetRootCategories(string cultureName);
    
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVsIdeService/SearchReleases", ReplyAction="http://tempuri.org/IVsIdeService/SearchReleasesResponse")]
    [System.ServiceModel.FaultContractAttribute(typeof(System.Guid), Action="http://galleries.msdn.microsoft.com/faults/generic", Name="guid", Namespace="http://schemas.microsoft.com/2003/10/Serialization/")]
    VsGallery.WebServices.ReleaseQueryResult SearchReleases(string searchText, string whereClause, string orderByClause, System.Nullable<int> locale, System.Nullable<int> skip, System.Nullable<int> take);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVsIdeService/GetRootCategories2", ReplyAction="http://tempuri.org/IVsIdeService/GetRootCategories2Response")]
    [System.ServiceModel.FaultContractAttribute(typeof(System.Guid), Action="http://galleries.msdn.microsoft.com/faults/generic", Name="guid", Namespace="http://schemas.microsoft.com/2003/10/Serialization/")]
    Galleries.Domain.Model.IdeCategory[] GetRootCategories2(System.Collections.Generic.Dictionary<string, string> requestContext);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVsIdeService/GetCategoryTree2", ReplyAction="http://tempuri.org/IVsIdeService/GetCategoryTree2Response")]
    [System.ServiceModel.FaultContractAttribute(typeof(System.Guid), Action="http://galleries.msdn.microsoft.com/faults/generic", Name="guid", Namespace="http://schemas.microsoft.com/2003/10/Serialization/")]
    Galleries.Domain.Model.IdeCategory GetCategoryTree2(System.Guid categoryId, int level, System.Collections.Generic.Dictionary<string, string> requestContext);
    
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVsIdeService/SearchReleases2", ReplyAction="http://tempuri.org/IVsIdeService/SearchReleases2Response")]
    [System.ServiceModel.FaultContractAttribute(typeof(System.Guid), Action="http://galleries.msdn.microsoft.com/faults/generic", Name="guid", Namespace="http://schemas.microsoft.com/2003/10/Serialization/")]
    VsGallery.WebServices.ReleaseQueryResult SearchReleases2(string searchText, string whereClause, string orderByClause, System.Nullable<int> skip, System.Nullable<int> take, System.Collections.Generic.Dictionary<string, string> requestContext);
    
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVsIdeService/GetCurrentVersionsForVsixList", ReplyAction="http://tempuri.org/IVsIdeService/GetCurrentVersionsForVsixListResponse")]
    [System.ServiceModel.FaultContractAttribute(typeof(System.Guid), Action="http://galleries.msdn.microsoft.com/faults/generic", Name="guid", Namespace="http://schemas.microsoft.com/2003/10/Serialization/")]
    string[] GetCurrentVersionsForVsixList(string[] vsixIds, System.Collections.Generic.Dictionary<string, string> requestContext);
    
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IVsIdeServiceChannel : IVsIdeService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class VsIdeServiceClient : System.ServiceModel.ClientBase<IVsIdeService>, IVsIdeService
{
    
    public VsIdeServiceClient()
    {
    }
    
    public VsIdeServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public VsIdeServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public VsIdeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public VsIdeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public Galleries.Domain.Model.IdeCategory GetCategoryTree(System.Guid categoryId, int level, string projectType, string templateType, string[] skus, string[] subSkus, int[] templateGroupIds, int[] vsVersions, string cultureName)
    {
        return base.Channel.GetCategoryTree(categoryId, level, projectType, templateType, skus, subSkus, templateGroupIds, vsVersions, cultureName);
    }
    
    
    public Galleries.Domain.Model.IdeCategory[] GetRootCategories(string cultureName)
    {
        return base.Channel.GetRootCategories(cultureName);
    }
    
    
    public VsGallery.WebServices.ReleaseQueryResult SearchReleases(string searchText, string whereClause, string orderByClause, System.Nullable<int> locale, System.Nullable<int> skip, System.Nullable<int> take)
    {
        return base.Channel.SearchReleases(searchText, whereClause, orderByClause, locale, skip, take);
    }
    
    
    public Galleries.Domain.Model.IdeCategory[] GetRootCategories2(System.Collections.Generic.Dictionary<string, string> requestContext)
    {
        return base.Channel.GetRootCategories2(requestContext);
    }
    
    
    public Galleries.Domain.Model.IdeCategory GetCategoryTree2(System.Guid categoryId, int level, System.Collections.Generic.Dictionary<string, string> requestContext)
    {
        return base.Channel.GetCategoryTree2(categoryId, level, requestContext);
    }
    
    public VsGallery.WebServices.ReleaseQueryResult SearchReleases2(string searchText, string whereClause, string orderByClause, System.Nullable<int> skip, System.Nullable<int> take, System.Collections.Generic.Dictionary<string, string> requestContext)
    {
        return base.Channel.SearchReleases2(searchText, whereClause, orderByClause, skip, take, requestContext);
    }
    
    
    public string[] GetCurrentVersionsForVsixList(string[] vsixIds, System.Collections.Generic.Dictionary<string, string> requestContext)
    {
        return base.Channel.GetCurrentVersionsForVsixList(vsixIds, requestContext);
    }
    
}

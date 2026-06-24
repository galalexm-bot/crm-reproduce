using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using NuGet;

namespace EleWise.ELMA.Packaging.ElmaStoreManifest;

[Serializable]
[DataContract]
[XmlRoot("ElmaComponent")]
public class ElmaStoreComponentManifest
{
	[XmlElement("Id")]
	[DataMember]
	public string Id { get; set; }

	[XmlElement("ProductType")]
	[DataMember]
	public ManifestComponentType ProductType { get; set; }

	[XmlElement("ActivationType")]
	[DataMember]
	public ElmaStoreComponentActivationType ActivationType { get; set; }

	[XmlElement("Title")]
	[DataMember]
	public string Title { get; set; }

	[XmlElement("Description")]
	[DataMember]
	public string Description { get; set; }

	[XmlElement("Version")]
	[DataMember]
	public string Version { get; set; }

	[XmlElement("HelpFileName")]
	[DataMember]
	[DefaultValue("")]
	public string HelpFileName { get; set; }

	[XmlIgnore]
	[IgnoreDataMember]
	public SemanticVersion SemanticVersion
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Expected O, but got Unknown
			try
			{
				return new SemanticVersion(Version);
			}
			catch (Exception)
			{
				return null;
			}
		}
		set
		{
			Version = ((object)value).ToString();
		}
	}

	[XmlElement("Author")]
	[DataMember]
	public string Author { get; set; }

	[XmlElement("Site")]
	[DataMember]
	public string Site { get; set; }

	[XmlArray]
	[XmlArrayItem("Component")]
	[DataMember]
	public List<ElmaStoreComponentDependency> Dependencies { get; set; }

	[XmlElement("OrganizationItems")]
	[DataMember]
	public bool OrganizationItems { get; set; }

	[XmlArray]
	[XmlArrayItem("Entity")]
	[DataMember]
	public List<EntityManifest> Entities { get; set; }

	[XmlArray]
	[XmlArrayItem("Package")]
	[DataMember]
	public List<PackageManifest> Packages { get; set; }

	[XmlArray]
	[XmlArrayItem("BpmApp")]
	[DataMember]
	public List<BpmAppManifest> BpmApps { get; set; }

	[XmlArray]
	[XmlArrayItem("Process")]
	[DataMember]
	public List<ProcessManifest> Processes { get; set; }

	[XmlArray]
	[XmlArrayItem("Report")]
	[DataMember]
	public List<ReportManifest> Reports { get; set; }

	[XmlElement("ModuleUid")]
	[DataMember]
	public Guid ModuleUid { get; set; }

	[XmlElement("ModuleManifest")]
	[DataMember]
	public ModuleManifest ModuleManifest { get; set; }

	[XmlIgnore]
	public string BPMAppManifest { get; set; }

	[XmlElement("BPMAppManifest")]
	[DefaultValue(null)]
	public XmlCDataSection BPMAppManifestCData
	{
		get
		{
			if (BPMAppManifest == null)
			{
				return null;
			}
			return new XmlDocument().CreateCDataSection(BPMAppManifest);
		}
		set
		{
			BPMAppManifest = value?.Value;
		}
	}

	[XmlElement("TagDataBase")]
	[DataMember]
	[DefaultValue("")]
	public string TagDataBase { get; set; }

	[XmlIgnore]
	public List<string> TagDataBaseList => ConvertTagToList(TagDataBase);

	[XmlElement("TagLanguage")]
	[DataMember]
	[DefaultValue("")]
	public string TagLanguage { get; set; }

	[XmlIgnore]
	public List<string> TagLanguageList => ConvertTagToList(TagLanguage);

	[XmlElement("TagEdition")]
	[DataMember]
	[DefaultValue("")]
	public string TagEdition { get; set; }

	[XmlIgnore]
	public List<string> TagEditionList => ConvertTagToList(TagEdition);

	private List<string> ConvertTagToList(string tagStr)
	{
		if (string.IsNullOrWhiteSpace(tagStr))
		{
			return new List<string>();
		}
		return (from t in tagStr.Split(';')
			where !string.IsNullOrWhiteSpace(t)
			select t.Trim().ToLower()).Distinct().ToList();
	}

	public ElmaStoreComponentManifest()
	{
		BpmApps = new List<BpmAppManifest>();
		Packages = new List<PackageManifest>();
		Entities = new List<EntityManifest>();
		Processes = new List<ProcessManifest>();
		Reports = new List<ReportManifest>();
		Dependencies = new List<ElmaStoreComponentDependency>();
		Version = "1.0.0.0";
		HelpFileName = "";
	}

	public override string ToString()
	{
		return Id + " " + Version;
	}

	public Guid GetUid()
	{
		if (string.IsNullOrEmpty(Id))
		{
			throw new NullReferenceException("Id is empty");
		}
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] bytes = Encoding.UTF8.GetBytes(Id.ToLower());
		byte[] b = mD5CryptoServiceProvider.ComputeHash(bytes);
		return new Guid(b);
	}

	public string GetNonEmptyTitle()
	{
		if (string.IsNullOrEmpty(Title))
		{
			return Id;
		}
		return Title;
	}
}

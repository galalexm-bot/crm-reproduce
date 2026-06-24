using System;
using System.Data.Services.Common;
using NuGet;

namespace EleWise.ELMA.Packaging;

[DataServiceKey(new string[] { "Id", "Version" })]
[EntityPropertyMapping("Id", SyndicationItemProperty.Title, SyndicationTextContentKind.Plaintext, false)]
public class ElmaPackageInfoData
{
	public string Id { get; set; }

	public string Version { get; set; }

	public string Tags { get; set; }

	public ElmaPackageMetadataData ElmaMetadata { get; set; }

	public ElmaPackageInfoData()
	{
	}

	public ElmaPackageInfoData(ElmaPackageInfo packageInfo)
	{
		if (packageInfo == null)
		{
			throw new ArgumentNullException("packageInfo");
		}
		Id = packageInfo.Id;
		Version = ((packageInfo.Version != (SemanticVersion)null) ? ((object)packageInfo.Version).ToString() : "");
		ElmaMetadata = ((packageInfo.ElmaMetadata != null) ? new ElmaPackageMetadataData(packageInfo.ElmaMetadata) : null);
		if (packageInfo.Package != null)
		{
			Tags = ((IPackageMetadata)packageInfo.Package).get_Tags();
			if (ElmaMetadata == null && !string.IsNullOrEmpty(((IPackageMetadata)packageInfo.Package).get_Tags()))
			{
				ElmaMetadata = new ElmaPackageMetadataData(new ElmaPackageMetadata(((IPackageMetadata)packageInfo.Package).get_Tags()));
			}
		}
	}

	public ElmaPackageInfo ToInfo()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (ElmaMetadata == null && !string.IsNullOrEmpty(Tags))
		{
			ElmaMetadata = new ElmaPackageMetadataData(new ElmaPackageMetadata(Tags));
		}
		return new ElmaPackageInfo
		{
			Id = Id,
			Version = ((!string.IsNullOrEmpty(Version)) ? new SemanticVersion(Version) : ((SemanticVersion)null)),
			ElmaMetadata = ((ElmaMetadata != null) ? ElmaMetadata.ToMetadata() : null)
		};
	}
}

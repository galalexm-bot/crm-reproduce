using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Packaging;

public class ElmaPackageMetadataData
{
	public string Type { get; set; }

	public string Components { get; set; }

	public string OwnerIds { get; set; }

	public string Tags { get; set; }

	public ElmaPackageMetadataData()
	{
	}

	public ElmaPackageMetadataData(ElmaPackageMetadata metadata)
	{
		if (metadata == null)
		{
			throw new ArgumentNullException("metadata");
		}
		Type = metadata.Type.ToString();
		Components = ((metadata.Components != null) ? string.Join("|", metadata.Components) : "");
		OwnerIds = ((metadata.OwnerIds != null) ? string.Join("|", metadata.OwnerIds) : "");
		Tags = metadata.Tags;
	}

	public ElmaPackageMetadata ToMetadata()
	{
		if (!Enum.TryParse<ElmaPackageType>(Type, out var result))
		{
			result = ElmaPackageType.Unknown;
		}
		ElmaPackageMetadata elmaPackageMetadata = new ElmaPackageMetadata();
		elmaPackageMetadata.Type = result;
		elmaPackageMetadata.Components = ((Components != null) ? Components.Split(new char[1] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList() : new List<string>());
		elmaPackageMetadata.OwnerIds = ((OwnerIds != null) ? OwnerIds.Split(new char[1] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList() : new List<string>());
		elmaPackageMetadata.Tags = Tags;
		return elmaPackageMetadata;
	}
}

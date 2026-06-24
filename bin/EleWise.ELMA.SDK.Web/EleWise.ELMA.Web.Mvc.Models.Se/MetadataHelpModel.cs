using System;
using EleWise.ELMA.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.Web.Mvc.Models.ServiceHelp;

public class MetadataHelpModel
{
	private IPublicMetadataInfo _metadataInfo;

	private IMetadata _metadata;

	public IPublicMetadataInfo MetadataInfo => _metadataInfo;

	public IMetadata Metadata => _metadata;

	public TypeSerializationDescriptor Descriptor { get; set; }

	public MetadataHelpModel(IPublicMetadataInfo metadataInfo)
	{
		if (metadataInfo == null)
		{
			throw new ArgumentNullException("metadataInfo");
		}
		_metadataInfo = metadataInfo;
		_metadata = metadataInfo.GetMetadata();
	}
}

using System;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Services;

[Component]
internal sealed class MetadataServiceRefreshData : IRefreshData
{
	private readonly MetadataService metadataService;

	public MetadataServiceRefreshData(MetadataService metadataService)
	{
		this.metadataService = metadataService;
	}

	public void Refresh(Guid moduleUid)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		metadataService.Refresh(moduleUid);
	}
}

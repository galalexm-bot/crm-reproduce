using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.Api.Services;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI.Models;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.UI.Managers;

[Service]
public sealed class MetadataItemGroupUIManager
{
	private readonly IMetadataItemGroupUIService metadataItemGroupUIService;

	public MetadataItemGroupUIManager(IMetadataItemGroupUIService metadataItemGroupUIService)
	{
		this.metadataItemGroupUIService = metadataItemGroupUIService;
	}

	public System.Threading.Tasks.Task<MetadataItemGroupUI> Create(MetadataItemGroupUI group)
	{
		return metadataItemGroupUIService.CreateGroup(group);
	}

	public System.Threading.Tasks.Task<System.Collections.Generic.ICollection<MetadataItemGroupUI>> GetAll()
	{
		return metadataItemGroupUIService.LoadGroups();
	}

	public System.Threading.Tasks.Task Delete(MetadataItemGroupUI group)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return metadataItemGroupUIService.Delete(group.get_Uid());
	}

	public System.Threading.Tasks.Task<MetadataItemGroupUI> EditGroup(MetadataItemGroupUI group)
	{
		return metadataItemGroupUIService.EditGroup(group);
	}
}

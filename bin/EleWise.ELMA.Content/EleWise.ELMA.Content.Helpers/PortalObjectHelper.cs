using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;

namespace EleWise.ELMA.Content.Helpers;

public static class PortalObjectHelper
{
	public static bool PageWithSettings(IPortalObject page)
	{
		if (page == null)
		{
			return false;
		}
		if (!(AbstractNHEntityManager<ComponentMetadataItemHeader, long>.Instance.LoadOrNull(page.Uid)?.Published?.Metadata is PageComponentMetadata pageComponentMetadata))
		{
			return false;
		}
		return pageComponentMetadata.Content.Context.Properties.Any(InputSelector);
	}

	public static IEnumerable<PropertyMetadata> GetPageInputs(ClassMetadata metadata)
	{
		return metadata.Properties.Where(InputSelector);
	}

	private static bool InputSelector(PropertyMetadata property)
	{
		if (property is ViewModelPropertyMetadata viewModelPropertyMetadata && !viewModelPropertyMetadata.ClientOnly && viewModelPropertyMetadata.Input)
		{
			return viewModelPropertyMetadata.TypeUid != DataClassDescriptor.UID;
		}
		return false;
	}
}

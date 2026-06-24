using System;
using EleWise.ELMA.Documents.Components;
using EleWise.ELMA.Files;
using EleWise.ELMA.Files.Previews;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Documents.Web.Components;

[Obsolete("Больше не используется", true)]
public class DocumentStoragePreviewSettingsResolver : IPreviewSettingsResolver
{
	public bool IsAvaliable(BinaryFile file)
	{
		return true;
	}

	public bool ResolveOption(PreviewSettingsOption option, BinaryFile file)
	{
		if (option == PreviewSettingsOption.HideSelector)
		{
			PreviewSettingsBlock serviceNotNull = Locator.GetServiceNotNull<PreviewSettingsBlock>();
			if (serviceNotNull == null || serviceNotNull.Settings == null)
			{
				return false;
			}
			return serviceNotNull.Settings.HideSelector;
		}
		return false;
	}
}

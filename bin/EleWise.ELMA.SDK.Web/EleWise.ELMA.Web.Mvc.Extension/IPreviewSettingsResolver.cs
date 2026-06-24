using System;
using EleWise.ELMA.Files;
using EleWise.ELMA.Files.Previews;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[Obsolete("Больше не используется", true)]
public interface IPreviewSettingsResolver
{
	bool IsAvaliable(BinaryFile file);

	bool ResolveOption(PreviewSettingsOption option, BinaryFile file);
}

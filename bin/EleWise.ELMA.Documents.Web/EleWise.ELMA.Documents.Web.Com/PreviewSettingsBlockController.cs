using System;
using EleWise.ELMA.Documents.Components;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Web.Extensions;

namespace EleWise.ELMA.Documents.Web.Components;

[Obsolete("Больше не используется", true)]
public class PreviewSettingsBlockControllerBase : DocumentStorageSettingsBlockControllerBase<PreviewSettings, PreviewSettingsBlock>
{
	public PreviewSettingsBlockControllerBase(PreviewSettingsBlock module)
		: base(module)
	{
	}
}

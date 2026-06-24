using System;
using EleWise.ELMA.Documents.Models;

namespace EleWise.ELMA.Documents.Components;

[Obsolete("Больше не используется", true)]
public class PreviewSettingsBlock : DocumentStorageSettingsBlockBase<PreviewSettings>
{
	public static Guid UID = new Guid("{A3B696F4-4952-44D1-94BA-9C403BA9BEF1}");

	public override Guid BlockUid => UID;

	public override string BlockName => SR.T("Настройки предпросмотра");
}

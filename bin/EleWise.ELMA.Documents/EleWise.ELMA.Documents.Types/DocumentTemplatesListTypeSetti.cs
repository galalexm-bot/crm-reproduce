using System;
using System.Runtime.Serialization;
using EleWise.ELMA.Model.Types.Settings;

namespace EleWise.ELMA.Documents.Types;

[Serializable]
public class DocumentTemplatesListTypeSettings : SimpleTypeSettings
{
	public DocumentTemplatesListTypeSettings()
	{
	}

	protected DocumentTemplatesListTypeSettings(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}

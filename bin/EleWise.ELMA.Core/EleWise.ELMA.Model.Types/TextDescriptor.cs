using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Logging;

namespace EleWise.ELMA.Model.Types;

[Component(Order = 200)]
public class TextDescriptor : StringDescriptor<TextSettings>
{
	public static readonly Guid UID = TypeConstants.TextUid;

	public override Guid Uid => UID;

	public override string Name => SR.T("Текст");

	public override bool IsRuntimeType => false;

	public TextDescriptor(ILogger logger)
		: base(logger)
	{
	}

	public override TypeSettings CreateSettings()
	{
		TextSettings obj = ObjectExtensions.As<TextSettings>((object)base.CreateSettings());
		((StringSettings)obj).set_MultiLine(true);
		return (TypeSettings)(object)obj;
	}
}

using System;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Web.Mvc.Inputs;

public class TimeSpanInput : BaseInput
{
	public override Guid TypeUid => TimeSpanDescriptor.UID;

	protected override string GetTemplateName(IPropertyMetadata metadata)
	{
		return "TimeSpan";
	}
}

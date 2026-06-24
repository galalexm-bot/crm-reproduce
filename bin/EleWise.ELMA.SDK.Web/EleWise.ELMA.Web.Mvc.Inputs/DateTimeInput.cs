using System;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Web.Mvc.Inputs;

public class DateTimeInput : BaseInput
{
	public override Guid TypeUid => DateTimeDescriptor.UID;

	protected override string GetTemplateName(IPropertyMetadata metadata)
	{
		return "DateTime";
	}
}

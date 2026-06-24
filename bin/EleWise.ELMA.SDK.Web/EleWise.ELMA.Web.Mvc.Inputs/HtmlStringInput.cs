using System;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Web.Mvc.Inputs;

public class HtmlStringInput : BaseInput
{
	public override Guid TypeUid => HtmlStringDescriptor.UID;

	protected override string GetTemplateName(IPropertyMetadata metadata)
	{
		return "HtmlString";
	}
}

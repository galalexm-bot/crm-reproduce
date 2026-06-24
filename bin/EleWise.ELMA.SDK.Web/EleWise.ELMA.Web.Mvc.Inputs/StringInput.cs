using System;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Web.Mvc.Inputs;

public class StringInput : BaseInput
{
	public override Guid TypeUid => StringDescriptor.UID;

	protected override string GetTemplateName(IPropertyMetadata metadata)
	{
		return "String";
	}
}

using System;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Web.Mvc.Inputs;

public class TextInput : BaseInput
{
	public override Guid TypeUid => TextDescriptor.UID;

	protected override string GetTemplateName(IPropertyMetadata metadata)
	{
		return "String";
	}
}

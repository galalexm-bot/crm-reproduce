using System;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Web.Mvc.Inputs;

public class ReferenceOnTypeInput : BaseInput
{
	public override Guid TypeUid => ReferenceOnTypeDescriptor.UID;

	protected override string GetTemplateName(IPropertyMetadata metadata)
	{
		return "ReferenceOnType";
	}
}

using System;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Web.Mvc.Inputs;

public class DoubleInput : BaseInput
{
	public override Guid TypeUid => DoubleDescriptor.UID;

	protected override string GetTemplateName(IPropertyMetadata metadata)
	{
		return "Double";
	}
}

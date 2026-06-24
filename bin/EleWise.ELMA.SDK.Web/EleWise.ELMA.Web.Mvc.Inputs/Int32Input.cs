using System;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Web.Mvc.Inputs;

public class Int32Input : BaseInput
{
	public override Guid TypeUid => Int32Descriptor.UID;

	protected override string GetTemplateName(IPropertyMetadata metadata)
	{
		return "Int32";
	}
}

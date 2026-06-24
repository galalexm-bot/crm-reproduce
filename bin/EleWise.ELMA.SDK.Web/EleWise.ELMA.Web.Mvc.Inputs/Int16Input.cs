using System;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Web.Mvc.Inputs;

public class Int16Input : BaseInput
{
	public override Guid TypeUid => Int16Descriptor.UID;

	protected override string GetTemplateName(IPropertyMetadata metadata)
	{
		return "Int16";
	}
}

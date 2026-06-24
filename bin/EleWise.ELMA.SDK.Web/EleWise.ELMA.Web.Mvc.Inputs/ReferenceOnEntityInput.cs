using System;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Web.Mvc.Inputs;

public class ReferenceOnEntityInput : BaseInput
{
	public override Guid TypeUid => ReferenceOnEntityDecription.UID;

	protected override string GetTemplateName(IPropertyMetadata metadata)
	{
		return "ReferenceOnEntity";
	}
}

using System;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Web.Mvc.Inputs;

public class ReferenceOnEntityTypeInput : BaseInput
{
	public override Guid TypeUid => ReferenceOnEntityTypeDecription.UID;

	protected override string GetTemplateName(IPropertyMetadata metadata)
	{
		return "ReferenceOnEntityType";
	}
}

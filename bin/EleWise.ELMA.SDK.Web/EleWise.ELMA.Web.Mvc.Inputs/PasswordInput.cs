using System;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Web.Mvc.Inputs;

public class PasswordInput : BaseInput
{
	public override Guid TypeUid => PasswordDescriptor.UID;

	protected override string GetTemplateName(IPropertyMetadata metadata)
	{
		return "Password";
	}
}

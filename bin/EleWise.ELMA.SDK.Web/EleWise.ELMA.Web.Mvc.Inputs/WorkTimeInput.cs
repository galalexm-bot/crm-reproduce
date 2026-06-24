using System;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Web.Mvc.Inputs;

public class WorkTimeInput : BaseInput
{
	public override Guid TypeUid => WorkTimeDescriptor.UID;

	protected override string GetTemplateName(IPropertyMetadata metadata)
	{
		return "WorkTime";
	}
}

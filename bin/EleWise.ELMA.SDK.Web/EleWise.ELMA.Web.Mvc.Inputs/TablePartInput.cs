using System;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Web.Mvc.Inputs;

public class TablePartInput : BaseInput
{
	public override Guid TypeUid => TablePartMetadata.UID;

	protected override string GetTemplateName(IPropertyMetadata metadata)
	{
		return "TablePart";
	}

	protected override bool CheckEnumerable()
	{
		return false;
	}
}

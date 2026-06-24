using System;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Web.Mvc.Inputs;

public class BinaryFileInput : BaseInput
{
	public override Guid TypeUid => BinaryFileDescriptor.UID;

	protected override string GetTemplateName(IPropertyMetadata metadata)
	{
		return "BinaryFile";
	}

	protected override bool CheckEnumerable()
	{
		return false;
	}
}

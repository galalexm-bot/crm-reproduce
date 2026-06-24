using System;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;

namespace EleWise.ELMA.Web.Mvc.Inputs;

public class BoolInput : BaseInput
{
	public override Guid TypeUid => BoolDescriptor.UID;

	protected override string GetTemplateName(IPropertyMetadata metadata)
	{
		BoolSettings boolSettings = ((metadata != null) ? (metadata.Settings as BoolSettings) : null);
		if (boolSettings != null)
		{
			return boolSettings.DisplayType switch
			{
				BoolDisplayType.Checkbox => "BoolCheckBox", 
				BoolDisplayType.RadioButtons => "Bool", 
				BoolDisplayType.Switch => "BoolSwitch", 
				_ => "Bool", 
			};
		}
		return "Bool";
	}
}

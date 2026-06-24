using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Templates;
using EleWise.ELMA.Web.Mvc.TemplateGenerators;

namespace EleWise.ELMA.BPM.Web.Common.TemplateInputs;

internal sealed class MoneyTemplateInput : TemplateInput
{
	private static Guid doubleGuid = typeof(Money).GUID;

	public override Guid TypeUid => doubleGuid;

	public override string FormatValue(object value, PropertyMetadata propertyMetadata, object container, ClassMetadata containerMetadata, TemplateRenderMode renderMode)
	{
		Money? money = value as Money?;
		if (!money.HasValue)
		{
			return string.Empty;
		}
		return renderMode switch
		{
			TemplateRenderMode.Default => money.Value.ToString(), 
			TemplateRenderMode.HTML => money.Value.Value.ToString("N2"), 
			_ => string.Empty, 
		};
	}
}

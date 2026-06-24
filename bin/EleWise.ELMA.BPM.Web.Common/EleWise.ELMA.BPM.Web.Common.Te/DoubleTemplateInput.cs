using System;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Templates;
using EleWise.ELMA.Web.Mvc.TemplateGenerators;

namespace EleWise.ELMA.BPM.Web.Common.TemplateInputs;

internal sealed class DoubleTemplateInput : TemplateInput
{
	private static Guid doubleGuid = typeof(double).GUID;

	private const int DefaultPrecision = 2;

	private const int MaxPrecision = 15;

	public override Guid TypeUid => doubleGuid;

	public override string FormatValue(object value, PropertyMetadata propertyMetadata, object container, ClassMetadata containerMetadata, TemplateRenderMode renderMode)
	{
		double? num = value as double?;
		if (!num.HasValue)
		{
			return string.Empty;
		}
		switch (renderMode)
		{
		case TemplateRenderMode.Default:
			return num.Value.ToString();
		case TemplateRenderMode.HTML:
		{
			int num2 = 2;
			if (propertyMetadata != null && propertyMetadata.Settings is DoubleSettings doubleSettings && doubleSettings.Precision.HasValue)
			{
				num2 = Math.Min(doubleSettings.Precision.Value, 15);
			}
			return num.Value.ToString("N" + num2);
		}
		default:
			return string.Empty;
		}
	}
}

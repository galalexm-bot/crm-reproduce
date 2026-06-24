using System;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Templates;
using EleWise.ELMA.Web.Mvc.TemplateGenerators;

namespace EleWise.ELMA.BPM.Web.Common.TemplateInputs;

public class BooleanTemplateInput : TemplateInput
{
	private static Guid BooleanGuid = typeof(bool).GUID;

	public override Guid TypeUid => BooleanGuid;

	public override string FormatValue(object value, PropertyMetadata propertyMetadata, object container, ClassMetadata containerMetadata, TemplateRenderMode renderMode)
	{
		bool flag = value is bool && (bool)value;
		switch (renderMode)
		{
		case TemplateRenderMode.Default:
			return flag.ToString();
		case TemplateRenderMode.HTML:
			if (!flag)
			{
				return SR.No;
			}
			return SR.Yes;
		default:
			return string.Empty;
		}
	}
}

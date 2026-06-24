using System;
using System.Web;
using EleWise.ELMA.BPM.Web.Common.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Templates;
using EleWise.ELMA.Web.Mvc.TemplateGenerators;

namespace EleWise.ELMA.BPM.Web.Common.TemplateInputs;

public class BinaryFileTemplateInput : TemplateInput
{
	private static Guid BinaryFileGuid = typeof(BinaryFile).GUID;

	private const string template = "<span {3}='{4}'><a href='{{#BaseUrl#}}SDK.Action/BinaryFiles/Download/{0}' tooltiptext='{2}'>{1}</a></span>";

	public override Guid TypeUid => BinaryFileGuid;

	public override string FormatValue(object value, PropertyMetadata propertyMetadata, object container, ClassMetadata containerMetadata, TemplateRenderMode renderMode)
	{
		if (!(value is BinaryFile binaryFile))
		{
			return string.Empty;
		}
		switch (renderMode)
		{
		case TemplateRenderMode.Default:
			return binaryFile.Name;
		case TemplateRenderMode.HTML:
		{
			string text = binaryFile.Name;
			int num = 50;
			int num2 = 12;
			if (text.Length > num)
			{
				text = $"{text.Substring(0, 20)}...{text.Substring(text.Length - num2, num2)}";
			}
			return string.Format("<span {3}='{4}'><a href='{{#BaseUrl#}}SDK.Action/BinaryFiles/Download/{0}' tooltiptext='{2}'>{1}</a></span>", binaryFile.Uid.ToString(), HttpUtility.HtmlEncode(text), binaryFile.Name, AttachmentTemplateInputExtension.HtmlAttributeString, binaryFile.Id);
		}
		default:
			return string.Empty;
		}
	}
}

using System.Web;
using EleWise.ELMA.BPM.Web.Common.Extensions;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Templates;
using EleWise.ELMA.Web.Mvc.TemplateGenerators;

namespace EleWise.ELMA.BPM.Web.Common.TemplateInputs;

public class AttachmentTemplateInput : EntityTemplateInput<IAttachment>
{
	private const string template = "<span {4}='{5}'><a href='{{#BaseUrl#}}SDK.Action/BinaryFiles/Download/{0}' tooltiptext='{3}'>{1}</a> ({2})</span>";

	public override string GetListSeparator(TemplateRenderMode renderMode)
	{
		if (renderMode != TemplateRenderMode.HTML)
		{
			return "\r\n";
		}
		return "<br/>\r\n";
	}

	public override string FormatValue(object value, TemplateRenderMode renderMode)
	{
		if (!(value is IAttachment attachment) || attachment.File == null)
		{
			return string.Empty;
		}
		switch (renderMode)
		{
		case TemplateRenderMode.Default:
			return $"{attachment.File.Name}: {{#BaseUrl#}}SDK.Action/BinaryFiles/Download/{attachment.File.Uid}";
		case TemplateRenderMode.HTML:
		{
			string text = attachment.File.Name;
			int num = 50;
			int num2 = 12;
			if (text.Length > num)
			{
				text = $"{text.Substring(0, 20)}...{text.Substring(text.Length - num2, num2)}";
			}
			return string.Format("<span {4}='{5}'><a href='{{#BaseUrl#}}SDK.Action/BinaryFiles/Download/{0}' tooltiptext='{3}'>{1}</a> ({2})</span>", attachment.File.Uid.ToString(), HttpUtility.HtmlEncode(text), attachment.CreationDate.HasValue ? attachment.CreationDate.Value.ToString("g") : "", attachment.File.Name, AttachmentTemplateInputExtension.HtmlAttributeString, attachment.Id);
		}
		default:
			return string.Empty;
		}
	}
}

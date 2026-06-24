using System.Web;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Templates;
using EleWise.ELMA.Web.Mvc.TemplateGenerators;

namespace EleWise.ELMA.CRM.Notifications;

public class ContactTemplateInput : EntityTemplateInput<IContact>
{
	public override string FormatValue(object value, TemplateRenderMode renderMode)
	{
		if (!(value is IContact contact))
		{
			return string.Empty;
		}
		return renderMode switch
		{
			TemplateRenderMode.Default => contact.ToString(), 
			TemplateRenderMode.HTML => $"<a href='{{#BaseUrl#}}CRM/Contact/Details/{contact.Id}' style='white-space:nowrap;'>{HttpUtility.HtmlEncode(contact.ToString())}</a>", 
			_ => string.Empty, 
		};
	}

	public override string GetListSeparator(TemplateRenderMode renderMode)
	{
		if (renderMode != TemplateRenderMode.HTML)
		{
			return ", ";
		}
		return "<br/>\r\n";
	}
}

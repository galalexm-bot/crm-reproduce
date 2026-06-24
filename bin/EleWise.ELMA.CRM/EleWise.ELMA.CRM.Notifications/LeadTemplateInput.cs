using System.Web;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Templates;
using EleWise.ELMA.Web.Mvc.TemplateGenerators;

namespace EleWise.ELMA.CRM.Notifications;

public class LeadTemplateInput : EntityTemplateInput<ILead>
{
	public override string FormatValue(object value, TemplateRenderMode renderMode)
	{
		if (!(value is ILead lead))
		{
			return string.Empty;
		}
		return renderMode switch
		{
			TemplateRenderMode.Default => lead.ToString(), 
			TemplateRenderMode.HTML => $"<a href='{{#BaseUrl#}}CRM/Lead/Details/{lead.Id}' style='white-space:nowrap;'>{HttpUtility.HtmlEncode(lead.ToString())}</a>", 
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

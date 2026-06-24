using System.Web;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Templates;
using EleWise.ELMA.Web.Mvc.TemplateGenerators;

namespace EleWise.ELMA.CRM.Notifications;

public abstract class ContractorTemplateInputBase<T> : EntityTemplateInput<T> where T : IEntity
{
	private const string Template = "<a href='{{#BaseUrl#}}CRM/{0}/Details/{1}' style='white-space:nowrap;'>{2}</a>";

	public override string FormatValue(object value, TemplateRenderMode renderMode)
	{
		if (!(value is IContractor contractor))
		{
			return string.Empty;
		}
		string text = ControllerName(contractor);
		string text2 = ContractorName(contractor);
		if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(text2))
		{
			return string.Empty;
		}
		return renderMode switch
		{
			TemplateRenderMode.Default => contractor.ToString(), 
			TemplateRenderMode.HTML => $"<a href='{{#BaseUrl#}}CRM/{text}/Details/{contractor.Id}' style='white-space:nowrap;'>{HttpUtility.HtmlEncode(text2)}</a>", 
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

	public abstract string ControllerName(IContractor value);

	public abstract string ContractorName(IContractor value);
}

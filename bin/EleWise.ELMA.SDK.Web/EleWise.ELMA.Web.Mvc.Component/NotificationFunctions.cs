using System;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Templates;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.TemplateGenerator;
using EleWise.TemplateGenerator.Functions;

namespace EleWise.ELMA.Web.Mvc.Components;

[Component]
public class NotificationFunctions : ITemplateGeneratorFunctionsContainer
{
	public static FormatedValue GetEntityUrl(FunctionEvaluationContext context)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		string value = null;
		if (context != null && context.Parameters != null && context.Parameters.Count > 0)
		{
			FormatedValue formatedValue = context.Parameters[0];
			if (formatedValue != null && formatedValue.Value != null && formatedValue.Value is IEntity obj)
			{
				try
				{
					value = UrlExtensions.ObjectLink(new UrlHelper(new HttpContextWrapper(new HttpContext(new HttpRequest(null, "http://www", ""), new HttpResponse(null))).Request.RequestContext), obj);
				}
				catch (Exception)
				{
				}
			}
		}
		return new FormatedValue(value);
	}
}

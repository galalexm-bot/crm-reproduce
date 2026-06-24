using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.CRM.Web.Integration.Views;

[Component(Order = 90)]
internal class RelationshipFormCreator : FormCreator
{
	public override bool CheckType(Type type)
	{
		if (type == null)
		{
			return false;
		}
		if (typeof(IRelationshipCall).IsAssignableFrom(type) || typeof(IRelationshipMail).IsAssignableFrom(type))
		{
			return base.CheckType(type);
		}
		if (typeof(IRelationshipMeeting).IsAssignableFrom(type))
		{
			return false;
		}
		return typeof(IRelationship).IsAssignableFrom(type);
	}

	public override string OnSubmitScript(HtmlHelper html, string prefix)
	{
		return string.Format("{0}('Form{1}','{1}'); return false;", html.get_ViewData().get_TemplateInfo().GetFullHtmlFieldId("checkEventTimePeriod"), prefix);
	}
}
